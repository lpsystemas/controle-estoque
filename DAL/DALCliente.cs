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
  class DALCliente : ICliente
  {
    private DALConexao conexao;

    public DALCliente(DALConexao conexao)
    {
      this.conexao = conexao;
    }
    public void Alterar(ModeloCliente modelo)
    {
      using (SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"UPDATE CLIENTE SET CLI_NOME = @NOME,
                                                   CLI_CPFCNPJ = @CPFCNPJ,
                                                   CLI_RGIE = @RGIE,
                                                   CLI_RSOCIAL = @RSOCIAL,
                                                   CLI_TIPO = @TIPO,
                                                   CLI_CEP = @CEP,
                                                   CLI_ENDERECO = @ENDERECO,
                                                   CLI_BAIRRO = @BAIRRO,
                                                   CLI_FONE = @FONE,
                                                   CLI_CEL = @CEL,
                                                   CLI_EMAIL = @EMAIL,
                                                   CLI_ENDNUMERO = @ENDNUMERO,
                                                   CLI_CIDADE = @CIDADE,
                                                   CLI_ESTADO = @ESTADO 
                                             WHERE CLI_COD = @CODIGO";

        command.Parameters.AddWithValue("@CODIGO", modelo.CliCod);
        command.Parameters.AddWithValue("@NOME", modelo.CliNome);
        command.Parameters.AddWithValue("@CPFCNPJ", modelo.CliCpfCnpj);
        command.Parameters.AddWithValue("@RGIE", modelo.CliRgInscricaoEstadual);
        command.Parameters.AddWithValue("@RSOCIAL", modelo.CliRazaoSocial);
        command.Parameters.AddWithValue("@TIPO", modelo.CliTipo);
        command.Parameters.AddWithValue("@CEP", modelo.CliCep);
        command.Parameters.AddWithValue("@ENDERECO", modelo.CliEndereco);
        command.Parameters.AddWithValue("@BAIRRO", modelo.CliBairro);
        command.Parameters.AddWithValue("@FONE", modelo.CliTelefone);
        command.Parameters.AddWithValue("@CEL", modelo.CliCelular);
        command.Parameters.AddWithValue("@EMAIL", modelo.CliEmail);
        command.Parameters.AddWithValue("@ENDNUMERO", modelo.CliEndNumero);
        command.Parameters.AddWithValue("@CIDADE", modelo.CliCidade);
        command.Parameters.AddWithValue("@ESTADO", modelo.CliEstado);

        conexao.Conectar();
        command.ExecuteNonQuery();
        conexao.Desconectar();
      }
    }

    public ModeloCliente CarregaCliente(int codigo)
    {
      ModeloCliente modelo_Cliente = new ModeloCliente();

      using (SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"SELECT CLIENTE.CLI_COD,
                                       CLIENTE.CLI_NOME,
                                       CLIENTE.CLI_CPFCNPJ,
                                       CLIENTE.CLI_RGIE,
                                       CLIENTE.CLI_RSOCIAL,
                                       CLIENTE.CLI_TIPO,
                                       CLIENTE.CLI_CEP,
                                       CLIENTE.CLI_ENDERECO,
                                       CLIENTE.CLI_BAIRRO,
                                       CLIENTE.CLI_FONE,
                                       CLIENTE.CLI_CEL,
                                       CLIENTE.CLI_EMAIL,
                                       CLIENTE.CLI_ENDNUMERO,
                                       CLIENTE.CLI_CIDADE,
                                       CLIENTE.CLI_ESTADO
	                                     FROM CLIENTE (NOLOCK)
                                 WHERE CLIENTE.CLI_COD = @CODIGO";

        command.Parameters.AddWithValue("@CODIGO", codigo);

        conexao.Conectar();
        SqlDataReader registro = command.ExecuteReader();

        if (registro.HasRows)
        {
          registro.Read();

          modelo_Cliente.CliCod = Convert.ToInt32(registro["CLI_COD"]);
          modelo_Cliente.CliNome = Convert.ToString(registro["CLI_NOME"]);
          modelo_Cliente.CliCpfCnpj = Convert.ToString(registro["CLI_CPFCNPJ"]);
          modelo_Cliente.CliRgInscricaoEstadual = Convert.ToString(registro["CLI_RGIE"]);
          modelo_Cliente.CliRazaoSocial = Convert.ToString(registro["CLI_RSOCIAL"]);
          modelo_Cliente.CliTipo = Convert.ToInt32(registro["CLI_TIPO"]);
          modelo_Cliente.CliCep = Convert.ToString(registro["CLI_CEP"]);
          modelo_Cliente.CliEndereco = Convert.ToString(registro["CLI_ENDERECO"]);
          modelo_Cliente.CliBairro = Convert.ToString(registro["CLI_BAIRRO"]);
          modelo_Cliente.CliTelefone = Convert.ToString(registro["CLI_FONE"]);
          modelo_Cliente.CliCelular = Convert.ToString(registro["CLI_CEL"]);
          modelo_Cliente.CliEmail = Convert.ToString(registro["CLI_EMAIL"]);
          modelo_Cliente.CliEndNumero = Convert.ToString(registro["CLI_ENDNUMERO"]);
          modelo_Cliente.CliCidade = Convert.ToString(registro["CLI_CIDADE"]);
          modelo_Cliente.CliEstado = Convert.ToString(registro["CLI_ESTADO"]);


        }

        conexao.Desconectar();
        return modelo_Cliente;
      }
    }

    public void Excluir(int codigo)
    {
      using (SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"DELETE FROM CLIENTE 
                                 WHERE CLI_COD = @CODIGO";
        command.Parameters.AddWithValue("@CODIGO", codigo);

        conexao.Conectar();
        command.ExecuteNonQuery();
        conexao.Desconectar();
      }
    }

    public void Incluir(ModeloCliente modelo)
    {
      using (SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"INSERT INTO CLIENTE(CLI_NOME, CLI_CPFCNPJ, CLI_RGIE, CLI_RSOCIAL, CLI_TIPO, CLI_CEP, CLI_ENDERECO, 
                                                    CLI_BAIRRO, CLI_FONE, CLI_CEL, CLI_EMAIL, CLI_ENDNUMERO, CLI_CIDADE, CLI_ESTADO) 
                                             VALUES(@NOME, @CPFCNPJ, @RGIE, @RSOCIAL, @TIPO, @CEP, @ENDERECO, @BAIRRO, @FONE, @CEL,
                                                    @EMAIL, @ENDNUMERO, @CIDADE, @ESTADO); SELECT @@IDENTITY;";

        command.Parameters.AddWithValue("@NOME", modelo.CliNome);
        command.Parameters.AddWithValue("@CPFCNPJ", modelo.CliCpfCnpj);
        command.Parameters.AddWithValue("@RGIE", modelo.CliRgInscricaoEstadual);
        command.Parameters.AddWithValue("@RSOCIAL", modelo.CliRazaoSocial);
        command.Parameters.AddWithValue("@TIPO", modelo.CliTipo);
        command.Parameters.AddWithValue("@CEP", modelo.CliCep);
        command.Parameters.AddWithValue("@ENDERECO", modelo.CliEndereco);
        command.Parameters.AddWithValue("@BAIRRO", modelo.CliBairro);
        command.Parameters.AddWithValue("@FONE", modelo.CliTelefone);
        command.Parameters.AddWithValue("@CEL", modelo.CliCelular);
        command.Parameters.AddWithValue("@EMAIL", modelo.CliEmail);
        command.Parameters.AddWithValue("@ENDNUMERO", modelo.CliEndNumero);
        command.Parameters.AddWithValue("@CIDADE", modelo.CliCidade);
        command.Parameters.AddWithValue("@ESTADO", modelo.CliEstado);

        conexao.Conectar();
        modelo.CliCod = Convert.ToInt32(command.ExecuteScalar());
        conexao.Desconectar();
      }
    }

    public DataTable Localizar(string nome)
    {
      using (DataTable tabela = new DataTable())
      {
        string sql = string.Format(@"SELECT CLIENTE.CLI_COD,
                                            CLIENTE.CLI_NOME,
                                            CLIENTE.CLI_CPFCNPJ,
                                            CLIENTE.CLI_RGIE,
                                            CLIENTE.CLI_RSOCIAL,
                                            CLIENTE.CLI_TIPO,
                                            CLIENTE.CLI_CEP,
                                            CLIENTE.CLI_ENDERECO,
                                            CLIENTE.CLI_BAIRRO,
                                            CLIENTE.CLI_FONE,
                                            CLIENTE.CLI_CEL,
                                            CLIENTE.CLI_EMAIL,
                                            CLIENTE.CLI_ENDNUMERO,
                                            CLIENTE.CLI_CIDADE,
                                            CLIENTE.CLI_ESTADO
	                                     FROM CLIENTE (NOLOCK)
                                      WHERE CLIENTE.CLI_NOME = LIKE '{0}%'", nome);       

        SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao.StringConexao);
        adapter.Fill(tabela);

        return tabela;
      }
    }
  }
}
