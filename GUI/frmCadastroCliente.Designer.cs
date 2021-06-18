
namespace GUI
{
  partial class frmCadastroCliente
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCliente));
      this.lblCodigo = new System.Windows.Forms.Label();
      this.txtCodCliente = new System.Windows.Forms.TextBox();
      this.lblNome = new System.Windows.Forms.Label();
      this.txtNomeCliente = new System.Windows.Forms.TextBox();
      this.gbTipoCliente = new System.Windows.Forms.GroupBox();
      this.rbTipoJuridica = new System.Windows.Forms.RadioButton();
      this.rbTipoFisica = new System.Windows.Forms.RadioButton();
      this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
      this.txtRgInscEstadual = new System.Windows.Forms.TextBox();
      this.txtCpfCnpj = new System.Windows.Forms.TextBox();
      this.lblRgInscEstadual = new System.Windows.Forms.Label();
      this.lblCpfCnpj = new System.Windows.Forms.Label();
      this.txtRazaoSocial = new System.Windows.Forms.TextBox();
      this.lblRazaoSocial = new System.Windows.Forms.Label();
      this.gbEndereco = new System.Windows.Forms.GroupBox();
      this.txtEstadoUF = new System.Windows.Forms.TextBox();
      this.lblEstadoUF = new System.Windows.Forms.Label();
      this.txtCidade = new System.Windows.Forms.TextBox();
      this.lblCidade = new System.Windows.Forms.Label();
      this.txtBairro = new System.Windows.Forms.TextBox();
      this.lblBairro = new System.Windows.Forms.Label();
      this.txtNumero = new System.Windows.Forms.TextBox();
      this.txtEndereco = new System.Windows.Forms.TextBox();
      this.lblNumeroEndereco = new System.Windows.Forms.Label();
      this.lblEndereco = new System.Windows.Forms.Label();
      this.txtCEP = new System.Windows.Forms.TextBox();
      this.lblCEP = new System.Windows.Forms.Label();
      this.gbContato = new System.Windows.Forms.GroupBox();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.lblEmail = new System.Windows.Forms.Label();
      this.txtCelular = new System.Windows.Forms.TextBox();
      this.lblCelular = new System.Windows.Forms.Label();
      this.txtTelefone = new System.Windows.Forms.TextBox();
      this.lblTelefone = new System.Windows.Forms.Label();
      this.lblMsgConsistCpfCpnj = new System.Windows.Forms.Label();
      this.pnDados.SuspendLayout();
      this.pnBotoes.SuspendLayout();
      this.gbTipoCliente.SuspendLayout();
      this.gbDadosPessoais.SuspendLayout();
      this.gbEndereco.SuspendLayout();
      this.gbContato.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnDados
      // 
      this.pnDados.Controls.Add(this.gbContato);
      this.pnDados.Controls.Add(this.gbEndereco);
      this.pnDados.Controls.Add(this.gbDadosPessoais);
      this.pnDados.Controls.Add(this.gbTipoCliente);
      this.pnDados.Controls.Add(this.txtCodCliente);
      this.pnDados.Controls.Add(this.lblCodigo);
      resources.ApplyResources(this.pnDados, "pnDados");
      // 
      // pnBotoes
      // 
      resources.ApplyResources(this.pnBotoes, "pnBotoes");
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
      // lblCodigo
      // 
      resources.ApplyResources(this.lblCodigo, "lblCodigo");
      this.lblCodigo.Name = "lblCodigo";
      // 
      // txtCodCliente
      // 
      resources.ApplyResources(this.txtCodCliente, "txtCodCliente");
      this.txtCodCliente.Name = "txtCodCliente";
      // 
      // lblNome
      // 
      resources.ApplyResources(this.lblNome, "lblNome");
      this.lblNome.Name = "lblNome";
      // 
      // txtNomeCliente
      // 
      resources.ApplyResources(this.txtNomeCliente, "txtNomeCliente");
      this.txtNomeCliente.Name = "txtNomeCliente";
      // 
      // gbTipoCliente
      // 
      this.gbTipoCliente.Controls.Add(this.rbTipoJuridica);
      this.gbTipoCliente.Controls.Add(this.rbTipoFisica);
      resources.ApplyResources(this.gbTipoCliente, "gbTipoCliente");
      this.gbTipoCliente.Name = "gbTipoCliente";
      this.gbTipoCliente.TabStop = false;
      // 
      // rbTipoJuridica
      // 
      resources.ApplyResources(this.rbTipoJuridica, "rbTipoJuridica");
      this.rbTipoJuridica.Name = "rbTipoJuridica";
      this.rbTipoJuridica.UseVisualStyleBackColor = true;
      // 
      // rbTipoFisica
      // 
      resources.ApplyResources(this.rbTipoFisica, "rbTipoFisica");
      this.rbTipoFisica.Checked = true;
      this.rbTipoFisica.Name = "rbTipoFisica";
      this.rbTipoFisica.TabStop = true;
      this.rbTipoFisica.UseVisualStyleBackColor = true;
      this.rbTipoFisica.CheckedChanged += new System.EventHandler(this.rbTipoFisica_CheckedChanged);
      // 
      // gbDadosPessoais
      // 
      this.gbDadosPessoais.Controls.Add(this.lblMsgConsistCpfCpnj);
      this.gbDadosPessoais.Controls.Add(this.txtRgInscEstadual);
      this.gbDadosPessoais.Controls.Add(this.txtCpfCnpj);
      this.gbDadosPessoais.Controls.Add(this.lblRgInscEstadual);
      this.gbDadosPessoais.Controls.Add(this.lblCpfCnpj);
      this.gbDadosPessoais.Controls.Add(this.txtRazaoSocial);
      this.gbDadosPessoais.Controls.Add(this.lblRazaoSocial);
      this.gbDadosPessoais.Controls.Add(this.txtNomeCliente);
      this.gbDadosPessoais.Controls.Add(this.lblNome);
      resources.ApplyResources(this.gbDadosPessoais, "gbDadosPessoais");
      this.gbDadosPessoais.Name = "gbDadosPessoais";
      this.gbDadosPessoais.TabStop = false;
      // 
      // txtRgInscEstadual
      // 
      resources.ApplyResources(this.txtRgInscEstadual, "txtRgInscEstadual");
      this.txtRgInscEstadual.Name = "txtRgInscEstadual";
      // 
      // txtCpfCnpj
      // 
      resources.ApplyResources(this.txtCpfCnpj, "txtCpfCnpj");
      this.txtCpfCnpj.Name = "txtCpfCnpj";
      this.txtCpfCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpfCnpj_KeyPress);
      this.txtCpfCnpj.Leave += new System.EventHandler(this.txtCpfCnpj_Leave);
      // 
      // lblRgInscEstadual
      // 
      resources.ApplyResources(this.lblRgInscEstadual, "lblRgInscEstadual");
      this.lblRgInscEstadual.Name = "lblRgInscEstadual";
      // 
      // lblCpfCnpj
      // 
      resources.ApplyResources(this.lblCpfCnpj, "lblCpfCnpj");
      this.lblCpfCnpj.Name = "lblCpfCnpj";
      // 
      // txtRazaoSocial
      // 
      resources.ApplyResources(this.txtRazaoSocial, "txtRazaoSocial");
      this.txtRazaoSocial.Name = "txtRazaoSocial";
      // 
      // lblRazaoSocial
      // 
      resources.ApplyResources(this.lblRazaoSocial, "lblRazaoSocial");
      this.lblRazaoSocial.Name = "lblRazaoSocial";
      // 
      // gbEndereco
      // 
      this.gbEndereco.Controls.Add(this.txtEstadoUF);
      this.gbEndereco.Controls.Add(this.lblEstadoUF);
      this.gbEndereco.Controls.Add(this.txtCidade);
      this.gbEndereco.Controls.Add(this.lblCidade);
      this.gbEndereco.Controls.Add(this.txtBairro);
      this.gbEndereco.Controls.Add(this.lblBairro);
      this.gbEndereco.Controls.Add(this.txtNumero);
      this.gbEndereco.Controls.Add(this.txtEndereco);
      this.gbEndereco.Controls.Add(this.lblNumeroEndereco);
      this.gbEndereco.Controls.Add(this.lblEndereco);
      this.gbEndereco.Controls.Add(this.txtCEP);
      this.gbEndereco.Controls.Add(this.lblCEP);
      resources.ApplyResources(this.gbEndereco, "gbEndereco");
      this.gbEndereco.Name = "gbEndereco";
      this.gbEndereco.TabStop = false;
      // 
      // txtEstadoUF
      // 
      resources.ApplyResources(this.txtEstadoUF, "txtEstadoUF");
      this.txtEstadoUF.Name = "txtEstadoUF";
      // 
      // lblEstadoUF
      // 
      resources.ApplyResources(this.lblEstadoUF, "lblEstadoUF");
      this.lblEstadoUF.Name = "lblEstadoUF";
      // 
      // txtCidade
      // 
      resources.ApplyResources(this.txtCidade, "txtCidade");
      this.txtCidade.Name = "txtCidade";
      // 
      // lblCidade
      // 
      resources.ApplyResources(this.lblCidade, "lblCidade");
      this.lblCidade.Name = "lblCidade";
      // 
      // txtBairro
      // 
      resources.ApplyResources(this.txtBairro, "txtBairro");
      this.txtBairro.Name = "txtBairro";
      // 
      // lblBairro
      // 
      resources.ApplyResources(this.lblBairro, "lblBairro");
      this.lblBairro.Name = "lblBairro";
      // 
      // txtNumero
      // 
      resources.ApplyResources(this.txtNumero, "txtNumero");
      this.txtNumero.Name = "txtNumero";
      // 
      // txtEndereco
      // 
      resources.ApplyResources(this.txtEndereco, "txtEndereco");
      this.txtEndereco.Name = "txtEndereco";
      // 
      // lblNumeroEndereco
      // 
      resources.ApplyResources(this.lblNumeroEndereco, "lblNumeroEndereco");
      this.lblNumeroEndereco.Name = "lblNumeroEndereco";
      // 
      // lblEndereco
      // 
      resources.ApplyResources(this.lblEndereco, "lblEndereco");
      this.lblEndereco.Name = "lblEndereco";
      // 
      // txtCEP
      // 
      resources.ApplyResources(this.txtCEP, "txtCEP");
      this.txtCEP.Name = "txtCEP";
      this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
      // 
      // lblCEP
      // 
      resources.ApplyResources(this.lblCEP, "lblCEP");
      this.lblCEP.Name = "lblCEP";
      // 
      // gbContato
      // 
      this.gbContato.Controls.Add(this.txtEmail);
      this.gbContato.Controls.Add(this.lblEmail);
      this.gbContato.Controls.Add(this.txtCelular);
      this.gbContato.Controls.Add(this.lblCelular);
      this.gbContato.Controls.Add(this.txtTelefone);
      this.gbContato.Controls.Add(this.lblTelefone);
      resources.ApplyResources(this.gbContato, "gbContato");
      this.gbContato.Name = "gbContato";
      this.gbContato.TabStop = false;
      // 
      // txtEmail
      // 
      resources.ApplyResources(this.txtEmail, "txtEmail");
      this.txtEmail.Name = "txtEmail";
      // 
      // lblEmail
      // 
      resources.ApplyResources(this.lblEmail, "lblEmail");
      this.lblEmail.Name = "lblEmail";
      // 
      // txtCelular
      // 
      resources.ApplyResources(this.txtCelular, "txtCelular");
      this.txtCelular.Name = "txtCelular";
      // 
      // lblCelular
      // 
      resources.ApplyResources(this.lblCelular, "lblCelular");
      this.lblCelular.Name = "lblCelular";
      // 
      // txtTelefone
      // 
      resources.ApplyResources(this.txtTelefone, "txtTelefone");
      this.txtTelefone.Name = "txtTelefone";
      // 
      // lblTelefone
      // 
      resources.ApplyResources(this.lblTelefone, "lblTelefone");
      this.lblTelefone.Name = "lblTelefone";
      // 
      // lblMsgConsistCpfCpnj
      // 
      resources.ApplyResources(this.lblMsgConsistCpfCpnj, "lblMsgConsistCpfCpnj");
      this.lblMsgConsistCpfCpnj.ForeColor = System.Drawing.Color.Crimson;
      this.lblMsgConsistCpfCpnj.Name = "lblMsgConsistCpfCpnj";
      // 
      // frmCadastroCliente
      // 
      resources.ApplyResources(this, "$this");
      this.Name = "frmCadastroCliente";
      this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
      this.pnDados.ResumeLayout(false);
      this.pnDados.PerformLayout();
      this.pnBotoes.ResumeLayout(false);
      this.gbTipoCliente.ResumeLayout(false);
      this.gbTipoCliente.PerformLayout();
      this.gbDadosPessoais.ResumeLayout(false);
      this.gbDadosPessoais.PerformLayout();
      this.gbEndereco.ResumeLayout(false);
      this.gbEndereco.PerformLayout();
      this.gbContato.ResumeLayout(false);
      this.gbContato.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblCodigo;
    private System.Windows.Forms.GroupBox gbTipoCliente;
    private System.Windows.Forms.RadioButton rbTipoJuridica;
    private System.Windows.Forms.RadioButton rbTipoFisica;
    private System.Windows.Forms.TextBox txtNomeCliente;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.TextBox txtCodCliente;
    private System.Windows.Forms.GroupBox gbContato;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtCelular;
    private System.Windows.Forms.Label lblCelular;
    private System.Windows.Forms.TextBox txtTelefone;
    private System.Windows.Forms.Label lblTelefone;
    private System.Windows.Forms.GroupBox gbEndereco;
    private System.Windows.Forms.TextBox txtEstadoUF;
    private System.Windows.Forms.Label lblEstadoUF;
    private System.Windows.Forms.TextBox txtCidade;
    private System.Windows.Forms.Label lblCidade;
    private System.Windows.Forms.TextBox txtBairro;
    private System.Windows.Forms.Label lblBairro;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.TextBox txtEndereco;
    private System.Windows.Forms.Label lblNumeroEndereco;
    private System.Windows.Forms.Label lblEndereco;
    private System.Windows.Forms.TextBox txtCEP;
    private System.Windows.Forms.Label lblCEP;
    private System.Windows.Forms.GroupBox gbDadosPessoais;
    private System.Windows.Forms.TextBox txtRgInscEstadual;
    private System.Windows.Forms.TextBox txtCpfCnpj;
    private System.Windows.Forms.Label lblRgInscEstadual;
    private System.Windows.Forms.Label lblCpfCnpj;
    private System.Windows.Forms.TextBox txtRazaoSocial;
    private System.Windows.Forms.Label lblRazaoSocial;
    private System.Windows.Forms.Label lblMsgConsistCpfCpnj;
  }
}
