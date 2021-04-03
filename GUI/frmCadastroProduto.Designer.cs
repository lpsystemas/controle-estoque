namespace GUI
{
  partial class frmCadastroProduto
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
      this.lblCodigo = new System.Windows.Forms.Label();
      this.lblNome = new System.Windows.Forms.Label();
      this.txtCodigoPrd = new System.Windows.Forms.TextBox();
      this.txtNomePrd = new System.Windows.Forms.TextBox();
      this.lblDescricao = new System.Windows.Forms.Label();
      this.txtDescricaoPrd = new System.Windows.Forms.TextBox();
      this.lblValorPago = new System.Windows.Forms.Label();
      this.txtValorPagoPrd = new System.Windows.Forms.TextBox();
      this.lblValorVenda = new System.Windows.Forms.Label();
      this.txtValorVendaPrd = new System.Windows.Forms.TextBox();
      this.lblQuantidade = new System.Windows.Forms.Label();
      this.txtQuantidadePrd = new System.Windows.Forms.TextBox();
      this.lblUmed = new System.Windows.Forms.Label();
      this.cboUmedPrd = new System.Windows.Forms.ComboBox();
      this.cboSubCatPrd = new System.Windows.Forms.ComboBox();
      this.cboCatPrd = new System.Windows.Forms.ComboBox();
      this.lblSubCat = new System.Windows.Forms.Label();
      this.lblCategoria = new System.Windows.Forms.Label();
      this.lblFoto = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.pbFotoPrd = new System.Windows.Forms.PictureBox();
      this.btnCarregarFotoPrd = new System.Windows.Forms.Button();
      this.btnRemoverFotoPrd = new System.Windows.Forms.Button();
      this.pnDados.SuspendLayout();
      this.pnBotoes.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbFotoPrd)).BeginInit();
      this.SuspendLayout();
      // 
      // pnDados
      // 
      this.pnDados.Controls.Add(this.btnRemoverFotoPrd);
      this.pnDados.Controls.Add(this.btnCarregarFotoPrd);
      this.pnDados.Controls.Add(this.panel1);
      this.pnDados.Controls.Add(this.lblFoto);
      this.pnDados.Controls.Add(this.lblCategoria);
      this.pnDados.Controls.Add(this.lblSubCat);
      this.pnDados.Controls.Add(this.cboCatPrd);
      this.pnDados.Controls.Add(this.cboSubCatPrd);
      this.pnDados.Controls.Add(this.cboUmedPrd);
      this.pnDados.Controls.Add(this.lblUmed);
      this.pnDados.Controls.Add(this.txtQuantidadePrd);
      this.pnDados.Controls.Add(this.lblQuantidade);
      this.pnDados.Controls.Add(this.txtValorVendaPrd);
      this.pnDados.Controls.Add(this.lblValorVenda);
      this.pnDados.Controls.Add(this.txtValorPagoPrd);
      this.pnDados.Controls.Add(this.lblValorPago);
      this.pnDados.Controls.Add(this.txtDescricaoPrd);
      this.pnDados.Controls.Add(this.lblDescricao);
      this.pnDados.Controls.Add(this.txtNomePrd);
      this.pnDados.Controls.Add(this.txtCodigoPrd);
      this.pnDados.Controls.Add(this.lblNome);
      this.pnDados.Controls.Add(this.lblCodigo);
      resources.ApplyResources(this.pnDados, "pnDados");
      // 
      // pnBotoes
      // 
      resources.ApplyResources(this.pnBotoes, "pnBotoes");
      // 
      // btnCancelar
      // 
      resources.ApplyResources(this.btnCancelar, "btnCancelar");
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnSalvar
      // 
      resources.ApplyResources(this.btnSalvar, "btnSalvar");
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // btnExcluir
      // 
      resources.ApplyResources(this.btnExcluir, "btnExcluir");
      this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
      // 
      // btnAlterar
      // 
      resources.ApplyResources(this.btnAlterar, "btnAlterar");
      this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
      // 
      // btnLocalizar
      // 
      resources.ApplyResources(this.btnLocalizar, "btnLocalizar");
      this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
      // 
      // btnInserir
      // 
      resources.ApplyResources(this.btnInserir, "btnInserir");
      this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
      // 
      // lblCodigo
      // 
      resources.ApplyResources(this.lblCodigo, "lblCodigo");
      this.lblCodigo.Name = "lblCodigo";
      // 
      // lblNome
      // 
      resources.ApplyResources(this.lblNome, "lblNome");
      this.lblNome.Name = "lblNome";
      // 
      // txtCodigoPrd
      // 
      resources.ApplyResources(this.txtCodigoPrd, "txtCodigoPrd");
      this.txtCodigoPrd.Name = "txtCodigoPrd";
      // 
      // txtNomePrd
      // 
      resources.ApplyResources(this.txtNomePrd, "txtNomePrd");
      this.txtNomePrd.Name = "txtNomePrd";
      // 
      // lblDescricao
      // 
      resources.ApplyResources(this.lblDescricao, "lblDescricao");
      this.lblDescricao.Name = "lblDescricao";
      // 
      // txtDescricaoPrd
      // 
      resources.ApplyResources(this.txtDescricaoPrd, "txtDescricaoPrd");
      this.txtDescricaoPrd.Name = "txtDescricaoPrd";
      // 
      // lblValorPago
      // 
      resources.ApplyResources(this.lblValorPago, "lblValorPago");
      this.lblValorPago.Name = "lblValorPago";
      // 
      // txtValorPagoPrd
      // 
      resources.ApplyResources(this.txtValorPagoPrd, "txtValorPagoPrd");
      this.txtValorPagoPrd.Name = "txtValorPagoPrd";
      this.txtValorPagoPrd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPagoPrd_KeyPress);
      this.txtValorPagoPrd.Leave += new System.EventHandler(this.txtValorPagoPrd_Leave);
      // 
      // lblValorVenda
      // 
      resources.ApplyResources(this.lblValorVenda, "lblValorVenda");
      this.lblValorVenda.Name = "lblValorVenda";
      // 
      // txtValorVendaPrd
      // 
      resources.ApplyResources(this.txtValorVendaPrd, "txtValorVendaPrd");
      this.txtValorVendaPrd.Name = "txtValorVendaPrd";
      this.txtValorVendaPrd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVendaPrd_KeyPress);
      this.txtValorVendaPrd.Leave += new System.EventHandler(this.txtValorVendaPrd_Leave);
      // 
      // lblQuantidade
      // 
      resources.ApplyResources(this.lblQuantidade, "lblQuantidade");
      this.lblQuantidade.Name = "lblQuantidade";
      // 
      // txtQuantidadePrd
      // 
      resources.ApplyResources(this.txtQuantidadePrd, "txtQuantidadePrd");
      this.txtQuantidadePrd.Name = "txtQuantidadePrd";
      this.txtQuantidadePrd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadePrd_KeyPress);
      this.txtQuantidadePrd.Leave += new System.EventHandler(this.txtQuantidadePrd_Leave);
      // 
      // lblUmed
      // 
      resources.ApplyResources(this.lblUmed, "lblUmed");
      this.lblUmed.Name = "lblUmed";
      // 
      // cboUmedPrd
      // 
      this.cboUmedPrd.FormattingEnabled = true;
      resources.ApplyResources(this.cboUmedPrd, "cboUmedPrd");
      this.cboUmedPrd.Name = "cboUmedPrd";
      // 
      // cboSubCatPrd
      // 
      this.cboSubCatPrd.FormattingEnabled = true;
      resources.ApplyResources(this.cboSubCatPrd, "cboSubCatPrd");
      this.cboSubCatPrd.Name = "cboSubCatPrd";
      // 
      // cboCatPrd
      // 
      this.cboCatPrd.FormattingEnabled = true;
      resources.ApplyResources(this.cboCatPrd, "cboCatPrd");
      this.cboCatPrd.Name = "cboCatPrd";
      this.cboCatPrd.SelectedIndexChanged += new System.EventHandler(this.cboCatPrd_SelectedIndexChanged);
      // 
      // lblSubCat
      // 
      resources.ApplyResources(this.lblSubCat, "lblSubCat");
      this.lblSubCat.Name = "lblSubCat";
      // 
      // lblCategoria
      // 
      resources.ApplyResources(this.lblCategoria, "lblCategoria");
      this.lblCategoria.Name = "lblCategoria";
      // 
      // lblFoto
      // 
      resources.ApplyResources(this.lblFoto, "lblFoto");
      this.lblFoto.Name = "lblFoto";
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.pbFotoPrd);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // pbFotoPrd
      // 
      resources.ApplyResources(this.pbFotoPrd, "pbFotoPrd");
      this.pbFotoPrd.Name = "pbFotoPrd";
      this.pbFotoPrd.TabStop = false;
      // 
      // btnCarregarFotoPrd
      // 
      this.btnCarregarFotoPrd.BackgroundImage = global::GUI.Properties.Resources.CarregaImagem2;
      resources.ApplyResources(this.btnCarregarFotoPrd, "btnCarregarFotoPrd");
      this.btnCarregarFotoPrd.Name = "btnCarregarFotoPrd";
      this.btnCarregarFotoPrd.UseVisualStyleBackColor = true;
      this.btnCarregarFotoPrd.Click += new System.EventHandler(this.btnCarregarFotoPrd_Click);
      // 
      // btnRemoverFotoPrd
      // 
      this.btnRemoverFotoPrd.BackgroundImage = global::GUI.Properties.Resources.Remove_Image;
      resources.ApplyResources(this.btnRemoverFotoPrd, "btnRemoverFotoPrd");
      this.btnRemoverFotoPrd.Name = "btnRemoverFotoPrd";
      this.btnRemoverFotoPrd.UseVisualStyleBackColor = true;
      this.btnRemoverFotoPrd.Click += new System.EventHandler(this.btnRemoverFotoPrd_Click);
      // 
      // frmCadastroProduto
      // 
      resources.ApplyResources(this, "$this");
      this.Name = "frmCadastroProduto";
      this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
      this.pnDados.ResumeLayout(false);
      this.pnDados.PerformLayout();
      this.pnBotoes.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pbFotoPrd)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox txtValorPagoPrd;
    private System.Windows.Forms.Label lblValorPago;
    private System.Windows.Forms.TextBox txtDescricaoPrd;
    private System.Windows.Forms.Label lblDescricao;
    private System.Windows.Forms.TextBox txtNomePrd;
    private System.Windows.Forms.TextBox txtCodigoPrd;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.Label lblCodigo;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblFoto;
    private System.Windows.Forms.Label lblCategoria;
    private System.Windows.Forms.Label lblSubCat;
    private System.Windows.Forms.ComboBox cboCatPrd;
    private System.Windows.Forms.ComboBox cboSubCatPrd;
    private System.Windows.Forms.ComboBox cboUmedPrd;
    private System.Windows.Forms.Label lblUmed;
    private System.Windows.Forms.TextBox txtQuantidadePrd;
    private System.Windows.Forms.Label lblQuantidade;
    private System.Windows.Forms.TextBox txtValorVendaPrd;
    private System.Windows.Forms.Label lblValorVenda;
    private System.Windows.Forms.Button btnRemoverFotoPrd;
    private System.Windows.Forms.Button btnCarregarFotoPrd;
    private System.Windows.Forms.PictureBox pbFotoPrd;
  }
}
