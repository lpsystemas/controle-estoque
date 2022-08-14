using ModeloDB.Produto;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALProduto : IProduto
    {
        private readonly DALConexao _conexao;

        public DALProduto(DALConexao conexao)
        {
            _conexao = conexao;
        }
        public void Alterar(ModeloProduto modelo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"UPDATE PRODUTO SET PRO_NOME = @NOME,
                                                           PRO_DESCRICAO = @DESC,
                                                           PRO_FOTO = @FOTO,
                                                           PRO_VALORPAGO = @VALORPAGO,
                                                           PRO_VALORVENDA = @VALORVENDA,
                                                           PRO_QTDE = @QUANTIDADE,
                                                           UMED_COD = @UMED,
                                                           CAT_COD = @CATEGORIA,
                                                           SCAT_COD = @SUBCAT
                                                     WHERE PRO_COD = @CODIGO";

                command.Parameters.AddWithValue("@CODIGO", modelo.ProdCod);
                command.Parameters.AddWithValue("@NOME", modelo.ProdNome);
                command.Parameters.AddWithValue("@DESC", modelo.ProdDesc);
                command.Parameters.Add("@FOTO", SqlDbType.Image);

                if (modelo.ProdFoto == null)
                    command.Parameters["@FOTO"].Value = DBNull.Value;
                else
                    command.Parameters["@FOTO"].Value = modelo.ProdFoto;

                command.Parameters.AddWithValue("@VALORPAGO", modelo.ProdValorPago);
                command.Parameters.AddWithValue("@VALORVENDA", modelo.ProdValorVenda);
                command.Parameters.AddWithValue("@QUANTIDADE", modelo.ProdQuantidade);
                command.Parameters.AddWithValue("@UMED", modelo.UmedCod);
                command.Parameters.AddWithValue("@CATEGORIA", modelo.CatCod);
                command.Parameters.AddWithValue("@SUBCAT", modelo.SCatCod);

                _conexao.Conectar();
                command.ExecuteNonQuery();
                _conexao.Desconectar();
            }
        }

        public ModeloProduto CarregaProduto(int codigo)
        {
            ModeloProduto modelo_Produto = new ModeloProduto();

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"SELECT PRODUTO.PRO_COD,
                                               PRODUTO.PRO_NOME,
                                               PRODUTO.PRO_DESCRICAO,
                                               PRODUTO.PRO_FOTO,
                                               PRODUTO.PRO_VALORPAGO,
                                               PRODUTO.PRO_VALORVENDA,
                                               PRODUTO.PRO_QTDE,
                                               PRODUTO.UMED_COD,
                                               PRODUTO.CAT_COD,
                                               PRODUTO.SCAT_COD
	                                      FROM PRODUTO (NOLOCK)
                                         WHERE PRODUTO.PRO_COD = @CODIGO";

                command.Parameters.AddWithValue("@CODIGO", codigo);

                _conexao.Conectar();
                SqlDataReader registro = command.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo_Produto.ProdCod = Convert.ToInt32(registro["PRO_COD"]);
                    modelo_Produto.ProdNome = Convert.ToString(registro["PRO_NOME"]);
                    modelo_Produto.ProdDesc = Convert.ToString(registro["PRO_DESCRICAO"]);

                    try
                    {
                        modelo_Produto.ProdFoto = (byte[])registro["PRO_FOTO"];
                    }
                    catch { }

                    modelo_Produto.ProdValorPago = Convert.ToDouble(registro["PRO_VALORPAGO"]);
                    modelo_Produto.ProdValorVenda = Convert.ToDouble(registro["PRO_VALORVENDA"]);
                    modelo_Produto.ProdQuantidade = Convert.ToInt32(registro["PRO_QTDE"]);
                    modelo_Produto.UmedCod = Convert.ToInt32(registro["UMED_COD"]);
                    modelo_Produto.CatCod = Convert.ToInt32(registro["CAT_COD"]);
                    modelo_Produto.SCatCod = Convert.ToInt32(registro["SCAT_COD"]);

                }

                _conexao.Desconectar();
                return modelo_Produto;
            }
        }

        public void Excluir(int codigo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"DELETE FROM PRODUTO 
                                              WHERE PRO_COD = @CODIGO";

                command.Parameters.AddWithValue("@CODIGO", codigo);

                _conexao.Conectar();
                command.ExecuteNonQuery();
                _conexao.Desconectar();
            }
        }

        public void Incluir(ModeloProduto modelo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _conexao.ObjetoConexao;

                command.CommandText = @"INSERT INTO PRODUTO(PRO_NOME, 
                                                            PRO_DESCRICAO, 
                                                            PRO_FOTO, 
                                                            PRO_VALORPAGO, 
                                                            PRO_VALORVENDA, 
                                                            PRO_QTDE, 
                                                            UMED_COD, 
                                                            CAT_COD, 
                                                            SCAT_COD) 

                                                     VALUES(@NOME,
                                                            @DESC, 
                                                            @FOTO, 
                                                            @VALORPAGO, 
                                                            @VALORVENDA, 
                                                            @QUANTIDADE, 
                                                            @UMED, 
                                                            @CATEGORIA, 
                                                            @SUBCAT); SELECT @@IDENTITY;";

                command.Parameters.AddWithValue("@NOME", modelo.ProdNome);
                command.Parameters.AddWithValue("@DESC", modelo.ProdDesc);
                command.Parameters.Add("@FOTO", SqlDbType.Image);

                if (modelo.ProdFoto == null)
                    command.Parameters["@FOTO"].Value = DBNull.Value;
                else
                    command.Parameters["@FOTO"].Value = modelo.ProdFoto;

                command.Parameters.AddWithValue("@VALORPAGO", modelo.ProdValorPago);
                command.Parameters.AddWithValue("@VALORVENDA", modelo.ProdValorVenda);
                command.Parameters.AddWithValue("@QUANTIDADE", modelo.ProdQuantidade);
                command.Parameters.AddWithValue("@UMED", modelo.UmedCod);
                command.Parameters.AddWithValue("@CATEGORIA", modelo.CatCod);
                command.Parameters.AddWithValue("@SUBCAT", modelo.SCatCod);

                _conexao.Conectar();
                modelo.ProdCod = Convert.ToInt32(command.ExecuteScalar());
                _conexao.Desconectar();
            }
        }

        public DataTable Localizar(string nome)
        {
            using (DataTable tabela = new DataTable())
            {
                string sql = string.Format(@"SELECT PRODUTO.PRO_COD,
                                                    PRODUTO.PRO_NOME,
                                                    PRODUTO.PRO_DESCRICAO,
                                                    PRODUTO.PRO_FOTO,
                                                    PRODUTO.PRO_VALORPAGO,
                                                    PRODUTO.PRO_VALORVENDA,
                                                    PRODUTO.PRO_QTDE,
                                                    PRODUTO.UMED_COD,
	                                                UNDMEDIDA.UMED_NOME,
                                                    PRODUTO.CAT_COD,
	                                                CATEGORIA.CAT_NOME,
                                                    PRODUTO.SCAT_COD,
	                                                SUBCATEGORIA.SCAT_NOME
                                               FROM PRODUTO (NOLOCK)
                                     
                                               JOIN CATEGORIA (NOLOCK)
                                                 ON (PRODUTO.CAT_COD = CATEGORIA.CAT_COD)
                                     
                                               JOIN SUBCATEGORIA (NOLOCK)
                                                 ON (PRODUTO.SCAT_COD = SUBCATEGORIA.SCAT_COD)
                                     
                                               JOIN UNDMEDIDA (NOLOCK)
                                                 ON (PRODUTO.UMED_COD = UNDMEDIDA.UMED_COD)
                                    
                                              WHERE PRODUTO.PRO_NOME LIKE '{0}%'", nome);

                SqlDataAdapter adapter = new SqlDataAdapter(sql, _conexao.StringConexao);
                adapter.Fill(tabela);

                return tabela;
            }
        }
    }
}
