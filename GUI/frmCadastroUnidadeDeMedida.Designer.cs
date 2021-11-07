namespace GUI
{
  partial class frmCadastroUnidadeDeMedida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUnidadeDeMedida));
            this.txtNomeUmed = new System.Windows.Forms.TextBox();
            this.txtCodigoUmed = new System.Windows.Forms.TextBox();
            this.lblNomeUmed = new System.Windows.Forms.Label();
            this.lblCodigoUmed = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txtNomeUmed);
            this.pnDados.Controls.Add(this.txtCodigoUmed);
            this.pnDados.Controls.Add(this.lblNomeUmed);
            this.pnDados.Controls.Add(this.lblCodigoUmed);
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
            // txtNomeUmed
            // 
            resources.ApplyResources(this.txtNomeUmed, "txtNomeUmed");
            this.txtNomeUmed.Name = "txtNomeUmed";
            // 
            // txtCodigoUmed
            // 
            resources.ApplyResources(this.txtCodigoUmed, "txtCodigoUmed");
            this.txtCodigoUmed.Name = "txtCodigoUmed";
            // 
            // lblNomeUmed
            // 
            resources.ApplyResources(this.lblNomeUmed, "lblNomeUmed");
            this.lblNomeUmed.Name = "lblNomeUmed";
            // 
            // lblCodigoUmed
            // 
            resources.ApplyResources(this.lblCodigoUmed, "lblCodigoUmed");
            this.lblCodigoUmed.Name = "lblCodigoUmed";
            // 
            // frmCadastroUnidadeDeMedida
            // 
            resources.ApplyResources(this, "$this");
            this.Name = "frmCadastroUnidadeDeMedida";
            this.Load += new System.EventHandler(this.frmCadastroUnidadeDeMedida_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox txtNomeUmed;
    private System.Windows.Forms.TextBox txtCodigoUmed;
    private System.Windows.Forms.Label lblNomeUmed;
    private System.Windows.Forms.Label lblCodigoUmed;
  }
}
