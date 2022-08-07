using BLL.Fornecedor;
using DAL;
using Ferramentas;
using ModeloDB.Fornecedor;
using System;
using System.Windows.Forms;
using static ConstsEnumerados.Constantes;
using static ConstsEnumerados.Enumerados;

namespace GUI
{
    public partial class frmCadastroFornecedor : GUI.frmModeloDeFormularioDeCadastro
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

        public BLLFornecedor QueryDB
        {
            get
            {
                if (_queryDB == null)
                    _queryDB = new BLLFornecedor(Conexao);
                return _queryDB;
            }
        }
        private BLLFornecedor _queryDB = null;

        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = Inserir;
            this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Salvar_Cancelar));
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
                    QueryDB.ExcluirFornecedor(Convert.ToInt32(txtCodFornecedor.Text));

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

        #region Métodos Auxiliares

        private void ConfiguraVisibilidadeCamposNaTela()
        {
            txtCodFornecedor.Enabled = false;
            lblMsgConsistCpnj.Visible = false;
        }
        public void LimparDadosDaTela()
        {
            txtCodFornecedor.Clear();
            txtNomeFornecedor.Clear();
            txtRazaoSocial.Clear();
            txtCnpj.Clear();
            txtInscEstadual.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstadoUF.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
        }
        #endregion

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloFornecedor modeloFornecedor = new ModeloFornecedor();

                modeloFornecedor.ForNome = txtNomeFornecedor.Text;
                modeloFornecedor.ForRazaoSocial = txtRazaoSocial.Text;
                modeloFornecedor.ForCnpj = txtCnpj.Text;
                modeloFornecedor.ForInscricaoEstadual = txtInscEstadual.Text;
                modeloFornecedor.ForCep = txtCEP.Text;
                modeloFornecedor.ForEndereco = txtEndereco.Text;
                modeloFornecedor.ForEndNumero = txtNumero.Text;
                modeloFornecedor.ForBairro = txtBairro.Text;
                modeloFornecedor.ForCidade = txtCidade.Text;
                modeloFornecedor.ForEstado = txtEstadoUF.Text;
                modeloFornecedor.ForTelefone = txtTelefone.Text;
                modeloFornecedor.ForCelular = txtCelular.Text;
                modeloFornecedor.ForEmail = txtEmail.Text;

                if (this.operacao == Inserir)
                {
                    QueryDB.IncluirFornecedor(modeloFornecedor, this.operacao);
                    MessageBox.Show("Cadastro efetuado com sucesso!! \nCódigo: " + modeloFornecedor.ForCod.ToString());
                }
                else
                {
                    modeloFornecedor.ForCod = Convert.ToInt32(txtCodFornecedor.Text);

                    QueryDB.AlterarFornecedor(modeloFornecedor, this.operacao);
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
            lblMsgConsistCpnj.Visible = false;

            this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
        }

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
            ConfiguraVisibilidadeCamposNaTela();
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

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                CampoParaFormatacao campo = CampoParaFormatacao.CNPJ;
                FormataMascaraDeCampos.FormataMascaraCampoCpfCnpj(campo, txtCnpj);
            }

            if (txtCnpj.Text == string.Empty)
                lblMsgConsistCpnj.Visible = false;
        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            lblMsgConsistCpnj.Visible = true ? !Validacao.ValidaCnpj(txtCnpj.Text) : lblMsgConsistCpnj.Visible = false;
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

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            using (frmPesquisarFornecedor pesquisar = new frmPesquisarFornecedor())
            {
                pesquisar.ShowDialog();

                if (pesquisar.codigo != 0)
                {
                    ModeloFornecedor modeloFornecedor = QueryDB.CarregaFornecedor(pesquisar.codigo);

                    txtCodFornecedor.Text = Convert.ToString(modeloFornecedor.ForCod);
                    txtNomeFornecedor.Text = modeloFornecedor.ForNome;

                    txtRazaoSocial.Text = modeloFornecedor.ForRazaoSocial;
                    txtCnpj.Text = modeloFornecedor.ForCnpj;
                    txtInscEstadual.Text = modeloFornecedor.ForInscricaoEstadual;
                    txtCEP.Text = modeloFornecedor.ForCep;
                    txtEndereco.Text = modeloFornecedor.ForEndereco;
                    txtNumero.Text = modeloFornecedor.ForEndNumero;
                    txtBairro.Text = modeloFornecedor.ForBairro;
                    txtCidade.Text = modeloFornecedor.ForCidade;
                    txtEstadoUF.Text = modeloFornecedor.ForEstado;
                    txtTelefone.Text = modeloFornecedor.ForTelefone;
                    txtCelular.Text = modeloFornecedor.ForCelular;
                    txtEmail.Text = modeloFornecedor.ForEmail;

                    this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Alterar_Excluir_Cancelar));
                }
                else
                {
                    this.LimparDadosDaTela();
                    this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
                }
            }
        }
    }
}
