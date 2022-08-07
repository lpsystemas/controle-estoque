using System;
using static ConstsEnumerados.Enumerados;

namespace ModeloDB.Cliente
{
    public class ModeloCliente
    {
        #region Propriedades

        //Codigo do Cliente
        private int cli_cod;
        public int CliCod
        {
            get { return this.cli_cod; }
            set { this.cli_cod = value; }
        }

        //Nome do Cliente
        private string cli_nome;
        public string CliNome
        {
            get { return this.cli_nome; }
            set { this.cli_nome = value; }
        }

        // CPF/CNPJ do Cliente
        private string cli_CpfCnpj;
        public string CliCpfCnpj
        {
            get { return this.cli_CpfCnpj; }
            set { this.cli_CpfCnpj = value; }
        }

        // RG/Inscrição Estadual do Cliente
        private string cli_RgInscricaoEstadual;
        public string CliRgInscricaoEstadual
        {
            get { return this.cli_RgInscricaoEstadual; }
            set { this.cli_RgInscricaoEstadual = value; }
        }

        //Razão Social do Cliente
        private string cli_RazaoSocial;
        public string CliRazaoSocial
        {
            get { return this.cli_RazaoSocial; }
            set { this.cli_RazaoSocial = value; }
        }

        //Tipo do Cliente
        private int cli_tipo;
        public int CliTipo
        {
            get { return this.cli_tipo; }
            set { this.cli_tipo = value; }
        }

        //CEP do Cliente
        private string cli_cep;
        public string CliCep
        {
            get { return this.cli_cep; }
            set { this.cli_cep = value; }
        }

        //Endereço do Cliente
        private string cli_endereco;
        public string CliEndereco
        {
            get { return this.cli_endereco; }
            set { this.cli_endereco = value; }
        }

        //Bairro do Cliente
        private string cli_bairro;
        public string CliBairro
        {
            get { return this.cli_bairro; }
            set { this.cli_bairro = value; }
        }

        //Numero do endenreço do Cliente
        private string cli_endNumero;
        public string CliEndNumero
        {
            get { return this.cli_endNumero; }
            set { this.cli_endNumero = value; }
        }

        //Cidade do Cliente
        private string cli_cidade;
        public string CliCidade
        {
            get { return this.cli_cidade; }
            set { this.cli_cidade = value; }
        }

        //Estado do Cliente
        private string cli_estado;
        public string CliEstado
        {
            get { return this.cli_estado; }
            set { this.cli_estado = value; }
        }

        //E-mail do Cliente
        private string cli_email;
        public string CliEmail
        {
            get { return this.cli_email; }
            set { this.cli_email = value; }
        }

        //Telefone do Cliente
        private string cli_telefone;
        public string CliTelefone
        {
            get { return this.cli_telefone; }
            set { this.cli_telefone = value; }
        }

        //Celular do Cliente
        private string cli_celular;
        public string CliCelular
        {
            get { return this.cli_celular; }
            set { this.cli_celular = value; }
        }

        #endregion

        public ModeloCliente()
        {
            this.CliCod = 0;
            this.CliNome = string.Empty;
            this.CliCpfCnpj = string.Empty;
            this.CliRgInscricaoEstadual = string.Empty;
            this.CliRazaoSocial = string.Empty;
            this.CliTipo = Convert.ToInt32(TipoClienteFornecedor.Pessoa_Fisica);
            this.CliCep = string.Empty;
            this.CliEndereco = string.Empty;
            this.CliBairro = string.Empty;
            this.CliEndNumero = string.Empty;
            this.CliCidade = string.Empty;
            this.CliEstado = string.Empty;
            this.CliTelefone = string.Empty;
            this.CliCelular = string.Empty;
            this.CliEmail = string.Empty;
        }

        public ModeloCliente(
            int cod,
            string nome,
            string cpfCnpj,
            string rgIe,
            string razaoSocial,
            int tipo,
            string cep,
            string endereco,
            string bairro,
            string numero,
            string cidade,
            string estado,
            string telefone,
            string celular,
            string email)
        {
            this.CliCod = cod;
            this.CliNome = nome;
            this.CliCpfCnpj = cpfCnpj;
            this.CliRgInscricaoEstadual = rgIe;
            this.CliRazaoSocial = razaoSocial;
            this.CliTipo = tipo;
            this.CliCep = cep;
            this.CliEndereco = endereco;
            this.CliBairro = bairro;
            this.CliEndNumero = numero;
            this.CliCidade = cidade;
            this.CliEstado = estado;
            this.CliTelefone = telefone;
            this.CliCelular = celular;
            this.CliEmail = email;
        }
    }
}
