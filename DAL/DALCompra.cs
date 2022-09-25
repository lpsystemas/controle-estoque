using ModeloDB.Compra;
using ModeloDB.Compra.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALCompra : ICompra
    {
        private readonly DALConexao _conexao;
        public DALCompra(DALConexao conexao)
        {
            _conexao = conexao;
        }

        public void Alterar(ModeloCompra modelo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"UPDATE COMPRA SET COM_DATA = @COM_DATA, 
                                                          COM_NFISCAL = @COM_NFISCAL,
                                                          COM_TOTAL = @COM_TOTAL,
                                                          COM_NPARCELAS = @COM_NPARCELAS,
                                                          COM_STATUS = @COM_STATUS,
                                                          FOR_COD = @FOR_COD,
                                                          TPA_COD = @TPA_COD 
                                                    WHERE COM_COD = @CODIGO";

                command.Parameters.AddWithValue("@CODIGO", modelo.ComCod);
                command.Parameters.Add("@COM_DATA", SqlDbType.DateTime);
                command.Parameters["@COM_DATA"].Value = modelo.ComData;
                command.Parameters.AddWithValue("@COM_NFISCAL", modelo.ComNFiscal);
                command.Parameters.AddWithValue("@COM_TOTAL", modelo.ComTotal);
                command.Parameters.AddWithValue("@COM_NPARCELAS", modelo.ComNParcelas);
                command.Parameters.AddWithValue("@COM_STATUS", modelo.ComStatus);
                command.Parameters.AddWithValue("@FOR_COD", modelo.ForCod);
                command.Parameters.AddWithValue("@TPA_COD", modelo.TpaCod);

                _conexao.Conectar();
                command.ExecuteNonQuery();
                _conexao.Desconectar();
            }
        }

        public ModeloCompra CarregaCompra(int codigo)
        {
            ModeloCompra modelo_Compra = new ModeloCompra();

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"SELECT COMPRA.COM_COD,
                                               COMPRA.COM_DATA,
                                               COMPRA.COM_NFISCAL,
                                               COMPRA.COM_TOTAL,
                                               COMPRA.COM_NPARCELAS,
                                               COMPRA.COM_STATUS,
                                               COMPRA.FOR_COD,
                                               COMPRA.TPA_COD
	                                      FROM COMPRA (NOLOCK)
                                         WHERE COMPRA.COM_COD = @CODIGO";

                command.Parameters.AddWithValue("@CODIGO", codigo);

                _conexao.Conectar();
                SqlDataReader registro = command.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo_Compra.ComCod = Convert.ToInt32(registro["COM_COD"]);
                    modelo_Compra.ComData = Convert.ToDateTime(registro["COM_DATA"]);
                    modelo_Compra.ComNFiscal = Convert.ToInt32(registro["COM_NFISCAL"]);
                    modelo_Compra.ComTotal = Convert.ToDouble(registro["COM_TOTAL"]);
                    modelo_Compra.ComNParcelas = Convert.ToInt32(registro["COM_NPARCELAS"]);
                    modelo_Compra.ComStatus = Convert.ToString(registro["COM_STATUS"]);
                    modelo_Compra.ForCod = Convert.ToInt32(registro["FOR_COD"]);
                    modelo_Compra.TpaCod = Convert.ToInt32(registro["TPA_COD"]);
                }

                registro.Close();
                _conexao.Desconectar();
                return modelo_Compra;
            }
        }

        public void Excluir(int codigo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"DELETE FROM COMPRA 
                                              WHERE COM_COD = @CODIGO";

                command.Parameters.AddWithValue("@CODIGO", codigo);

                _conexao.Conectar();
                command.ExecuteNonQuery();
                _conexao.Desconectar();
            }
        }

        public void Incluir(ModeloCompra modelo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"INSERT INTO COMPRA(COM_DATA, 
                                                           COM_NFISCAL, 
                                                           COM_TOTAL, 
                                                           COM_NPARCELAS, 
                                                           COM_STATUS, 
                                                           FOR_COD, 
                                                           TPA_COD) 

                                                    VALUES(@COM_DATA, 
                                                           @COM_NFISCAL, 
                                                           @COM_TOTAL, 
                                                           @COM_NPARCELAS, 
                                                           @COM_STATUS, 
                                                           @FOR_COD, 
                                                           @TPA_COD); SELECT @@IDENTITY;";

                command.Parameters.Add("@COM_DATA", SqlDbType.DateTime);
                command.Parameters["@COM_DATA"].Value = modelo.ComData;

                command.Parameters.AddWithValue("@COM_NFISCAL", modelo.ComNFiscal);
                command.Parameters.AddWithValue("@COM_TOTAL", modelo.ComTotal);
                command.Parameters.AddWithValue("@COM_NPARCELAS", modelo.ComNParcelas);
                command.Parameters.AddWithValue("@COM_STATUS", modelo.ComStatus);
                command.Parameters.AddWithValue("@FOR_COD", modelo.ForCod);
                command.Parameters.AddWithValue("@TPA_COD", modelo.TpaCod);
                

                _conexao.Conectar();
                modelo.ComCod = Convert.ToInt32(command.ExecuteScalar());
                _conexao.Desconectar();
            }
        }

        public DataTable LocalizarPorCodigoFornecedor(int codigo)
        {
            using (DataTable tabela = new DataTable())
            {
                string sql = string.Format($@"SELECT COMPRA.COM_COD,
                                                    COMPRA.COM_DATA,
                                                    COMPRA.COM_NFISCAL,
                                                    COMPRA.COM_NPARCELAS,
                                                    FORNECEDOR.FOR_NOME,
                                                    COMPRA.COM_STATUS,
                                                    COMPRA.FOR_COD,
                                                    COMPRA.TPA_COD,
	                                                COMPRA.COM_TOTAL
                                               FROM COMPRA (NOLOCK)
                                     
                                               INNER JOIN FORNECEDOR (NOLOCK)
                                                 ON (COMPRA.FOR_COD = FORNECEDOR.FOR_COD)
                                     
                                              WHERE FORNECEDOR.FOR_COD = {Convert.ToString(codigo)}");

                SqlDataAdapter adapter = new SqlDataAdapter(sql, _conexao.StringConexao);
                adapter.Fill(tabela);

                return tabela;
            }
        }

        public DataTable LocalizarPorData(DateTime dtInicial, DateTime dtFinal)
        {
            using (DataTable tabela = new DataTable())
            {
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = _conexao.ObjetoConexao;
                    command.CommandText = $@"SELECT COMPRA.COM_COD,
                                                    COMPRA.COM_DATA,
                                                    COMPRA.COM_NFISCAL,
                                                    COMPRA.COM_NPARCELAS,
                                                    FORNECEDOR.FOR_NOME,
                                                    COMPRA.COM_STATUS,
                                                    COMPRA.FOR_COD,
                                                    COMPRA.TPA_COD,
	                                                COMPRA.COM_TOTAL
                                               FROM COMPRA (NOLOCK)
                                     
                                              INNER JOIN FORNECEDOR (NOLOCK)
                                                 ON (COMPRA.FOR_COD = FORNECEDOR.FOR_COD)
                                     
                                              WHERE COMPRA.COM_DATA BETWEEN @DTINICIAL AND DTFINAL";

                    command.Parameters.Add("@DTINICIAL", SqlDbType.DateTime);
                    command.Parameters["@DTINICIAL"].Value = dtInicial;

                    command.Parameters.Add("@DTFINAL", SqlDbType.DateTime);
                    command.Parameters["@DTFINAL"].Value = dtFinal;

                    SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, _conexao.StringConexao);
                    adapter.Fill(tabela);

                    return tabela;
                }
                
            }
        }

        public DataTable LocalizarPorNomeFornecedor(string nome)
        {
            using (DataTable tabela = new DataTable())
            {
                string sql = string.Format($@"SELECT COMPRA.COM_COD,
                                                     COMPRA.COM_DATA,
                                                     COMPRA.COM_NFISCAL,
                                                     COMPRA.COM_NPARCELAS,
                                                     FORNECEDOR.FOR_NOME,
                                                     COMPRA.COM_STATUS,
                                                     COMPRA.FOR_COD,
                                                     COMPRA.TPA_COD,
	                                                 COMPRA.COM_TOTAL
                                                FROM COMPRA (NOLOCK)
                                     
                                               INNER JOIN FORNECEDOR (NOLOCK)
                                                  ON (COMPRA.FOR_COD = FORNECEDOR.FOR_COD)
                                     
                                               WHERE FORNECEDOR.FOR_NOME LIKE '{nome}%'");

                SqlDataAdapter adapter = new SqlDataAdapter(sql, _conexao.StringConexao);
                adapter.Fill(tabela);

                return tabela;
            }
        }

        public DataTable LocalizarPorParcelasEmAberto()
        {
            using (DataTable tabela = new DataTable())
            {
                string sql = string.Format($@"SELECT DISTINCT COMPRA.COM_COD,
                                                              COMPRA.COM_DATA,
                                                              COMPRA.COM_NFISCAL,
                                                              COMPRA.COM_NPARCELAS,
                                                              FORNECEDOR.FOR_NOME,
                                                              COMPRA.COM_STATUS,
                                                              COMPRA.FOR_COD,
                                                              COMPRA.TPA_COD,
	                                                          COMPRA.COM_TOTAL
                                                         FROM COMPRA (NOLOCK)
                                     
                                                   INNER JOIN FORNECEDOR (NOLOCK)
                                                           ON (COMPRA.FOR_COD = FORNECEDOR.FOR_COD)

                                                   INNER JOIN PARCELASCOMPRA (NOLOCK)
                                                           ON (COMPRA.COM_COD = PARCELASCOMPRA.COM_COD)
                                     
                                                        WHERE PARCELASCOMPRA.PCO_DATAPAGTO IS NULL");

                SqlDataAdapter adapter = new SqlDataAdapter(sql, _conexao.StringConexao);
                adapter.Fill(tabela);

                return tabela;
            }
        }

        public DataTable LocalizarTodas()
        {
            using (DataTable tabela = new DataTable())
            {
                string sql = string.Format($@"SELECT COMPRA.COM_COD,
                                                     COMPRA.COM_DATA,
                                                     COMPRA.COM_NFISCAL,
                                                     COMPRA.COM_NPARCELAS,
                                                     FORNECEDOR.FOR_NOME,
                                                     COMPRA.COM_STATUS,
                                                     COMPRA.FOR_COD,
                                                     COMPRA.TPA_COD,
	                                                 COMPRA.COM_TOTAL
                                                FROM COMPRA (NOLOCK)
                                     
                                               INNER JOIN FORNECEDOR (NOLOCK)
                                                  ON (COMPRA.FOR_COD = FORNECEDOR.FOR_COD)");

                SqlDataAdapter adapter = new SqlDataAdapter(sql, _conexao.StringConexao);
                adapter.Fill(tabela);

                return tabela;
            }
        }

        public int QuantidadeParcelasNaoPagas(int codigo)
        {
            var quantidade = 0;

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"SELECT COUNT(COM_COD) 
                                          FROM PARCELASCOMPRA

                                         WHERE COM_COD = @CODIGO
                                           AND PCO_DATAPAGTO IS NULL";

                command.Parameters.AddWithValue("@CODIGO", codigo);

                _conexao.Conectar();
                quantidade = Convert.ToInt32(command.ExecuteNonQuery());
                _conexao.Desconectar();

                return quantidade;
            }
        }
    }
}
