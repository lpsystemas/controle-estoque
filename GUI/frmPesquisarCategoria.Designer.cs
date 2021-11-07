namespace GUI
{
  partial class frmPesquisarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarCategoria));
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            resources.ApplyResources(this.lblCategoria, "lblCategoria");
            this.lblCategoria.Name = "lblCategoria";
            // 
            // txtNomeCategoria
            // 
            resources.ApplyResources(this.txtNomeCategoria, "txtNomeCategoria");
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            // 
            // btnLocalizar
            // 
            resources.ApplyResources(this.btnLocalizar, "btnLocalizar");
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
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
            // frmPesquisarCategoria
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Name = "frmPesquisarCategoria";
            this.Load += new System.EventHandler(this.frmPesquisarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblCategoria;
    private System.Windows.Forms.TextBox txtNomeCategoria;
    private System.Windows.Forms.Button btnLocalizar;
    private System.Windows.Forms.DataGridView dgvDados;
  }
}