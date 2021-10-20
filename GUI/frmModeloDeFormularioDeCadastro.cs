using System;
using System.Drawing;
using System.Windows.Forms;
using static ConstsEnumerados.Enumerados;

namespace GUI
{
  public partial class frmModeloDeFormularioDeCadastro : Form
  {
    public string operacao;
    public frmModeloDeFormularioDeCadastro()
    {
      InitializeComponent();
    }

    public void AlteraBotoes(int opcaoOP)
    {
      pnDados.Enabled = false;
      btnInserir.Enabled = false;
      btnAlterar.Enabled = false;
      btnCancelar.Enabled = false;
      btnExcluir.Enabled = false;
      btnLocalizar.Enabled = false;
      btnSalvar.Enabled = false;

      if(opcaoOP == Convert.ToInt32(OperacaoFormulario.Inserir_Localizar))
      {
        btnInserir.Enabled = true;
        btnLocalizar.Enabled = true;
      }

      if (opcaoOP == Convert.ToInt32(OperacaoFormulario.Salvar_Cancelar))
      {
        pnDados.Enabled = true;
        btnSalvar.Enabled = true;
        btnCancelar.Enabled = true;
      }

      if (opcaoOP == Convert.ToInt32(OperacaoFormulario.Alterar_Excluir_Cancelar))
      {
        btnAlterar.Enabled = true;
        btnExcluir.Enabled = true;
        btnCancelar.Enabled = true;
      }
    }

    private void frmModeloDeFormularioDeCadastro_Load(object sender, EventArgs e)
    {
      BackColor = Color.LightBlue;
      this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
    }
  }
}
