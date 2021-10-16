using BLL;
using DAL;
using ModeloDB;
using System;
using System.Windows.Forms;
using static Consts.Constantes;

namespace GUI
{
  public partial class frmCadastroSubCategoria : GUI.frmModeloDeFormularioDeCadastro
  {
    #region Constantes
    private const string Inserir = "Inserir";
    private const string Alterar = "Alterar";
    private const string Excluir = "Excluir";

    #endregion

    #region Propriedades
    public DALConexao Conexao
    {
      get
      {
        if (_conn == null)
          _conn = new DALConexao(DadosDaConexao.StringDeConexao);
        return _conn;
      }
    }
    private DALConexao _conn = null;

    public BLLSubCategoria QueryDB
    {
      get
      {
        if (_queryDB == null)
          _queryDB = new BLLSubCategoria(Conexao);
        return _queryDB;
      }
    }
    private BLLSubCategoria _queryDB = null;

    #endregion

    public frmCadastroSubCategoria()
    {
      InitializeComponent();
    }

    private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
    {
      this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
      ConfiguraComboBoxCategoria();
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
          QueryDB.ExcluirSubCategoria(Convert.ToInt32(txtCodigoSubCategoria.Text));

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

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      try
      {
        ModeloSubCategoria modeloSubCategoria = new ModeloSubCategoria();

        modeloSubCategoria.SCatNome = txtNomeSubCategoria.Text;
        modeloSubCategoria.CatCod = Convert.ToInt32(cbCategoria.SelectedValue);       

        if (this.operacao == Inserir)
        {
          QueryDB.IncluirSubCategoria(modeloSubCategoria, operacao);
          MessageBox.Show("Cadastro efetuado com sucesso!! \nCódigo: " + modeloSubCategoria.SCatCod.ToString());
        }
        else
        {
          modeloSubCategoria.SCatCod = Convert.ToInt32(txtCodigoSubCategoria.Text);

          QueryDB.AlterarSubCategoria(modeloSubCategoria, operacao);
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

    private void btnLocalizar_Click(object sender, EventArgs e)
    {
      using(frmPesquisarSubCategoria pesquisar = new frmPesquisarSubCategoria())
      {
        pesquisar.ShowDialog();

        if (pesquisar.codigo != 0)
        {
          ModeloSubCategoria modelo = QueryDB.CarregaSubCategoria(Convert.ToInt32(pesquisar.codigo));

          txtCodigoSubCategoria.Text = Convert.ToString(modelo.SCatCod);
          txtNomeSubCategoria.Text = modelo.SCatNome;
          cbCategoria.SelectedValue = modelo.CatCod;

          this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Alterar_Excluir_Cancelar));
        }
        else
        {
          this.LimparDadosDaTela();
          this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
        }
      }      
    }

    #region Metodos Auxiliares

    private void LimparDadosDaTela()
    {
      txtCodigoSubCategoria.Clear();
      txtNomeSubCategoria.Clear();
    }
    private void ConfiguraComboBoxCategoria()
    {
      cbCategoria.DataSource = QueryDB.CarregarCategoria();
      cbCategoria.DisplayMember = "CAT_NOME";
      cbCategoria.ValueMember = "CAT_COD";
    }
    #endregion

    private void btnNovaCategoria_Click(object sender, EventArgs e)
    {
      using (frmCadastroCategoria frmCategoria = new frmCadastroCategoria())
      {
        frmCategoria.ShowDialog();
        this.ConfiguraComboBoxCategoria();
      }
    }
  }
}
