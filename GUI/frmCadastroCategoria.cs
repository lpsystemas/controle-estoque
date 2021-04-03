using BLL;
using DAL;
using ModeloDB;
using System;
using System.Windows.Forms;
using static Consts.Constantes;

namespace GUI
{
  public partial class frmCadastroCategoria : GUI.frmModeloDeFormularioDeCadastro
  {
    private const string Inserir = "Inserir";
    private const string Alterar = "Alterar";
    private const string Excluir = "Excluir";

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

    public BLLCategoria QueryDB
    {
      get
      {
        if (_queryDB == null)
          _queryDB = new BLLCategoria(Conexao);
        return _queryDB;
      }
    }
    private BLLCategoria _queryDB = null;

    public frmCadastroCategoria()
    {
      InitializeComponent();
    }

    public void LimparDadosDaTela()
    {
      txtCodigo.Clear();
      txtNome.Clear();
    }

    private void frmCadastroCategoria_Load(object sender, EventArgs e)
    {
      this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
    }

    private void btnInserir_Click(object sender, EventArgs e)
    {
      this.operacao = Inserir;

      this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Salvar_Cancelar));
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
        ModeloCategoria modeloCategoria = new ModeloCategoria();
        
        modeloCategoria.CatNome = txtNome.Text;      

        if(this.operacao == Inserir)
        {
          QueryDB.IncluirCategoria(modeloCategoria);
          MessageBox.Show("Cadastro efetuado com sucesso!! \nCódigo: " + modeloCategoria.CatCod.ToString());
        }
        else 
        {
          modeloCategoria.CatCod = Convert.ToInt32(txtCodigo.Text);

          QueryDB.AlterarCategoria(modeloCategoria);
          MessageBox.Show("Cadastro alterado com sucesso!!");
        }

        this.LimparDadosDaTela();
        this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
      }
      catch(Exception Error)
      {
        MessageBox.Show(Error.Message);
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

        if(exclusao.ToString() == "Yes")
        {
          QueryDB.ExcluirCategoria(Convert.ToInt32(txtCodigo.Text));
          
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

    private void btnLocalizar_Click(object sender, EventArgs e)
    {
      using(frmPesquisarCategoria pesquisar = new frmPesquisarCategoria())
      {
        pesquisar.ShowDialog();

        if (pesquisar.codigo != 0)
        {
          ModeloCategoria modeloCategoria = QueryDB.CarregaCategoria(pesquisar.codigo);

          txtCodigo.Text = Convert.ToString(modeloCategoria.CatCod);
          txtNome.Text = modeloCategoria.CatNome;

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
