
namespace GUI
{
  partial class frmPesquisarTipoDePagamento
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarTipoDePagamento));
      this.dgvDados = new System.Windows.Forms.DataGridView();
      this.txtNomeTipoDePagamento = new System.Windows.Forms.TextBox();
      this.lblTipoDePagamento = new System.Windows.Forms.Label();
      this.btnLocalizar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvDados
      // 
      this.dgvDados.AllowUserToAddRows = false;
      this.dgvDados.AllowUserToDeleteRows = false;
      this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      resources.ApplyResources(this.dgvDados, "dgvDados");
      this.dgvDados.Name = "dgvDados";
      this.dgvDados.ReadOnly = true;
      this.dgvDados.RowHeadersVisible = false;
      this.dgvDados.RowTemplate.Height = 28;
      this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
      // 
      // txtNomeTipoDePagamento
      // 
      resources.ApplyResources(this.txtNomeTipoDePagamento, "txtNomeTipoDePagamento");
      this.txtNomeTipoDePagamento.Name = "txtNomeTipoDePagamento";
      // 
      // lblTipoDePagamento
      // 
      resources.ApplyResources(this.lblTipoDePagamento, "lblTipoDePagamento");
      this.lblTipoDePagamento.Name = "lblTipoDePagamento";
      // 
      // btnLocalizar
      // 
      resources.ApplyResources(this.btnLocalizar, "btnLocalizar");
      this.btnLocalizar.Name = "btnLocalizar";
      this.btnLocalizar.UseVisualStyleBackColor = true;
      this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
      // 
      // frmPesquisarTipoDePagamento
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnLocalizar);
      this.Controls.Add(this.dgvDados);
      this.Controls.Add(this.txtNomeTipoDePagamento);
      this.Controls.Add(this.lblTipoDePagamento);
      this.Name = "frmPesquisarTipoDePagamento";
      this.Load += new System.EventHandler(this.frmPesquisarTipoDePagamento_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvDados;
    private System.Windows.Forms.TextBox txtNomeTipoDePagamento;
    private System.Windows.Forms.Label lblTipoDePagamento;
    private System.Windows.Forms.Button btnLocalizar;
  }
}