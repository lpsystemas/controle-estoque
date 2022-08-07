using DAL;
using GUI.Properties;
using System;
using System.Windows.Forms;
using static ConstsEnumerados.Constantes;
using static ConstsEnumerados.Enumerados;
using Ferramentas;
using ModeloDB.Cliente;
using BLL.Cliente;

namespace GUI
{
    public partial class frmCadastroCliente : GUI.frmModeloDeFormularioDeCadastro
    {
        public DALConexao Conexao
        {
            get
            {
                if (_conexao == null)
                    _conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                return _conexao;
            }
        }
        private DALConexao _conexao = null;

        public BLLCliente QueryDB
        {
            get
            {
                if (_queryDB == null)
                    _queryDB = new BLLCliente(Conexao);
                return _queryDB;
            }
        }
        private BLLCliente _queryDB = null;

        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = Inserir;

            this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Salvar_Cancelar));
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            using (frmPesquisarCliente pesquisar = new frmPesquisarCliente())
            {
                pesquisar.ShowDialog();

                if (pesquisar.codigo != 0)
                {
                    ModeloCliente modeloCliente = QueryDB.CarregaCliente(pesquisar.codigo);

                    txtCodCliente.Text = Convert.ToString(modeloCliente.CliCod);
                    txtNomeCliente.Text = modeloCliente.CliNome;

                    if (modeloCliente.CliTipo == Convert.ToInt32(TipoClienteFornecedor.Pessoa_Fisica))
                        rbTipoFisica.Checked = true;
                    else
                        rbTipoJuridica.Checked = true;

                    txtRazaoSocial.Text = modeloCliente.CliRazaoSocial;
                    txtCpfCnpj.Text = modeloCliente.CliCpfCnpj;
                    txtRgInscEstadual.Text = modeloCliente.CliRgInscricaoEstadual;
                    txtCEP.Text = modeloCliente.CliCep;
                    txtEndereco.Text = modeloCliente.CliEndereco;
                    txtNumero.Text = modeloCliente.CliEndNumero;
                    txtBairro.Text = modeloCliente.CliBairro;
                    txtCidade.Text = modeloCliente.CliCidade;
                    txtEstadoUF.Text = modeloCliente.CliEstado;
                    txtTelefone.Text = modeloCliente.CliTelefone;
                    txtCelular.Text = modeloCliente.CliCelular;
                    txtEmail.Text = modeloCliente.CliEmail;

                    this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Alterar_Excluir_Cancelar));
                }
                else
                {
                    this.LimparDadosDaTela();
                    this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = Alterar;

            this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Salvar_Cancelar));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult exclusao = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                if (exclusao.ToString() == "Yes")
                {
                    QueryDB.ExcluirCliente(Convert.ToInt32(txtCodCliente.Text));

                    LimparDadosDaTela();
                    AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
                }
            }
            catch
            {
                MessageBox.Show("Impossivél excluir o registro. \nO registro está sendo utilizado em outro local.");
                this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Alterar_Excluir_Cancelar));
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCliente modeloCliente = new ModeloCliente();

                modeloCliente.CliNome = txtNomeCliente.Text;
                modeloCliente.CliRazaoSocial = txtRazaoSocial.Text;
                modeloCliente.CliCpfCnpj = txtCpfCnpj.Text;
                modeloCliente.CliRgInscricaoEstadual = txtRgInscEstadual.Text;
                modeloCliente.CliCep = txtCEP.Text;
                modeloCliente.CliEndereco = txtEndereco.Text;
                modeloCliente.CliEndNumero = txtNumero.Text;
                modeloCliente.CliBairro = txtBairro.Text;
                modeloCliente.CliCidade = txtCidade.Text;
                modeloCliente.CliEstado = txtEstadoUF.Text;
                modeloCliente.CliTelefone = txtTelefone.Text;
                modeloCliente.CliCelular = txtCelular.Text;
                modeloCliente.CliEmail = txtEmail.Text;

                if (rbTipoFisica.Checked)
                    modeloCliente.CliTipo = Convert.ToInt32(TipoClienteFornecedor.Pessoa_Fisica);
                else
                    modeloCliente.CliTipo = Convert.ToInt32(TipoClienteFornecedor.Pessoa_Juridica);


                if (this.operacao == Inserir)
                {
                    QueryDB.IncluirCliente(modeloCliente, this.operacao);
                    MessageBox.Show("Cadastro efetuado com sucesso!! \nCódigo: " + modeloCliente.CliCod.ToString());
                }
                else
                {
                    modeloCliente.CliCod = Convert.ToInt32(txtCodCliente.Text);

                    QueryDB.AlterarCliente(modeloCliente, this.operacao);
                    MessageBox.Show("Cadastro alterado com sucesso!!");
                }

                this.LimparDadosDaTela();
                this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimparDadosDaTela();
            lblMsgConsistCpfCpnj.Visible = false;

            this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
            ConfiguraVisibilidadeCamposNaTela();
        }

        private void rbTipoFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTipoFisica.Checked != true)
            {
                lblRazaoSocial.Visible = true;
                txtRazaoSocial.Visible = true;

                lblCpfCnpj.Text = Resources.SCaptionCPNJ;
                lblRgInscEstadual.Text = Resources.SCaptionInscEstadual;
            }
            else
            {
                lblRazaoSocial.Visible = false;
                txtRazaoSocial.Visible = false;

                lblCpfCnpj.Text = Resources.SCaptionCPF;
                lblRgInscEstadual.Text = Resources.SCaptionRG;

            }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (BuscaEndereco.verificaCEP(txtCEP.Text))
            {
                txtEndereco.Text = BuscaEndereco.endereco;
                txtBairro.Text = BuscaEndereco.bairro;
                txtCidade.Text = BuscaEndereco.cidade;
                txtEstadoUF.Text = BuscaEndereco.estado;
            }
            else
            {
                MessageBox.Show("CEP não encontrado");
                txtCEP.Focus();
            }

        }

        #region Métodos Auxiliares

        private void ConfiguraVisibilidadeCamposNaTela()
        {
            txtCodCliente.Enabled = false;

            lblRazaoSocial.Visible = false;
            txtRazaoSocial.Visible = false;

            lblMsgConsistCpfCpnj.Visible = false;
        }
        public void LimparDadosDaTela()
        {
            txtCodCliente.Clear();
            txtNomeCliente.Clear();
            txtRazaoSocial.Clear();
            txtCpfCnpj.Clear();
            txtRgInscEstadual.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstadoUF.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            rbTipoFisica.Checked = true;
        }

        #endregion

        private void txtCpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                CampoParaFormatacao campo = CampoParaFormatacao.CPF;

                if (!rbTipoFisica.Checked)
                    campo = CampoParaFormatacao.CNPJ;

                FormataMascaraDeCampos.FormataMascaraCampoCpfCnpj(campo, txtCpfCnpj);
            }

            if (txtCpfCnpj.Text == string.Empty)
                lblMsgConsistCpfCpnj.Visible = false;
        }

        private void txtCpfCnpj_Leave(object sender, EventArgs e)
        {
            if (rbTipoFisica.Checked == true)
                lblMsgConsistCpfCpnj.Visible = true ? !Validacao.ValidaCpf(txtCpfCnpj.Text) : lblMsgConsistCpfCpnj.Visible = false;

            if (rbTipoJuridica.Checked == true)
                lblMsgConsistCpfCpnj.Visible = true ? !Validacao.ValidaCnpj(txtCpfCnpj.Text) : lblMsgConsistCpfCpnj.Visible = false;

        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                CampoParaFormatacao campo = CampoParaFormatacao.CEP;
                FormataMascaraDeCampos.FormataMascaraCEP(campo, txtCEP);
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)//compara se é numero e habilita o backspace//8 valor da backspace na tabela ask
                e.Handled = true;//volta verdadeiro e não faz nada ou seja não é numero
            if (e.KeyChar != (char)8)
            {
                CampoParaFormatacao campo = CampoParaFormatacao.TELEFONE;
                FormataMascaraDeCampos.FormataMascaraTelefone(campo, txtTelefone);
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)//compara se é numero e habilita o backspace//8 valor da backspace na tabela ask
                e.Handled = true;//volta verdadeiro e não faz nada ou seja não é numero
            if (e.KeyChar != (char)8)
            {
                CampoParaFormatacao campo = CampoParaFormatacao.CELULAR;
                FormataMascaraDeCampos.FormataMascaraTelefone(campo, txtCelular);
            }
        }
    }
}
