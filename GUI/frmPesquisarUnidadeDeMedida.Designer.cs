namespace GUI
{
  partial class frmPesquisarUnidadeDeMedida
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarUnidadeDeMedida));
      this.btnLocalizar = new System.Windows.Forms.Button();
      this.txtNomeUmed = new System.Windows.Forms.TextBox();
      this.lblUnidadeMedida = new System.Windows.Forms.Label();
      this.dgvDados = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
      this.SuspendLayout();
      // 
      // btnLocalizar
      // 
      resources.ApplyResources(this.btnLocalizar, "btnLocalizar");
      this.btnLocalizar.Name = "btnLocalizar";
      this.btnLocalizar.UseVisualStyleBackColor = true;
      this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
      // 
      // txtNomeUmed
      // 
      resources.ApplyResources(this.txtNomeUmed, "txtNomeUmed");
      this.txtNomeUmed.Name = "txtNomeUmed";
      // 
      // lblUnidadeMedida
      // 
      resources.ApplyResources(this.lblUnidadeMedida, "lblUnidadeMedida");
      this.lblUnidadeMedida.Name = "lblUnidadeMedida";
      // 
      // dgvDados
      // 
      this.dgvDados.AllowUserToAddRows = false;
      this.dgvDados.AllowUserToDeleteRows = false;
      this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      resources.ApplyResources(this.dgvDados, "dgvDados");
      this.dgvDados.Name = "dgvDados";
      this.dgvDados.ReadOnly = true;
      this.dgvDados.RowTemplate.Height = 28;
      this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
      // 
      // frmPesquisarUnidadeDeMedida
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dgvDados);
      this.Controls.Add(this.btnLocalizar);
      this.Controls.Add(this.txtNomeUmed);
      this.Controls.Add(this.lblUnidadeMedida);
      this.Name = "frmPesquisarUnidadeDeMedida";
      this.Load += new System.EventHandler(this.frmPesquisarUnidadeDeMedida_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnLocalizar;
    private System.Windows.Forms.TextBox txtNomeUmed;
    private System.Windows.Forms.Label lblUnidadeMedida;
    private System.Windows.Forms.DataGridView dgvDados;
  }
}