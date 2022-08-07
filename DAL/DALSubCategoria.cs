using ModeloDB.SubCategoria;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
  public class DALSubCategoria : ISubCategoria
  {
    private readonly DALConexao conexao;

    public DALSubCategoria(DALConexao conn)
    {
      this.conexao = conn;
    }

    public void Alterar(ModeloSubCategoria modelo)
    {
      using(SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"UPDATE SUBCATEGORIA SET SCAT_NOME = @NOME,
                                                          CAT_COD = @CODIGO_CATEGORIA
                                 WHERE SCAT_COD = @CODIGO";

        command.Parameters.AddWithValue("@CODIGO", modelo.SCatCod);
        command.Parameters.AddWithValue("@CODIGO_CATEGORIA", modelo.CatCod);
        command.Parameters.AddWithValue("@NOME", modelo.SCatNome);

        conexao.Conectar();
        command.ExecuteNonQuery();
        conexao.Desconectar();
      }      
    }

    public ModeloSubCategoria CarregaSubCategoria(int codigo)
    {
      ModeloSubCategoria subModelo_Cat = new ModeloSubCategoria();

      using(SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"SELECT SUBCATEGORIA.CAT_COD,
                                       SUBCATEGORIA.SCAT_COD,     
                                       SUBCATEGORIA.SCAT_NOME
                                  FROM SUBCATEGORIA
                                 WHERE SCAT_COD = @CODIGO";

        command.Parameters.AddWithValue("@CODIGO", codigo);

        conexao.Conectar();
        SqlDataReader registro = command.ExecuteReader();

        if (registro.HasRows)
        {
          registro.Read();

          subModelo_Cat.CatCod = Convert.ToInt32(registro["CAT_COD"]);
          subModelo_Cat.SCatCod = Convert.ToInt32(registro["SCAT_COD"]);
          subModelo_Cat.SCatNome = Convert.ToString(registro["SCAT_NOME"]);
        }

        conexao.Desconectar();
        return subModelo_Cat;
      }      
    }

    public void Excluir(int codigo)
    {
      using(SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"DELETE FROM SUBCATEGORIA 
                                      WHERE SCAT_COD = @CODIGO";
        command.Parameters.AddWithValue("@CODIGO", codigo);

        conexao.Conectar();
        command.ExecuteNonQuery();
        conexao.Desconectar();
      }      
    }

    public void Incluir(ModeloSubCategoria modelo)
    {
      using(SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"INSERT INTO SUBCATEGORIA(CAT_COD, SCAT_NOME) 
                                                 VALUES (@CODIGO_CATEGORIA, @NOME); SELECT @@IDENTITY;";

        command.Parameters.AddWithValue("@CODIGO_CATEGORIA", modelo.CatCod);
        command.Parameters.AddWithValue("@NOME", modelo.SCatNome);

        conexao.Conectar();
        modelo.SCatCod = Convert.ToInt32(command.ExecuteScalar());
        conexao.Desconectar();
      }      
    }

    public DataTable Localizar(string nome)
    {
      using(DataTable tabela = new DataTable())
      {
        string sql = string.Format(@"SELECT SUBCATEGORIA.SCAT_COD,
                                            SUBCATEGORIA.SCAT_NOME,
	                                          SUBCATEGORIA.CAT_COD,
	                                          CATEGORIA.CAT_NOME
	                                     FROM SUBCATEGORIA (NOLOCK)
                                 INNER JOIN CATEGORIA (NOLOCK)
                                         ON SUBCATEGORIA.CAT_COD = CATEGORIA.CAT_COD
                                      WHERE SUBCATEGORIA.SCAT_NOME LIKE '{0}%'", nome);

        SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao.StringConexao);
        adapter.Fill(tabela);

        return tabela;
      }      
    }       
  }
}
