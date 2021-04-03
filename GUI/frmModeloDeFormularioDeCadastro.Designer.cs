namespace GUI
{
  partial class frmModeloDeFormularioDeCadastro
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModeloDeFormularioDeCadastro));
      this.pnDados = new System.Windows.Forms.Panel();
      this.pnBotoes = new System.Windows.Forms.Panel();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnSalvar = new System.Windows.Forms.Button();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.btnAlterar = new System.Windows.Forms.Button();
      this.btnLocalizar = new System.Windows.Forms.Button();
      this.btnInserir = new System.Windows.Forms.Button();
      this.pnBotoes.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnDados
      // 
      resources.ApplyResources(this.pnDados, "pnDados");
      this.pnDados.Name = "pnDados";
      // 
      // pnBotoes
      // 
      this.pnBotoes.Controls.Add(this.btnCancelar);
      this.pnBotoes.Controls.Add(this.btnSalvar);
      this.pnBotoes.Controls.Add(this.btnExcluir);
      this.pnBotoes.Controls.Add(this.btnAlterar);
      this.pnBotoes.Controls.Add(this.btnLocalizar);
      this.pnBotoes.Controls.Add(this.btnInserir);
      resources.ApplyResources(this.pnBotoes, "pnBotoes");
      this.pnBotoes.Name = "pnBotoes";
      // 
      // btnCancelar
      // 
      resources.ApplyResources(this.btnCancelar, "btnCancelar");
      this.btnCancelar.Image = global::GUI.Properties.Resources.Cancelar;
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      // 
      // btnSalvar
      // 
      resources.ApplyResources(this.btnSalvar, "btnSalvar");
      this.btnSalvar.Image = global::GUI.Properties.Resources.Salvar1_fw;
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.UseVisualStyleBackColor = true;
      // 
      // btnExcluir
      // 
      resources.ApplyResources(this.btnExcluir, "btnExcluir");
      this.btnExcluir.Image = global::GUI.Properties.Resources.Excluir;
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.UseVisualStyleBackColor = true;
      // 
      // btnAlterar
      // 
      resources.ApplyResources(this.btnAlterar, "btnAlterar");
      this.btnAlterar.Image = global::GUI.Properties.Resources.Alterar;
      this.btnAlterar.Name = "btnAlterar";
      this.btnAlterar.UseVisualStyleBackColor = true;
      // 
      // btnLocalizar
      // 
      resources.ApplyResources(this.btnLocalizar, "btnLocalizar");
      this.btnLocalizar.Image = global::GUI.Properties.Resources.localizar_fw;
      this.btnLocalizar.Name = "btnLocalizar";
      this.btnLocalizar.UseVisualStyleBackColor = true;
      // 
      // btnInserir
      // 
      resources.ApplyResources(this.btnInserir, "btnInserir");
      this.btnInserir.Image = global::GUI.Properties.Resources.Novo;
      this.btnInserir.Name = "btnInserir";
      this.btnInserir.UseVisualStyleBackColor = true;
      // 
      // frmModeloDeFormularioDeCadastro
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.pnBotoes);
      this.Controls.Add(this.pnDados);
      this.Name = "frmModeloDeFormularioDeCadastro";
      this.Load += new System.EventHandler(this.frmModeloDeFormularioDeCadastro_Load);
      this.pnBotoes.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    protected System.Windows.Forms.Panel pnDados;
    protected System.Windows.Forms.Panel pnBotoes;
    protected System.Windows.Forms.Button btnCancelar;
    protected System.Windows.Forms.Button btnSalvar;
    protected System.Windows.Forms.Button btnExcluir;
    protected System.Windows.Forms.Button btnAlterar;
    protected System.Windows.Forms.Button btnLocalizar;
    protected System.Windows.Forms.Button btnInserir;
  }
}