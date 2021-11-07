
namespace GUI
{
  partial class frmConfiguracaoBancoDeDados
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracaoBancoDeDados));
            this.lblServidor = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.progressBarConfigDB = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblServidor
            // 
            resources.ApplyResources(this.lblServidor, "lblServidor");
            this.lblServidor.Name = "lblServidor";
            // 
            // lblBanco
            // 
            resources.ApplyResources(this.lblBanco, "lblBanco");
            this.lblBanco.Name = "lblBanco";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // lblSenha
            // 
            resources.ApplyResources(this.lblSenha, "lblSenha");
            this.lblSenha.Name = "lblSenha";
            // 
            // txtServidor
            // 
            resources.ApplyResources(this.txtServidor, "txtServidor");
            this.txtServidor.Name = "txtServidor";
            // 
            // txtBanco
            // 
            resources.ApplyResources(this.txtBanco, "txtBanco");
            this.txtBanco.Name = "txtBanco";
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            // 
            // txtSenha
            // 
            resources.ApplyResources(this.txtSenha, "txtSenha");
            this.txtSenha.Name = "txtSenha";
            // 
            // btnSalvar
            // 
            resources.ApplyResources(this.btnSalvar, "btnSalvar");
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // progressBarConfigDB
            // 
            resources.ApplyResources(this.progressBarConfigDB, "progressBarConfigDB");
            this.progressBarConfigDB.Name = "progressBarConfigDB";
            // 
            // frmConfiguracaoBancoDeDados
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBarConfigDB);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.lblServidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConfiguracaoBancoDeDados";
            this.Load += new System.EventHandler(this.frmConfiguracaoBancoDeDados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblServidor;
    private System.Windows.Forms.Label lblBanco;
    private System.Windows.Forms.Label lblUsuario;
    private System.Windows.Forms.Label lblSenha;
    private System.Windows.Forms.TextBox txtServidor;
    private System.Windows.Forms.TextBox txtBanco;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.TextBox txtSenha;
    private System.Windows.Forms.Button btnSalvar;
    private System.Windows.Forms.ProgressBar progressBarConfigDB;
  }
}