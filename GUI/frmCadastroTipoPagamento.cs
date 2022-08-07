using BLL.TipoPagamento;
using DAL;
using ModeloDB.TipoPagamento;
using System;
using System.Windows.Forms;
using static ConstsEnumerados.Constantes;
using static ConstsEnumerados.Enumerados;

namespace GUI
{
    public partial class frmCadastroTipoPagamento : frmModeloDeFormularioDeCadastro
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

        public BLLTipoPagamento QueryDB
        {
            get
            {
                if (_queryDB == null)
                    _queryDB = new BLLTipoPagamento(Conexao);
                return _queryDB;
            }
        }
        private BLLTipoPagamento _queryDB = null;

        public frmCadastroTipoPagamento()
        {
            InitializeComponent();
        }

        public void LimparDadosDaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastroTipoPagamento_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
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
                    QueryDB.ExcluirTipoDePagamento(Convert.ToInt32(txtCodigo.Text));

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimparDadosDaTela();
            this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            using (frmPesquisarTipoDePagamento pesquisar = new frmPesquisarTipoDePagamento())
            {
                pesquisar.ShowDialog();

                if (pesquisar.codigo != 0)
                {
                    ModeloTipoPagamento modeloTipoDePagamento = QueryDB.CarregaTipoDePagamento(pesquisar.codigo);

                    txtCodigo.Text = Convert.ToString(modeloTipoDePagamento.TPagtoCod);
                    txtNome.Text = modeloTipoDePagamento.TPagtoNome;

                    this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Alterar_Excluir_Cancelar));
                }
                else
                {
                    this.LimparDadosDaTela();
                    this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloTipoPagamento modeloTipoPagamento = new ModeloTipoPagamento();

                modeloTipoPagamento.TPagtoNome = txtNome.Text;

                if (this.operacao == Inserir)
                {
                    QueryDB.IncluirTipoDePagamento(modeloTipoPagamento, operacao);
                    MessageBox.Show("Cadastro efetuado com sucesso!! \nCódigo: " + modeloTipoPagamento.TPagtoCod.ToString());
                }
                else
                {
                    modeloTipoPagamento.TPagtoCod = Convert.ToInt32(txtCodigo.Text);

                    QueryDB.AlterarTipoDePagamento(modeloTipoPagamento, operacao);
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
    }
}
