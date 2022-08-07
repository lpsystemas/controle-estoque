using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALUtils
    {
        private readonly DALConexao conexao = null;

        public DALUtils(DALConexao conn)
        {
            this.conexao = conn;
        }

        public DataTable CarregaComboBoxCategoria()
        {
            using (DataTable tabela = new DataTable())
            {
                string sql = string.Format(@"SELECT CATEGORIA.CAT_COD,
                                                    CATEGORIA.CAT_NOME	   
                                               FROM CATEGORIA (NOLOCK)");

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao.StringConexao);
                adapter.Fill(tabela);

                return tabela;
            }
        }

        public DataTable CarregaComboBoxSubCategoriaPorCategoria(int codigoCategoria)
        {
            using (DataTable tabela = new DataTable())
            {
                string sql = string.Format(@"SELECT SUBCATEGORIA.CAT_COD,
                                                    SUBCATEGORIA.SCAT_COD,     
                                                    SUBCATEGORIA.SCAT_NOME
                                               FROM SUBCATEGORIA (NOLOCK)
                                              WHERE SUBCATEGORIA.CAT_COD = {0}", codigoCategoria);

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao.StringConexao);
                adapter.Fill(tabela);

                return tabela;
            }
        }

        public DataTable CarregaComboBoxUnidadeMedida()
        {
            using (DataTable tabela = new DataTable())
            {
                string sql = string.Format(@"SELECT UNDMEDIDA.UMED_COD,
                                                    UNDMEDIDA.UMED_NOME
                                               FROM UNDMEDIDA (NOLOCK)");

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao.StringConexao);
                adapter.Fill(tabela);

                return tabela;
            }
        }
    }
}
