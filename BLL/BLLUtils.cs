using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
  public class BLLUtils
  {
    public BLLUtils()
    {

    }

    public bool VerificaConexaoComArquivoDeConfigDB()
    {
      using (StreamReader arquivoSalvo = new StreamReader("ConfiguracaoBancoDeDados.txt"))
      {
        DadosDaConexao.servidor = arquivoSalvo.ReadLine();
        DadosDaConexao.banco = arquivoSalvo.ReadLine();
        DadosDaConexao.usuario = arquivoSalvo.ReadLine();
        DadosDaConexao.senha = arquivoSalvo.ReadLine();
      }      

      try
      {
        using (SqlConnection conexao = new SqlConnection())
        {
          conexao.ConnectionString = DadosDaConexao.StringDeConexao;
          conexao.Open();
          conexao.Close();          
        }

        return true;
      }
      catch(SqlException)
      {
        return false;
        throw new WarningException("Conexão com o banco falhou.");        
      }
      

    }
  }
}
