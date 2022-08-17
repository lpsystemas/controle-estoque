using ModeloDB.Compra;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALItensCompra : IItensCompra
    {
        private readonly DALConexao _conexao;
        public DALItensCompra(DALConexao conexao)
        {
            _conexao = conexao;
        }

        public void Alterar(ModeloItensCompra modelo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;                

                command.CommandText = @"UPDATE ITENSCOMPRA SET ITC_QTDE = @ITC_QTDE, 
                                                               ITC_VALOR = @ITC_VALOR

                                                         WHERE ITC_COD = @ITC_COD
                                                           AND COM_COD = @COM_COD
                                                           AND PRO_COD = @PRO_COD";

                command.Parameters.AddWithValue("@ITC_COD", modelo.ItcCod);
                command.Parameters.AddWithValue("@ITC_QTDE", modelo.ItcQtde);
                command.Parameters.AddWithValue("@ITC_VALOR", modelo.ItcValor);
                command.Parameters.AddWithValue("@COM_COD", modelo.ComCod);
                command.Parameters.AddWithValue("@PRO_COD", modelo.ProCod);
                

                _conexao.Conectar();
                command.ExecuteNonQuery();
                _conexao.Desconectar();
            }
        }

        public ModeloItensCompra CarregaItensCompra(
            int codigoItem,
            int codigoCompra,
            int codigoProduto)
        {
            ModeloItensCompra modelo_ItensCompra = new ModeloItensCompra();

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"SELECT ITENSCOMPRA.ITC_COD,
                                               ITENSCOMPRA.ITC_QTDE,
                                               ITENSCOMPRA.ITC_VALOR,
                                               ITENSCOMPRA.COM_COD,
                                               ITENSCOMPRA.PRO_COD
                                               
	                                      FROM ITENSCOMPRA (NOLOCK)
                                         WHERE ITENSCOMPRA.ITC_COD = @ITC_COD,
                                           AND ITENSCOMPRA.COM_COD = @COM_COD
                                           AND ITENSCOMPRA.PRO_COD = @PRO_COD";

                command.Parameters.AddWithValue("@ITC_COD", codigoItem);
                command.Parameters.AddWithValue("@COM_COD", codigoCompra);
                command.Parameters.AddWithValue("@PRO_COD", codigoProduto);

                _conexao.Conectar();
                SqlDataReader registro = command.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo_ItensCompra.ItcCod = codigoItem;
                    modelo_ItensCompra.ProCod = codigoProduto;
                    modelo_ItensCompra.ComCod = codigoCompra;
                    modelo_ItensCompra.ItcQtde = Convert.ToDouble(registro["ITC_QTDE"]);
                    modelo_ItensCompra.ItcValor = Convert.ToDouble(registro["ITC_VALOR"]);                    
                }

                registro.Close();
                _conexao.Desconectar();
                return modelo_ItensCompra;
            }
        }

        public void Excluir(ModeloItensCompra modelo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"DELETE FROM ITENSCOMPRA 
                                              WHERE ITC_COD = @ITC_COD
                                                AND COM_COD = @COM_COD
                                                AND PRO_COD = @PRO_COD";

                command.Parameters.AddWithValue("@ITC_COD", modelo.ItcCod);
                command.Parameters.AddWithValue("@COM_COD", modelo.ComCod);
                command.Parameters.AddWithValue("@PRO_COD", modelo.ProCod);

                _conexao.Conectar();
                command.ExecuteNonQuery();
                _conexao.Desconectar();
            }
        }

        public void ExcluirTodosOsItens(int codigo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"DELETE FROM ITENSCOMPRA 
                                              WHERE COM_COD = @COM_COD";

                command.Parameters.AddWithValue("@COM_COD", codigo);
                
                _conexao.Conectar();
                command.ExecuteNonQuery();
                _conexao.Desconectar();
            }
        }

        public void Incluir(ModeloItensCompra modelo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"INSERT INTO ITENSCOMPRA(ITC_COD, 
                                                                ITC_QTDE, 
                                                                ITC_VALOR, 
                                                                COM_COD,                                                                  
                                                                PRO_COD) 

                                                         VALUES(@ITC_COD, 
                                                                @ITC_QTDE, 
                                                                @ITC_VALOR, 
                                                                @COM_COD, 
                                                                @PRO_COD); SELECT @@IDENTITY;";

                command.Parameters.AddWithValue("@ITC_COD", modelo.ItcCod);
                command.Parameters.AddWithValue("@ITC_QTDE", modelo.ItcQtde);
                command.Parameters.AddWithValue("@ITC_VALOR", modelo.ItcValor);
                command.Parameters.AddWithValue("@COM_COD", modelo.ComCod);
                command.Parameters.AddWithValue("@PRO_COD", modelo.ProCod);

                _conexao.Conectar();
                modelo.ComCod = Convert.ToInt32(command.ExecuteScalar());
                _conexao.Desconectar();
            }
        }

        public DataTable LocalizarItens(int codigo)
        {
            using (DataTable tabela = new DataTable())
            {
                string sql = string.Format($@"SELECT ITENSCOMPRA.COM_COD,
                                                     ITENSCOMPRA.ITC_COD,
                                                     ITENSCOMPRA.PRO_COD,                                                     
                                                     PRODUTO.PRO_NOME,
                                                     ITENSCOMPRA.ITC_QTDE,
                                                     ITENSCOMPRA.ITC_VALOR,
                                                     ITENSCOMPRA.TPA_COD,
	                                                 ITENSCOMPRA.COM_TOTAL
                                                FROM ITENSCOMPRA (NOLOCK)
                                     
                                               INNER JOIN PRODUTO (NOLOCK)
                                                  ON (ITENSCOMPRA.PRO_COD = PRODUTO.PRO_COD)
                                        
                                               WHERE ITENSCOMPRA.COM_COD = {Convert.ToString(codigo)}");

                SqlDataAdapter adapter = new SqlDataAdapter(sql, _conexao.StringConexao);
                adapter.Fill(tabela);

                return tabela;
            }
        }
    }
}
