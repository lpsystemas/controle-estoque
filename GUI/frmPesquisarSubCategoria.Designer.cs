namespace GUI
{
  partial class frmPesquisarSubCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarSubCategoria));
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.txtNomeSubCategoria = new System.Windows.Forms.TextBox();
            this.lblSubCategoria = new System.Windows.Forms.Label();
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
            // btnLocalizar
            // 
            resources.ApplyResources(this.btnLocalizar, "btnLocalizar");
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtNomeSubCategoria
            // 
            resources.ApplyResources(this.txtNomeSubCategoria, "txtNomeSubCategoria");
            this.txtNomeSubCategoria.Name = "txtNomeSubCategoria";
            // 
            // lblSubCategoria
            // 
            resources.ApplyResources(this.lblSubCategoria, "lblSubCategoria");
            this.lblSubCategoria.Name = "lblSubCategoria";
            // 
            // frmPesquisarSubCategoria
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.txtNomeSubCategoria);
            this.Controls.Add(this.lblSubCategoria);
            this.Name = "frmPesquisarSubCategoria";
            this.Load += new System.EventHandler(this.frmPesquisarSubCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvDados;
    private System.Windows.Forms.Button btnLocalizar;
    private System.Windows.Forms.TextBox txtNomeSubCategoria;
    private System.Windows.Forms.Label lblSubCategoria;
  }
}