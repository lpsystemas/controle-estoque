using ModeloDB.Fornecedor;
using System;
using System.Data;
using System.Data.SqlClient;
using static ConstsEnumerados.Enumerados;


namespace DAL
{
  public class DALFornecedor : IFornecedor
  {
    private readonly DALConexao conexao;

    public DALFornecedor(DALConexao conexao)
    {
      this.conexao = conexao;
    }
    public void Alterar(ModeloFornecedor modelo)
    {
      using (SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"UPDATE FORNECEDOR SET FOR_NOME = @NOME,
                                                      FOR_CNPJ = @CNPJ,
                                                      FOR_IE = @IE,
                                                      FOR_RSOCIAL = @RSOCIAL,
                                                      FOR_CEP = @CEP,
                                                      FOR_ENDERECO = @ENDERECO,
                                                      FOR_BAIRRO = @BAIRRO,
                                                      FOR_FONE = @FONE,
                                                      FOR_CEL = @CEL,
                                                      FOR_EMAIL = @EMAIL,
                                                      FOR_ENDNUMERO = @ENDNUMERO,
                                                      FOR_CIDADE = @CIDADE,
                                                      FOR_ESTADO = @ESTADO 
                                                WHERE FOR_COD = @CODIGO";

        command.Parameters.AddWithValue("@CODIGO", modelo.ForCod);
        command.Parameters.AddWithValue("@NOME", modelo.ForNome);
        command.Parameters.AddWithValue("@CNPJ", modelo.ForCnpj);
        command.Parameters.AddWithValue("@IE", modelo.ForInscricaoEstadual);
        command.Parameters.AddWithValue("@RSOCIAL", modelo.ForRazaoSocial);
        command.Parameters.AddWithValue("@CEP", modelo.ForCep);
        command.Parameters.AddWithValue("@ENDERECO", modelo.ForEndereco);
        command.Parameters.AddWithValue("@BAIRRO", modelo.ForBairro);
        command.Parameters.AddWithValue("@FONE", modelo.ForTelefone);
        command.Parameters.AddWithValue("@CEL", modelo.ForCelular);
        command.Parameters.AddWithValue("@EMAIL", modelo.ForEmail);
        command.Parameters.AddWithValue("@ENDNUMERO", modelo.ForEndNumero);
        command.Parameters.AddWithValue("@CIDADE", modelo.ForCidade);
        command.Parameters.AddWithValue("@ESTADO", modelo.ForEstado);

        conexao.Conectar();
        command.ExecuteNonQuery();
        conexao.Desconectar();
      }
    }
    public ModeloFornecedor CarregaFornecedorPorCodigo(int codigo)
    {
      ModeloFornecedor modelo_Fornecedor = new ModeloFornecedor();

      using (SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"SELECT FORNECEDOR.FOR_COD,
                                       FORNECEDOR.FOR_NOME,
                                       FORNECEDOR.FOR_CNPJ,
                                       FORNECEDOR.FOR_IE,
                                       FORNECEDOR.FOR_RSOCIAL,
                                       FORNECEDOR.FOR_CEP,
                                       FORNECEDOR.FOR_ENDERECO,
                                       FORNECEDOR.FOR_BAIRRO,
                                       FORNECEDOR.FOR_FONE,
                                       FORNECEDOR.FOR_CEL,
                                       FORNECEDOR.FOR_EMAIL,
                                       FORNECEDOR.FOR_ENDNUMERO,
                                       FORNECEDOR.FOR_CIDADE,
                                       FORNECEDOR.FOR_ESTADO
	                                     FROM FORNECEDOR (NOLOCK)
                                 WHERE FORNECEDOR.FOR_COD = @CODIGO";

        command.Parameters.AddWithValue("@CODIGO", codigo);

        conexao.Conectar();
        SqlDataReader registro = command.ExecuteReader();

        if (registro.HasRows)
        {
          registro.Read();

          modelo_Fornecedor.ForCod = Convert.ToInt32(registro["FOR_COD"]);
          modelo_Fornecedor.ForNome = Convert.ToString(registro["FOR_NOME"]);
          modelo_Fornecedor.ForCnpj = Convert.ToString(registro["FOR_CNPJ"]);
          modelo_Fornecedor.ForInscricaoEstadual = Convert.ToString(registro["FOR_IE"]);
          modelo_Fornecedor.ForRazaoSocial = Convert.ToString(registro["FOR_RSOCIAL"]);
          modelo_Fornecedor.ForCep = Convert.ToString(registro["FOR_CEP"]);
          modelo_Fornecedor.ForEndereco = Convert.ToString(registro["FOR_ENDERECO"]);
          modelo_Fornecedor.ForBairro = Convert.ToString(registro["FOR_BAIRRO"]);
          modelo_Fornecedor.ForTelefone = Convert.ToString(registro["FOR_FONE"]);
          modelo_Fornecedor.ForCelular = Convert.ToString(registro["FOR_CEL"]);
          modelo_Fornecedor.ForEmail = Convert.ToString(registro["FOR_EMAIL"]);
          modelo_Fornecedor.ForEndNumero = Convert.ToString(registro["FOR_ENDNUMERO"]);
          modelo_Fornecedor.ForCidade = Convert.ToString(registro["FOR_CIDADE"]);
          modelo_Fornecedor.ForEstado = Convert.ToString(registro["FOR_ESTADO"]);
        }

        conexao.Desconectar();
        return modelo_Fornecedor;
      }
    }
    public ModeloFornecedor CarregaFornecedorPorCnpj(string cnpj)
    {
      ModeloFornecedor modelo_Fornecedor = new ModeloFornecedor();

      using (SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"SELECT FORNECEDOR.FOR_COD,
                                       FORNECEDOR.FOR_NOME,
                                       FORNECEDOR.FOR_CNPJ,
                                       FORNECEDOR.FOR_IE,
                                       FORNECEDOR.FOR_RSOCIAL,
                                       FORNECEDOR.FOR_TIPO,
                                       FORNECEDOR.FOR_CEP,
                                       FORNECEDOR.FOR_ENDERECO,
                                       FORNECEDOR.FOR_BAIRRO,
                                       FORNECEDOR.FOR_FONE,
                                       FORNECEDOR.FOR_CEL,
                                       FORNECEDOR.FOR_EMAIL,
                                       FORNECEDOR.FOR_ENDNUMERO,
                                       FORNECEDOR.FOR_CIDADE,
                                       FORNECEDOR.FOR_ESTADO
	                                     FROM FORNECEDOR (NOLOCK)
                                 WHERE FORNECEDOR.FOR_CNPJ = @CNPJ";

        command.Parameters.AddWithValue("@CNPJ", cnpj);

        conexao.Conectar();
        SqlDataReader registro = command.ExecuteReader();

        if (registro.HasRows)
        {
          registro.Read();

          modelo_Fornecedor.ForCod = Convert.ToInt32(registro["FOR_COD"]);
          modelo_Fornecedor.ForNome = Convert.ToString(registro["FOR_NOME"]);
          modelo_Fornecedor.ForCnpj = Convert.ToString(registro["FOR_CNPJ"]);
          modelo_Fornecedor.ForInscricaoEstadual = Convert.ToString(registro["FOR_IE"]);
          modelo_Fornecedor.ForRazaoSocial = Convert.ToString(registro["FOR_RSOCIAL"]);
          modelo_Fornecedor.ForCep = Convert.ToString(registro["FOR_CEP"]);
          modelo_Fornecedor.ForEndereco = Convert.ToString(registro["FOR_ENDERECO"]);
          modelo_Fornecedor.ForBairro = Convert.ToString(registro["FOR_BAIRRO"]);
          modelo_Fornecedor.ForTelefone = Convert.ToString(registro["FOR_FONE"]);
          modelo_Fornecedor.ForCelular = Convert.ToString(registro["FOR_CEL"]);
          modelo_Fornecedor.ForEmail = Convert.ToString(registro["FOR_EMAIL"]);
          modelo_Fornecedor.ForEndNumero = Convert.ToString(registro["FOR_ENDNUMERO"]);
          modelo_Fornecedor.ForCidade = Convert.ToString(registro["FOR_CIDADE"]);
          modelo_Fornecedor.ForEstado = Convert.ToString(registro["FOR_ESTADO"]);
        }

        conexao.Desconectar();
        return modelo_Fornecedor;
      }
    }
    public void Excluir(int codigo)
    {
      using (SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"DELETE FROM FORNECEDOR 
                                 WHERE FOR_COD = @CODIGO";

        command.Parameters.AddWithValue("@CODIGO", codigo);

        conexao.Conectar();
        command.ExecuteNonQuery();
        conexao.Desconectar();
      }
    }
    public void Incluir(ModeloFornecedor modelo)
    {
      using (SqlCommand command = new SqlCommand())
      {
        command.Connection = conexao.ObjetoConexao;

        command.CommandText = @"INSERT INTO FORNECEDOR(FOR_NOME, FOR_CNPJ, FOR_IE, FOR_RSOCIAL, FOR_CEP, FOR_ENDERECO, 
                                                       FOR_BAIRRO, FOR_FONE, FOR_CEL, FOR_EMAIL, FOR_ENDNUMERO, FOR_CIDADE, FOR_ESTADO) 
                                             
                                             VALUES(@NOME, @CNPJ, @IE, @RSOCIAL, @CEP, @ENDERECO, @BAIRRO, @FONE, @CEL,
                                                    @EMAIL, @ENDNUMERO, @CIDADE, @ESTADO); SELECT @@IDENTITY;";

        command.Parameters.AddWithValue("@NOME", modelo.ForNome);
        command.Parameters.AddWithValue("@CNPJ", modelo.ForCnpj);
        command.Parameters.AddWithValue("@IE", modelo.ForInscricaoEstadual);
        command.Parameters.AddWithValue("@RSOCIAL", modelo.ForRazaoSocial);
        command.Parameters.AddWithValue("@CEP", modelo.ForCep);
        command.Parameters.AddWithValue("@ENDERECO", modelo.ForEndereco);
        command.Parameters.AddWithValue("@BAIRRO", modelo.ForBairro);
        command.Parameters.AddWithValue("@FONE", modelo.ForTelefone);
        command.Parameters.AddWithValue("@CEL", modelo.ForCelular);
        command.Parameters.AddWithValue("@EMAIL", modelo.ForEmail);
        command.Parameters.AddWithValue("@ENDNUMERO", modelo.ForEndNumero);
        command.Parameters.AddWithValue("@CIDADE", modelo.ForCidade);
        command.Parameters.AddWithValue("@ESTADO", modelo.ForEstado);

        conexao.Conectar();
        modelo.ForCod = Convert.ToInt32(command.ExecuteScalar());
        conexao.Desconectar();
      }
    }
    public DataTable Localizar(int tipoPesquisaFornecedor, string valorPesquisa)
    {
      string filter = string.Empty;

      if (tipoPesquisaFornecedor == Convert.ToInt32(TipoPesquisa.NOME))
        filter = "FORNECEDOR.FOR_NOME LIKE '{0}%'";

      if (tipoPesquisaFornecedor == Convert.ToInt32(TipoPesquisa.CPNJ))
        filter = "FORNECEDOR.FOR_CNPJ = '{0}'";

      using (DataTable tabela = new DataTable())
      {
        string sql = string.Format($@"SELECT FORNECEDOR.FOR_COD,
                                             FORNECEDOR.FOR_NOME,
                                             FORNECEDOR.FOR_CNPJ,
                                             FORNECEDOR.FOR_IE,
                                             FORNECEDOR.FOR_RSOCIAL,
                                             FORNECEDOR.FOR_CEP,
                                             FORNECEDOR.FOR_ENDERECO,
                                             FORNECEDOR.FOR_BAIRRO,
                                             FORNECEDOR.FOR_FONE,
                                             FORNECEDOR.FOR_CEL,
                                             FORNECEDOR.FOR_EMAIL,
                                             FORNECEDOR.FOR_ENDNUMERO,
                                             FORNECEDOR.FOR_CIDADE,
                                             FORNECEDOR.FOR_ESTADO
	                                      FROM FORNECEDOR (NOLOCK)
                                       WHERE {filter}", 
                                             valorPesquisa);       

        SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao.StringConexao);
        adapter.Fill(tabela);

        return tabela;
      }
    }
  }
}
