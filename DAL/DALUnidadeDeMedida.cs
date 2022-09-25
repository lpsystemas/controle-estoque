using ModeloDB.UnidadeDeMedida;
using ModeloDB.UnidadeDeMedida.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALUnidadeDeMedida : IUnidadeDeMedida
    {
        private readonly DALConexao conexao;

        public DALUnidadeDeMedida(DALConexao conexao)
        {
            this.conexao = conexao;
        }

        public void Alterar(ModeloUnidadeDeMedida modelo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conexao.ObjetoConexao;

                command.CommandText = @"UPDATE UNDMEDIDA SET UMED_NOME = @NOME
                                                       WHERE UMED_COD = @CODIGO";

                command.Parameters.AddWithValue("@CODIGO", modelo.UmedCod);
                command.Parameters.AddWithValue("@NOME", modelo.UmedNome);

                conexao.Conectar();
                command.ExecuteNonQuery();
                conexao.Desconectar();
            }
        }

        public ModeloUnidadeDeMedida CarregaUnidadeDeMedida(int codigo)
        {
            ModeloUnidadeDeMedida modelo_Umed = new ModeloUnidadeDeMedida();

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conexao.ObjetoConexao;

                command.CommandText = @"SELECT UNDMEDIDA.UMED_COD,
                                               UNDMEDIDA.UMED_NOME
                                          FROM UNDMEDIDA (NOLOCK)
                                         WHERE UMED_COD = @CODIGO";

                command.Parameters.AddWithValue("@CODIGO", codigo);

                conexao.Conectar();
                SqlDataReader registro = command.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo_Umed.UmedCod = Convert.ToInt32(registro["UMED_COD"]);
                    modelo_Umed.UmedNome = Convert.ToString(registro["UMED_NOME"]);
                }

                conexao.Desconectar();
                return modelo_Umed;
            }
        }

        public void Excluir(int codigo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conexao.ObjetoConexao;

                command.CommandText = @"DELETE FROM UNDMEDIDA 
                                              WHERE UMED_COD = @CODIGO";

                command.Parameters.AddWithValue("@CODIGO", codigo);

                conexao.Conectar();
                command.ExecuteNonQuery();
                conexao.Desconectar();
            }
        }

        public void Incluir(ModeloUnidadeDeMedida modelo)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conexao.ObjetoConexao;

                command.CommandText = @"INSERT INTO UNDMEDIDA(UMED_NOME) 
                                               VALUES(@NOME); SELECT @@IDENTITY;";

                command.Parameters.AddWithValue("@NOME", modelo.UmedNome);

                conexao.Conectar();
                modelo.UmedCod = Convert.ToInt32(command.ExecuteScalar());
                conexao.Desconectar();
            }
        }

        public DataTable Localizar(string nome)
        {
            using (DataTable tabela = new DataTable())
            {
                string sql = string.Format(@"SELECT UNDMEDIDA.UMED_COD,
                                                    UNDMEDIDA.UMED_NOME
	                                           FROM UNDMEDIDA (NOLOCK)
                                              WHERE UNDMEDIDA.UMED_NOME LIKE '{0}%'", nome);

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao.StringConexao);
                adapter.Fill(tabela);

                return tabela;
            }
        }

        public bool VerificaUnidadeDeMedidaCadastrada(string nomeUnd)
        {
            bool valor = false;

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conexao.ObjetoConexao;

                command.CommandText = @"SELECT UMED_COD,
                                               UMED_NOME
                                          FROM UNDMEDIDA
                                         WHERE UMED_NOME = @NOME";

                command.Parameters.AddWithValue("@NOME", nomeUnd);

                conexao.Conectar();
                SqlDataReader registro = command.ExecuteReader();

                if (registro.HasRows)
                    valor = true;

                conexao.Desconectar();
                return valor;
            }

        }
    }
}
