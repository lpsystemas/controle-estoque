using BLL;
using DAL;
using GUI.Properties;
using System;
using static Consts.Constantes;

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

    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
      this.operacao = Alterar;

      this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Salvar_Cancelar));
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {

    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {

    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.LimparDadosDaTela();
      this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
    }

    private void frmCadastroCliente_Load(object sender, EventArgs e)
    {
      this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
      ConfiguraVisibilidade();
    }

    private void rbTipoFisica_CheckedChanged(object sender, EventArgs e)
    {
      if(rbTipoFisica.Checked != true)
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

    private void ConfiguraVisibilidade()
    {
      lblRazaoSocial.Visible = false;
      txtRazaoSocial.Visible = false;
    }
  }
}
