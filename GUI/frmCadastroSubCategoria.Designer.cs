namespace GUI
{
  partial class frmCadastroSubCategoria
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroSubCategoria));
      this.lblCodigoSubCategoria = new System.Windows.Forms.Label();
      this.txtCodigoSubCategoria = new System.Windows.Forms.TextBox();
      this.lblNomeSubCategoria = new System.Windows.Forms.Label();
      this.txtNomeSubCategoria = new System.Windows.Forms.TextBox();
      this.lblCategoria = new System.Windows.Forms.Label();
      this.cbCategoria = new System.Windows.Forms.ComboBox();
      this.pnDados.SuspendLayout();
      this.pnBotoes.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnDados
      // 
      this.pnDados.Controls.Add(this.cbCategoria);
      this.pnDados.Controls.Add(this.lblCategoria);
      this.pnDados.Controls.Add(this.txtNomeSubCategoria);
      this.pnDados.Controls.Add(this.lblNomeSubCategoria);
      this.pnDados.Controls.Add(this.txtCodigoSubCategoria);
      this.pnDados.Controls.Add(this.lblCodigoSubCategoria);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnSalvar
      // 
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // btnExcluir
      // 
      this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
      // 
      // btnAlterar
      // 
      this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
      // 
      // btnLocalizar
      // 
      this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
      // 
      // btnInserir
      // 
      this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
      // 
      // lblCodigoSubCategoria
      // 
      resources.ApplyResources(this.lblCodigoSubCategoria, "lblCodigoSubCategoria");
      this.lblCodigoSubCategoria.Name = "lblCodigoSubCategoria";
      // 
      // txtCodigoSubCategoria
      // 
      resources.ApplyResources(this.txtCodigoSubCategoria, "txtCodigoSubCategoria");
      this.txtCodigoSubCategoria.Name = "txtCodigoSubCategoria";
      // 
      // lblNomeSubCategoria
      // 
      resources.ApplyResources(this.lblNomeSubCategoria, "lblNomeSubCategoria");
      this.lblNomeSubCategoria.Name = "lblNomeSubCategoria";
      // 
      // txtNomeSubCategoria
      // 
      resources.ApplyResources(this.txtNomeSubCategoria, "txtNomeSubCategoria");
      this.txtNomeSubCategoria.Name = "txtNomeSubCategoria";
      // 
      // lblCategoria
      // 
      resources.ApplyResources(this.lblCategoria, "lblCategoria");
      this.lblCategoria.Name = "lblCategoria";
      // 
      // cbCategoria
      // 
      this.cbCategoria.FormattingEnabled = true;
      resources.ApplyResources(this.cbCategoria, "cbCategoria");
      this.cbCategoria.Name = "cbCategoria";
      // 
      // frmCadastroSubCategoria
      // 
      resources.ApplyResources(this, "$this");
      this.Name = "frmCadastroSubCategoria";
      this.Load += new System.EventHandler(this.frmCadastroSubCategoria_Load);
      this.pnDados.ResumeLayout(false);
      this.pnDados.PerformLayout();
      this.pnBotoes.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblCategoria;
    private System.Windows.Forms.TextBox txtNomeSubCategoria;
    private System.Windows.Forms.Label lblNomeSubCategoria;
    private System.Windows.Forms.TextBox txtCodigoSubCategoria;
    private System.Windows.Forms.Label lblCodigoSubCategoria;
    private System.Windows.Forms.ComboBox cbCategoria;
  }
}
