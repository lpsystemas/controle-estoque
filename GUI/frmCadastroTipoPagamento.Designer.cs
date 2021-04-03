
namespace GUI
{
  partial class frmCadastroTipoPagamento
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroTipoPagamento));
      this.txtNome = new System.Windows.Forms.TextBox();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.lblNomeTPagto = new System.Windows.Forms.Label();
      this.lblCodigoTPagto = new System.Windows.Forms.Label();
      this.pnDados.SuspendLayout();
      this.pnBotoes.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnDados
      // 
      this.pnDados.Controls.Add(this.txtNome);
      this.pnDados.Controls.Add(this.txtCodigo);
      this.pnDados.Controls.Add(this.lblNomeTPagto);
      this.pnDados.Controls.Add(this.lblCodigoTPagto);
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
      // txtNome
      // 
      resources.ApplyResources(this.txtNome, "txtNome");
      this.txtNome.Name = "txtNome";
      this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
      // 
      // txtCodigo
      // 
      resources.ApplyResources(this.txtCodigo, "txtCodigo");
      this.txtCodigo.Name = "txtCodigo";
      // 
      // lblNomeTPagto
      // 
      resources.ApplyResources(this.lblNomeTPagto, "lblNomeTPagto");
      this.lblNomeTPagto.Name = "lblNomeTPagto";
      // 
      // lblCodigoTPagto
      // 
      resources.ApplyResources(this.lblCodigoTPagto, "lblCodigoTPagto");
      this.lblCodigoTPagto.Name = "lblCodigoTPagto";
      // 
      // frmCadastroTipoPagamento
      // 
      resources.ApplyResources(this, "$this");
      this.Name = "frmCadastroTipoPagamento";
      this.Load += new System.EventHandler(this.frmCadastroTipoPagamento_Load);
      this.pnDados.ResumeLayout(false);
      this.pnDados.PerformLayout();
      this.pnBotoes.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox txtNome;
    private System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.Label lblNomeTPagto;
    private System.Windows.Forms.Label lblCodigoTPagto;
  }
}
