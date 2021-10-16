using BLL;
using DAL;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Consts.Constantes;

namespace GUI
{
  public partial class frmCadastroUnidadeDeMedida : GUI.frmModeloDeFormularioDeCadastro
  {
    private const string Inserir = "Inserir";
    private const string Alterar = "Alterar";
    private const string Excluir = "Excluir";
    public frmCadastroUnidadeDeMedida()
    {
      InitializeComponent();
    }

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

    public BLLUnidadeDeMedida QueryDB
    {
      get
      {
        if (_queryDB == null)
          _queryDB = new BLLUnidadeDeMedida(Conexao);
        return _queryDB;
      }
    }
    private BLLUnidadeDeMedida _queryDB = null;


    private void frmCadastroUnidadeDeMedida_Load(object sender, EventArgs e)
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
          QueryDB.ExcluirUnidadeDeMedida(Convert.ToInt32(txtCodigoUmed.Text));

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
        ModeloUnidadeDeMedida modeloUmed = new ModeloUnidadeDeMedida();

        modeloUmed.UmedNome = txtNomeUmed.Text;        

        if (this.operacao == Inserir)
        {
          QueryDB.IncluirUnidadeDeMedida(modeloUmed, operacao);
          MessageBox.Show("Cadastro efetuado com sucesso!! \nCódigo: " + modeloUmed.UmedCod.ToString());
        }
        else
        {
          modeloUmed.UmedCod = Convert.ToInt32(txtCodigoUmed.Text);

          QueryDB.AlterarUnidadeDeMedida(modeloUmed, operacao);
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

    #region Metodos Auxiliares
    private void LimparDadosDaTela()
    {
      txtCodigoUmed.Clear();
      txtNomeUmed.Clear();
    }

    #endregion

    private void btnLocalizar_Click(object sender, EventArgs e)
    {
      using(frmPesquisarUnidadeDeMedida pesquisar = new frmPesquisarUnidadeDeMedida())
      {
        pesquisar.ShowDialog();

        if (pesquisar.codigo != 0)
        {
          ModeloUnidadeDeMedida modelo = QueryDB.CarregaUnidadeDeMedida(pesquisar.codigo);

          txtCodigoUmed.Text = Convert.ToString(modelo.UmedCod);
          txtNomeUmed.Text = modelo.UmedNome;

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
