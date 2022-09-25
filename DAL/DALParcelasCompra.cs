using ModeloDB.Compra;
using ModeloDB.Compra.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALParcelasCompra : IParcelasCompra
    {
        private readonly DALConexao _conexao;
        public DALParcelasCompra(DALConexao conexao)
        {
            _conexao = conexao;
        }

        public void Alterar(ModeloParcelasCompra modelo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"UPDATE PARCELASCOMPRA SET PCO_VALOR = @PCO_VALOR, 
                                                                  PCO_ DATAPAGTO = @PCO_DATAPAGTO,
                                                                  PCO_ DATAVECTO = @PCO_DATAVECTO

                                                              WHERE PCO_COD = @PCO_COD
                                                                AND COM_COD = @COM_COD";

                command.Parameters.AddWithValue("@PCO_COD", modelo.PcoCod);
                command.Parameters.AddWithValue("@COM_COD", modelo.ComCod);
                command.Parameters.AddWithValue("@PCO_VALOR", modelo.PcoValor);
                command.Parameters.Add("@PCO_DATAPAGTO", SqlDbType.DateTime);
                command.Parameters.Add("@PCO_DATAVECTO", SqlDbType.DateTime);

                if (modelo.PcoDataPagto == null)
                    command.Parameters["PCO_DATAPAGTO"].Value = DBNull.Value;
                else
                    command.Parameters["PCO_DATAPAGTO"].Value = modelo.PcoDataPagto;

                command.Parameters["PCO_DATAVECTO"].Value = modelo.PcoDataVecto;


                _conexao.Conectar();
                command.ExecuteNonQuery();
                _conexao.Desconectar();
            }
        }

        public ModeloParcelasCompra CarregaParcelasCompra(
            int pcoCod,
            int codCompra)
        {
            ModeloParcelasCompra modelo_ParcelasCompra = new ModeloParcelasCompra();

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"SELECT PARCELASCOMPRA.PCO_COD,
                                               PARCELASCOMPRA.PCO_VALOR,
                                               PARCELASCOMPRA.PCO_DATAPAGTO,
                                               PARCELASCOMPRA.PCO_DATAVECTO,
                                               PARCELASCOMPRA.COM_COD
                                               
	                                      FROM PARCELASCOMPRA (NOLOCK)
                                         WHERE PARCELASCOMPRA.PCO_COD = @PCO_COD,
                                           AND PARCELASCOMPRA.COM_COD = @COM_COD";

                command.Parameters.AddWithValue("@PCO_COD", pcoCod);
                command.Parameters.AddWithValue("@COM_COD", codCompra);                

                _conexao.Conectar();
                SqlDataReader registro = command.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo_ParcelasCompra.ComCod = pcoCod;
                    modelo_ParcelasCompra.ComCod = codCompra;
                    modelo_ParcelasCompra.PcoDataPagto = Convert.ToDateTime(registro["PCO_DATAPAGTO"]);
                    modelo_ParcelasCompra.PcoDataPagto = Convert.ToDateTime(registro["PCO_DATAVECTO"]);
                    modelo_ParcelasCompra.PcoValor = Convert.ToDouble(registro["PCO_VALOR"]);
                }

                registro.Close();
                _conexao.Desconectar();
                return modelo_ParcelasCompra;
            }
        }

        public void EfetuaPagamentoParcela(
            int codCompra,
            int pcoCod,
            DateTime dtPagamento)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"UPDATE PARCELASCOMPRA SET PCO_DATAPAGTO = @PCO_DATAPAGTO 
                                                              WHERE PCO_COD = @PCO_COD
                                                                AND COM_COD = @COM_COD";

                command.Parameters.AddWithValue("@PCO_COD", pcoCod);
                command.Parameters.AddWithValue("@COM_COD", codCompra);
                command.Parameters.Add("@PCO_DATAPAGTO", SqlDbType.Date);
                command.Parameters["@PCO_DATAPAGTO"].Value = dtPagamento.Date;

                _conexao.Conectar();
                command.ExecuteNonQuery();
                _conexao.Desconectar();
            }
        }

        public void Excluir(ModeloParcelasCompra modelo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"DELETE FROM PARCELASCOMPRA 
                                              WHERE PCO_COD = @PCO_COD
                                                AND COM_COD = @COM_COD";

                command.Parameters.AddWithValue("@PCO_COD", modelo.PcoCod);
                command.Parameters.AddWithValue("@COM_COD", modelo.ComCod);

                _conexao.Conectar();
                command.ExecuteNonQuery();
                _conexao.Desconectar();
            }
        }

        public void ExcluirTodasAsParcelas(int codCompra)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"DELETE FROM PARCELASCOMPRA 
                                              WHERE COM_COD = @COM_COD";

                command.Parameters.AddWithValue("@COM_COD", codCompra);

                _conexao.Conectar();
                command.ExecuteNonQuery();
                _conexao.Desconectar();
            }
        }

        public void Incluir(ModeloParcelasCompra modelo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"INSERT INTO PARCELASCOMPRA(PCO_COD, 
                                                                   COM_COD, 
                                                                   PCO_DATAVECTO, 
                                                                   PCO_VALOR) 

                                                            VALUES(@PCO_COD, 
                                                                   @COM_COD, 
                                                                   @PCO_DATAVECTO, 
                                                                   @PCO_VALOR); SELECT @@IDENTITY;";

                command.Parameters.AddWithValue("@PCO_COD", modelo.PcoCod);
                command.Parameters.AddWithValue("@COM_COD", modelo.ComCod);
                command.Parameters.AddWithValue("@PCO_VALOR", modelo.PcoValor);
                command.Parameters.Add("@PCO_DATAVECTO", SqlDbType.Date);

                if (modelo.PcoDataVecto == null)
                    command.Parameters["@PCO_DATAVECTO"].Value = DBNull.Value;
                else
                    command.Parameters["@PCO_DATAVECTO"].Value = modelo.PcoDataVecto;

                _conexao.Conectar();
                command.ExecuteScalar();
                _conexao.Desconectar();
            }
        }

        public DataTable Localizar(int codCompra)
        {
            using (DataTable tabela = new DataTable())
            {
                string sql = string.Format($@"SELECT PARCELASCOMPRA.PCO_COD,
                                                     PARCELASCOMPRA.PCO_VALOR,
                                                     PARCELASCOMPRA.PCO_DATAPAGTO,
                                                     PARCELASCOMPRA.PCO_DATAVECTO,
                                                     PARCELASCOMPRA.COM_COD
                                                FROM PARCELASCOMPRA (NOLOCK)
                                                
                                                WHERE COM_COD = {Convert.ToString(codCompra)}");

                SqlDataAdapter adapter = new SqlDataAdapter(sql, _conexao.StringConexao);
                adapter.Fill(tabela);

                return tabela;
            }
        }
    }
}
