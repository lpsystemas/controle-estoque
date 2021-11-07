
namespace GUI
{
  partial class frmPesquisarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarCliente));
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.txtValorPesquisaCliente = new System.Windows.Forms.TextBox();
            this.lblValorPesquisaCliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCnpjCliente = new System.Windows.Forms.RadioButton();
            this.rbCpfCliente = new System.Windows.Forms.RadioButton();
            this.rbNomeCliente = new System.Windows.Forms.RadioButton();
            this.lblMsgConsisteCpfCnpj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgvDados, "dgvDados");
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowTemplate.Height = 28;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // btnLocalizar
            // 
            resources.ApplyResources(this.btnLocalizar, "btnLocalizar");
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtValorPesquisaCliente
            // 
            resources.ApplyResources(this.txtValorPesquisaCliente, "txtValorPesquisaCliente");
            this.txtValorPesquisaCliente.Name = "txtValorPesquisaCliente";
            this.txtValorPesquisaCliente.TextChanged += new System.EventHandler(this.txtValorPesquisaCliente_TextChanged);
            this.txtValorPesquisaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPesquisaCliente_KeyPress);
            this.txtValorPesquisaCliente.Leave += new System.EventHandler(this.txtValorPesquisaCliente_Leave);
            // 
            // lblValorPesquisaCliente
            // 
            resources.ApplyResources(this.lblValorPesquisaCliente, "lblValorPesquisaCliente");
            this.lblValorPesquisaCliente.Name = "lblValorPesquisaCliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCnpjCliente);
            this.groupBox1.Controls.Add(this.rbCpfCliente);
            this.groupBox1.Controls.Add(this.rbNomeCliente);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rbCnpjCliente
            // 
            resources.ApplyResources(this.rbCnpjCliente, "rbCnpjCliente");
            this.rbCnpjCliente.Name = "rbCnpjCliente";
            this.rbCnpjCliente.TabStop = true;
            this.rbCnpjCliente.UseVisualStyleBackColor = true;
            this.rbCnpjCliente.CheckedChanged += new System.EventHandler(this.rbCnpjCliente_CheckedChanged);
            // 
            // rbCpfCliente
            // 
            resources.ApplyResources(this.rbCpfCliente, "rbCpfCliente");
            this.rbCpfCliente.Name = "rbCpfCliente";
            this.rbCpfCliente.TabStop = true;
            this.rbCpfCliente.UseVisualStyleBackColor = true;
            this.rbCpfCliente.CheckedChanged += new System.EventHandler(this.rbCpfCliente_CheckedChanged);
            // 
            // rbNomeCliente
            // 
            resources.ApplyResources(this.rbNomeCliente, "rbNomeCliente");
            this.rbNomeCliente.Name = "rbNomeCliente";
            this.rbNomeCliente.TabStop = true;
            this.rbNomeCliente.UseVisualStyleBackColor = true;
            this.rbNomeCliente.CheckedChanged += new System.EventHandler(this.rbNomeCliente_CheckedChanged);
            // 
            // lblMsgConsisteCpfCnpj
            // 
            resources.ApplyResources(this.lblMsgConsisteCpfCnpj, "lblMsgConsisteCpfCnpj");
            this.lblMsgConsisteCpfCnpj.ForeColor = System.Drawing.Color.Crimson;
            this.lblMsgConsisteCpfCnpj.Name = "lblMsgConsisteCpfCnpj";
            // 
            // frmPesquisarCliente
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMsgConsisteCpfCnpj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.txtValorPesquisaCliente);
            this.Controls.Add(this.lblValorPesquisaCliente);
            this.Name = "frmPesquisarCliente";
            this.Load += new System.EventHandler(this.frmPesquisarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvDados;
    private System.Windows.Forms.Button btnLocalizar;
    private System.Windows.Forms.TextBox txtValorPesquisaCliente;
    private System.Windows.Forms.Label lblValorPesquisaCliente;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rbCpfCliente;
    private System.Windows.Forms.RadioButton rbNomeCliente;
    private System.Windows.Forms.RadioButton rbCnpjCliente;
        private System.Windows.Forms.Label lblMsgConsisteCpfCnpj;
    }
}