using BLL.Util;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static ConstsEnumerados.Constantes;

namespace GUI
{
    public partial class frmConfiguracaoBancoDeDados : Form
  {
    public BLLUtils Utils
    {
      get { 
            if (_utils == null)
              _utils = new BLLUtils();
            return _utils;
          }
    }
    private BLLUtils _utils = null;    
    
    public frmConfiguracaoBancoDeDados()
    {
      InitializeComponent();      
    }
        
    private void btnSalvar_Click(object sender, EventArgs e)
    {
      string message = "Não foi possivel estabelecer uma conexão com o banco de dados.\n\n" +
                 "Acesse [Ferramentas - Configurações de Banco de Dados] e informe os dados corretamente.";

      ConsistePreenchmentodeCamposDaTela();
      progressBarConfigDB.Value = metadeProgresso;
      progressBarConfigDB.Visible = true;
            

      if (progressBarConfigDB.Value == metadeProgresso)
      {        
        CriaAtualizaArquivoDeConfigDB();
        Close();

        MessageBox.Show("Arquivo Atualizado com Sucesso!!");        
      }

      progressBarConfigDB.Value = totalProgresso;

      if(progressBarConfigDB.Value == totalProgresso)
      {
        if (!Utils.VerificaConexaoComArquivoDeConfigDB())
          MessageBox.Show(message);
        else
        {
          HabilitaMenusFormPrincipal();
          MessageBox.Show("Conexão com o banco de daods realizada com sucesso!!");
        }          
      }      
    }

    private void frmConfiguracaoBancoDeDados_Load(object sender, EventArgs e)
    {
            BackColor = Color.LightBlue;
            CarregaForm();
            ConfiguraVisibilidadeComponetesForm();
    }

    #region Metodos Auxiliares

    private void ConfiguraVisibilidadeComponetesForm()
    {
      progressBarConfigDB.Visible = false;
    }
    private void CriaAtualizaArquivoDeConfigDB()
    {
      using (StreamWriter arquivo = new StreamWriter("ConfiguracaoBancoDeDados.txt", false))
      {
        arquivo.WriteLine(txtServidor.Text);
        arquivo.WriteLine(txtBanco.Text);
        arquivo.WriteLine(txtUsuario.Text);
        arquivo.WriteLine(txtSenha.Text);
        arquivo.Close();
      }
    }
    private void ConsistePreenchmentodeCamposDaTela()
    {
      if (string.IsNullOrEmpty(txtServidor.Text))
        throw new WarningException(Properties.Resources.SInformarServidorArquivoConfig);
        
      if (string.IsNullOrEmpty(txtBanco.Text))
        throw new WarningException(Properties.Resources.SInformarNomeBancoArquivoConfig);

      if (string.IsNullOrEmpty(txtUsuario.Text))
        throw new WarningException(Properties.Resources.SInformarNomeUsuarioArquivoConfig);

      if (string.IsNullOrEmpty(txtSenha.Text))
        throw new WarningException(Properties.Resources.SInformarSenhaUsuarioBancoArquivoConfig);
    }
    private void HabilitaMenusFormPrincipal()
    {
      frmPrincipal principal = (frmPrincipal)Application.OpenForms["frmPrincipal"];
      principal.MainMenuStrip.Items[0].Enabled = true;
      principal.MainMenuStrip.Items[1].Enabled = true;
      principal.MainMenuStrip.Items[2].Enabled = true;
      principal.MainMenuStrip.Items[3].Enabled = true;
      principal.MainMenuStrip.Items[5].Enabled = true;
    }
    private void CarregaForm()
    {
      if (File.Exists("ConfiguracaoBancoDeDados.txt"))
      {
        using (StreamReader carregaArquivo = new StreamReader("ConfiguracaoBancoDeDados.txt"))
        {
          this.txtServidor.Text = carregaArquivo.ReadLine();
          this.txtBanco.Text = carregaArquivo.ReadLine();
          this.txtUsuario.Text = carregaArquivo.ReadLine();
          this.txtSenha.Text = carregaArquivo.ReadLine();

          carregaArquivo.Close();
        }
      }
    }
    #endregion
  }
}
