
namespace GUI
{
    partial class frmPesquisarFornecedor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCnpjFornecedor = new System.Windows.Forms.RadioButton();
            this.rbNomeFornecedor = new System.Windows.Forms.RadioButton();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.txtValorPesquisaFornecedor = new System.Windows.Forms.TextBox();
            this.lblValorPesquisaFornecedor = new System.Windows.Forms.Label();
            this.lblMsgConsistCnpj = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCnpjFornecedor);
            this.groupBox1.Controls.Add(this.rbNomeFornecedor);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 51);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por:";
            // 
            // rbCnpjFornecedor
            // 
            this.rbCnpjFornecedor.AutoSize = true;
            this.rbCnpjFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbCnpjFornecedor.Location = new System.Drawing.Point(105, 19);
            this.rbCnpjFornecedor.Name = "rbCnpjFornecedor";
            this.rbCnpjFornecedor.Size = new System.Drawing.Size(52, 17);
            this.rbCnpjFornecedor.TabIndex = 2;
            this.rbCnpjFornecedor.TabStop = true;
            this.rbCnpjFornecedor.Text = "CNPJ";
            this.rbCnpjFornecedor.UseVisualStyleBackColor = true;
            this.rbCnpjFornecedor.CheckedChanged += new System.EventHandler(this.rbCnpjFornecedor_CheckedChanged);
            // 
            // rbNomeFornecedor
            // 
            this.rbNomeFornecedor.AutoSize = true;
            this.rbNomeFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbNomeFornecedor.Location = new System.Drawing.Point(29, 19);
            this.rbNomeFornecedor.Name = "rbNomeFornecedor";
            this.rbNomeFornecedor.Size = new System.Drawing.Size(53, 17);
            this.rbNomeFornecedor.TabIndex = 0;
            this.rbNomeFornecedor.TabStop = true;
            this.rbNomeFornecedor.Text = "Nome";
            this.rbNomeFornecedor.UseVisualStyleBackColor = true;
            this.rbNomeFornecedor.CheckedChanged += new System.EventHandler(this.rbNomeFornecedor_CheckedChanged);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(8, 119);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 62;
            this.dgvDados.RowTemplate.Height = 28;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(503, 288);
            this.dgvDados.TabIndex = 12;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocalizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLocalizar.Location = new System.Drawing.Point(443, 85);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(68, 22);
            this.btnLocalizar.TabIndex = 11;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtValorPesquisaFornecedor
            // 
            this.txtValorPesquisaFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorPesquisaFornecedor.Location = new System.Drawing.Point(11, 87);
            this.txtValorPesquisaFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorPesquisaFornecedor.Name = "txtValorPesquisaFornecedor";
            this.txtValorPesquisaFornecedor.Size = new System.Drawing.Size(429, 20);
            this.txtValorPesquisaFornecedor.TabIndex = 10;
            this.txtValorPesquisaFornecedor.TextChanged += new System.EventHandler(this.txtValorPesquisaFornecedor_TextChanged);
            this.txtValorPesquisaFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPesquisaFornecedor_KeyPress);
            this.txtValorPesquisaFornecedor.Leave += new System.EventHandler(this.txtValorPesquisaFornecedor_Leave);
            // 
            // lblValorPesquisaFornecedor
            // 
            this.lblValorPesquisaFornecedor.AutoSize = true;
            this.lblValorPesquisaFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblValorPesquisaFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblValorPesquisaFornecedor.Location = new System.Drawing.Point(8, 72);
            this.lblValorPesquisaFornecedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorPesquisaFornecedor.Name = "lblValorPesquisaFornecedor";
            this.lblValorPesquisaFornecedor.Size = new System.Drawing.Size(40, 13);
            this.lblValorPesquisaFornecedor.TabIndex = 9;
            this.lblValorPesquisaFornecedor.Text = "Valor:";
            // 
            // lblMsgConsistCnpj
            // 
            this.lblMsgConsistCnpj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsgConsistCnpj.AutoSize = true;
            this.lblMsgConsistCnpj.ForeColor = System.Drawing.Color.Crimson;
            this.lblMsgConsistCnpj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMsgConsistCnpj.Location = new System.Drawing.Point(364, 72);
            this.lblMsgConsistCnpj.Name = "lblMsgConsistCnpj";
            this.lblMsgConsistCnpj.Size = new System.Drawing.Size(76, 13);
            this.lblMsgConsistCnpj.TabIndex = 14;
            this.lblMsgConsistCnpj.Text = "Valor Incorreto";
            this.lblMsgConsistCnpj.Visible = false;
            // 
            // frmPesquisarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 414);
            this.Controls.Add(this.lblMsgConsistCnpj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.txtValorPesquisaFornecedor);
            this.Controls.Add(this.lblValorPesquisaFornecedor);
            this.Name = "frmPesquisarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Fornecedor";
            this.Load += new System.EventHandler(this.frmPesquisarFornecedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCnpjFornecedor;
        private System.Windows.Forms.RadioButton rbNomeFornecedor;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox txtValorPesquisaFornecedor;
        private System.Windows.Forms.Label lblValorPesquisaFornecedor;
        private System.Windows.Forms.Label lblMsgConsistCnpj;
    }
}