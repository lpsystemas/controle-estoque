
namespace GUI
{
    partial class frmCadastroFornecedor
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
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
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
            this.lblMsgConsistCpnj = new System.Windows.Forms.Label();
            this.txtInscEstadual = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lblRgInscEstadual = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gbDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.gbContato);
            this.pnDados.Controls.Add(this.gbEndereco);
            this.pnDados.Controls.Add(this.gbDadosPessoais);
            this.pnDados.Controls.Add(this.txtCodFornecedor);
            this.pnDados.Controls.Add(this.lblCodigo);
            this.pnDados.Size = new System.Drawing.Size(503, 398);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(8, 410);
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
            // gbContato
            // 
            this.gbContato.Controls.Add(this.txtEmail);
            this.gbContato.Controls.Add(this.lblEmail);
            this.gbContato.Controls.Add(this.txtCelular);
            this.gbContato.Controls.Add(this.lblCelular);
            this.gbContato.Controls.Add(this.txtTelefone);
            this.gbContato.Controls.Add(this.lblTelefone);
            this.gbContato.Location = new System.Drawing.Point(5, 289);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(493, 101);
            this.gbContato.TabIndex = 12;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contatos";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(5, 71);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(303, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmail.Location = new System.Drawing.Point(2, 55);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(165, 32);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(143, 20);
            this.txtCelular.TabIndex = 5;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCelular.Location = new System.Drawing.Point(162, 16);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 4;
            this.lblCelular.Text = "Celular:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(6, 32);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(143, 20);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTelefone.Location = new System.Drawing.Point(3, 16);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(80, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone (Fixo):";
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
            this.gbEndereco.Location = new System.Drawing.Point(4, 150);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(493, 139);
            this.gbEndereco.TabIndex = 11;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Logradouro";
            // 
            // txtEstadoUF
            // 
            this.txtEstadoUF.Location = new System.Drawing.Point(250, 110);
            this.txtEstadoUF.Name = "txtEstadoUF";
            this.txtEstadoUF.Size = new System.Drawing.Size(236, 20);
            this.txtEstadoUF.TabIndex = 11;
            // 
            // lblEstadoUF
            // 
            this.lblEstadoUF.AutoSize = true;
            this.lblEstadoUF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEstadoUF.Location = new System.Drawing.Point(247, 94);
            this.lblEstadoUF.Name = "lblEstadoUF";
            this.lblEstadoUF.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoUF.TabIndex = 10;
            this.lblEstadoUF.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(6, 110);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(236, 20);
            this.txtCidade.TabIndex = 9;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCidade.Location = new System.Drawing.Point(3, 94);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(115, 71);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(208, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBairro.Location = new System.Drawing.Point(112, 55);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(6, 71);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(115, 32);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(371, 20);
            this.txtEndereco.TabIndex = 4;
            // 
            // lblNumeroEndereco
            // 
            this.lblNumeroEndereco.AutoSize = true;
            this.lblNumeroEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNumeroEndereco.Location = new System.Drawing.Point(3, 55);
            this.lblNumeroEndereco.Name = "lblNumeroEndereco";
            this.lblNumeroEndereco.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroEndereco.TabIndex = 3;
            this.lblNumeroEndereco.Text = "Numero:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEndereco.Location = new System.Drawing.Point(112, 16);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(6, 32);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 1;
            this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCEP_KeyPress);
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCEP.Location = new System.Drawing.Point(3, 16);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "CEP:";
            // 
            // lblMsgConsistCpnj
            // 
            this.lblMsgConsistCpnj.AutoSize = true;
            this.lblMsgConsistCpnj.ForeColor = System.Drawing.Color.Crimson;
            this.lblMsgConsistCpnj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMsgConsistCpnj.Location = new System.Drawing.Point(410, 16);
            this.lblMsgConsistCpnj.Name = "lblMsgConsistCpnj";
            this.lblMsgConsistCpnj.Size = new System.Drawing.Size(76, 13);
            this.lblMsgConsistCpnj.TabIndex = 10;
            this.lblMsgConsistCpnj.Text = "Valor Incorreto";
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Location = new System.Drawing.Point(331, 74);
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(155, 20);
            this.txtInscEstadual.TabIndex = 9;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(331, 32);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(155, 20);
            this.txtCnpj.TabIndex = 8;
            this.txtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpj_KeyPress);
            this.txtCnpj.Leave += new System.EventHandler(this.txtCnpj_Leave);
            // 
            // lblRgInscEstadual
            // 
            this.lblRgInscEstadual.AutoSize = true;
            this.lblRgInscEstadual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRgInscEstadual.Location = new System.Drawing.Point(328, 58);
            this.lblRgInscEstadual.Name = "lblRgInscEstadual";
            this.lblRgInscEstadual.Size = new System.Drawing.Size(77, 13);
            this.lblRgInscEstadual.TabIndex = 7;
            this.lblRgInscEstadual.Text = "Insc. Estadual:";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCpfCnpj.Location = new System.Drawing.Point(328, 16);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(37, 13);
            this.lblCpfCnpj.TabIndex = 6;
            this.lblCpfCnpj.Text = "CNPJ:";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(6, 74);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(317, 20);
            this.txtRazaoSocial.TabIndex = 5;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRazaoSocial.Location = new System.Drawing.Point(3, 58);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazaoSocial.TabIndex = 4;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(6, 32);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(317, 20);
            this.txtNomeFornecedor.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNome.Location = new System.Drawing.Point(3, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.lblMsgConsistCpnj);
            this.gbDadosPessoais.Controls.Add(this.txtInscEstadual);
            this.gbDadosPessoais.Controls.Add(this.txtCnpj);
            this.gbDadosPessoais.Controls.Add(this.lblRgInscEstadual);
            this.gbDadosPessoais.Controls.Add(this.lblCpfCnpj);
            this.gbDadosPessoais.Controls.Add(this.txtRazaoSocial);
            this.gbDadosPessoais.Controls.Add(this.lblRazaoSocial);
            this.gbDadosPessoais.Controls.Add(this.txtNomeFornecedor);
            this.gbDadosPessoais.Controls.Add(this.lblNome);
            this.gbDadosPessoais.Location = new System.Drawing.Point(4, 50);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(493, 100);
            this.gbDadosPessoais.TabIndex = 10;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Location = new System.Drawing.Point(10, 24);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtCodFornecedor.TabIndex = 9;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCodigo.Location = new System.Drawing.Point(7, 8);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Código:";
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(517, 494);
            this.Name = "frmCadastroFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.frmCadastroFornecedor_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Label lblMsgConsistCpnj;
        private System.Windows.Forms.TextBox txtInscEstadual;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lblRgInscEstadual;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.Label lblCodigo;
    }
}
