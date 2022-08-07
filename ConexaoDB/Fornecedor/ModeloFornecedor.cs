namespace ModeloDB.Fornecedor
{
    public class ModeloFornecedor
  {
    #region Propriedades

    //Codigo do Fornecedor
    private int for_cod;
    public int ForCod
    {
      get { return this.for_cod; }
      set { this.for_cod = value; }
    }

    //Nome do Fornecedor
    private string for_nome;
    public string ForNome
    {
      get { return this.for_nome; }
      set { this.for_nome = value; }
    }

    //CNPJ do Fornecedor
    private string for_cnpj;
    public string ForCnpj
    {
      get { return this.for_cnpj; }
      set { this.for_cnpj = value; }
    }

    //Inscrição Estadual do Fornecedor
    private string for_inscricaoEstadual;
    public string ForInscricaoEstadual
    {
      get { return this.for_inscricaoEstadual; }
      set { this.for_inscricaoEstadual = value; }
    }

    //Razão Social do Fornecedor
    private string for_razaoSocial;
    public string ForRazaoSocial
    {
      get { return this.for_razaoSocial; }
      set { this.for_razaoSocial = value; }
    }   

    //CEP do Fornecedor
    private string for_cep;
    public string ForCep
    {
      get { return this.for_cep; }
      set { this.for_cep = value; }
    }

    //Endereço do Fornecedor
    private string for_endereco;
    public string ForEndereco
    {
      get { return this.for_endereco; }
      set { this.for_endereco = value; }
    }

    //Bairro do Fornecedor
    private string for_bairro;
    public string ForBairro
    {
      get { return this.for_bairro; }
      set { this.for_bairro = value; }
    }

    //Numero do endenreço do Fornecedor
    private string for_endNumero;
    public string ForEndNumero
    {
      get { return this.for_endNumero; }
      set { this.for_endNumero = value; }
    }

    //Cidade do Fornecedor
    private string for_cidade;
    public string ForCidade
    {
      get { return this.for_cidade; }
      set { this.for_cidade = value; }
    }

    //Estado do Fornecedor
    private string for_estado;
    public string ForEstado
    {
      get { return this.for_estado; }
      set { this.for_estado = value; }
    }

    //E-mail do Fornecedor
    private string for_email;
    public string ForEmail
    {
      get { return this.for_email; }
      set { this.for_email = value; }
    }

    //Telefone do Fornecedor
    private string for_telefone;
    public string ForTelefone
    {
      get { return this.for_telefone; }
      set { this.for_telefone = value; }
    }

    //Celular do Fornecedor
    private string for_celular;
    public string ForCelular
    {
      get { return this.for_celular; }
      set { this.for_celular = value; }
    }

    #endregion

    public ModeloFornecedor()
    {
      this.ForCod = 0;
      this.ForNome = string.Empty;
      this.ForCnpj = string.Empty;
      this.ForInscricaoEstadual = string.Empty;
      this.ForRazaoSocial = string.Empty;      
      this.ForCep = string.Empty;
      this.ForEndereco = string.Empty;
      this.ForBairro = string.Empty;
      this.ForEndNumero = string.Empty;
      this.ForCidade = string.Empty;
      this.ForEstado = string.Empty;
      this.ForTelefone = string.Empty;
      this.ForCelular = string.Empty;
      this.ForEmail = string.Empty;
    }

    public ModeloFornecedor(int cod, string nome, string cnpj, string iE, string razaoSocial, string cep, string endereco, 
                            string bairro, string numero, string cidade, string estado, string telefone, string celular, string email)
    {
      this.ForCod = cod;
      this.ForNome = nome;
      this.ForCnpj = cnpj;
      this.ForInscricaoEstadual = iE;
      this.ForRazaoSocial = razaoSocial;      
      this.ForCep = cep;
      this.ForEndereco = endereco;
      this.ForBairro = bairro;
      this.ForEndNumero = numero;
      this.ForCidade = cidade;
      this.ForEstado = estado;
      this.ForTelefone = telefone;
      this.ForCelular = celular;
      this.ForEmail = email;
    }
  }
}
