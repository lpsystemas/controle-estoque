using System;
using ModeloDB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
  public class DALTipoPagamento : ITipoPagamento
  {
    private DALConexao conexao;

    public DALTipoPagamento(DALConexao conn)
    {
      this.conexao = conn;
    }

    public void Incluir(ModeloTipoPagamento modelo)
    {
      using (SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = "INSERT INTO TIPOPAGAMENTO(TPA_NOME) " +
          "                         VALUES (@NOME); SELECT @@IDENTITY;";
        command.Parameters.AddWithValue("@NOME", modelo.TPagtoNome);

        conexao.Conectar();
        modelo.TPagtoCod = Convert.ToInt32(command.ExecuteScalar());
        conexao.Desconectar();
      }
    }

    public void Alterar(ModeloTipoPagamento modelo)
    {
      using (SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = "UPDATE TIPOPAGAMENTO SET TPA_NOME = @NOME " +
          "                                   WHERE TPA_COD = @CODIGO";

        command.Parameters.AddWithValue("@NOME", modelo.TPagtoNome);
        command.Parameters.AddWithValue("@CODIGO", modelo.TPagtoCod);

        conexao.Conectar();
        command.ExecuteNonQuery();
        conexao.Desconectar();
      }
    }

    public void Excluir(int codigo)
    {
      using (SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"DELETE FROM TIPOPAGAMENTO 
                                      WHERE TPA_COD = @CODIGO";

        command.Parameters.AddWithValue("@CODIGO", codigo);

        conexao.Conectar();
        command.ExecuteNonQuery();
        conexao.Desconectar();
      }
    }

    public DataTable Localizar(string nome)
    {
      using (DataTable tabela = new DataTable())
      {
        string sql = string.Format(@"SELECT TIPOPAGAMENTO.TPA_COD,
                                            TIPOPAGAMENTO.TPA_NOME
                                       FROM TIPOPAGAMENTO 
                                      WHERE TIPOPAGAMENTO.TPA_NOME LIKE '{0}%'", nome);

        SqlDataAdapter Adapter = new SqlDataAdapter(sql, conexao.StringConexao);
        Adapter.Fill(tabela);

        return tabela;
      }
    }

    public ModeloTipoPagamento CarregaTipoDePagamento(int codigo)
    {
      ModeloTipoPagamento modelo_Tpagto = new ModeloTipoPagamento();

      using (SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"SELECT TIPOPAGAMENTO.TPA_COD,
                                       TIPOPAGAMENTO.TPA_NOME
                                  FROM TIPOPAGAMENTO
                                 WHERE TIPOPAGAMENTO.TPA_COD = @CODIGO";

        command.Parameters.AddWithValue("@CODIGO", codigo);

        conexao.Conectar();
        SqlDataReader registro = command.ExecuteReader();

        if (registro.HasRows)
        {
          registro.Read();

          modelo_Tpagto.TPagtoCod = Convert.ToInt32(registro["TPA_COD"]);
          modelo_Tpagto.TPagtoNome = Convert.ToString(registro["TPA_NOME"]);
        }

        conexao.Desconectar();

        return modelo_Tpagto;
      }
    }

  }
}
