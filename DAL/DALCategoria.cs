using ModeloDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public class DALCategoria : ICategoria 
  {
    private DALConexao conexao;

    public DALCategoria(DALConexao conn)
    {
      this.conexao = conn;
    } 

    public void Incluir(ModeloCategoria modelo)
    {
      using(SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = "INSERT INTO CATEGORIA(CAT_NOME) " +
          "                                  VALUES (@NOME); SELECT @@IDENTITY;";
        command.Parameters.AddWithValue("@NOME", modelo.CatNome);

        conexao.Conectar();
        modelo.CatCod = Convert.ToInt32(command.ExecuteScalar());
        conexao.Desconectar();
      }      
    }

    public void Alterar(ModeloCategoria modelo)
    {
      using(SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = "UPDATE CATEGORIA SET CAT_NOME = @NOME " +
          "                               WHERE CAT_COD = @CODIGO";

        command.Parameters.AddWithValue("@NOME", modelo.CatNome);
        command.Parameters.AddWithValue("@CODIGO", modelo.CatCod);

        conexao.Conectar();
        command.ExecuteNonQuery();
        conexao.Desconectar();
      }      
    }

    public void Excluir(int codigo)
    {
      using(SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"DELETE FROM CATEGORIA 
                                      WHERE CAT_COD = @CODIGO";

        command.Parameters.AddWithValue("@CODIGO", codigo);

        conexao.Conectar();
        command.ExecuteNonQuery();
        conexao.Desconectar();
      }      
    }

    public DataTable Localizar (string nome)
    {
      using(DataTable tabela = new DataTable())
      {
        string sql = string.Format(@"SELECT CATEGORIA.CAT_COD,
                                            CATEGORIA.CAT_NOME
                                       FROM CATEGORIA 
                                      WHERE CATEGORIA.CAT_NOME LIKE '{0}%'", nome);

        SqlDataAdapter Adapter = new SqlDataAdapter(sql, conexao.StringConexao);
        Adapter.Fill(tabela);

        return tabela;
      }           
    }

    public ModeloCategoria CarregaCategoria(int codigo)
    {
      ModeloCategoria modelo_Cat = new ModeloCategoria();
      
      using(SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"SELECT CAT_COD,
                                       CAT_NOME
                                  FROM CATEGORIA
                                 WHERE CAT_COD = @CODIGO";

        command.Parameters.AddWithValue("@CODIGO", codigo);

        conexao.Conectar();
        SqlDataReader registro = command.ExecuteReader();

        if (registro.HasRows)
        {
          registro.Read();

          modelo_Cat.CatCod = Convert.ToInt32(registro["CAT_COD"]);
          modelo_Cat.CatNome = Convert.ToString(registro["CAT_NOME"]);
        }

        conexao.Desconectar();

        return modelo_Cat;
      }
    }





























  }
}
