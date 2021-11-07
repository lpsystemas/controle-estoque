
namespace GUI
{
  partial class frmBackUpBancoDeDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackUpBancoDeDados));
            this.btnBackUpBanco = new System.Windows.Forms.Button();
            this.btnRestaurarBanco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackUpBanco
            // 
            resources.ApplyResources(this.btnBackUpBanco, "btnBackUpBanco");
            this.btnBackUpBanco.Name = "btnBackUpBanco";
            this.btnBackUpBanco.UseVisualStyleBackColor = true;
            this.btnBackUpBanco.Click += new System.EventHandler(this.btnBackUpBanco_Click);
            // 
            // btnRestaurarBanco
            // 
            resources.ApplyResources(this.btnRestaurarBanco, "btnRestaurarBanco");
            this.btnRestaurarBanco.Name = "btnRestaurarBanco";
            this.btnRestaurarBanco.UseVisualStyleBackColor = true;
            this.btnRestaurarBanco.Click += new System.EventHandler(this.btnRestaurarBanco_Click);
            // 
            // frmBackUpBancoDeDados
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRestaurarBanco);
            this.Controls.Add(this.btnBackUpBanco);
            this.Name = "frmBackUpBancoDeDados";
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnBackUpBanco;
    private System.Windows.Forms.Button btnRestaurarBanco;
  }
}