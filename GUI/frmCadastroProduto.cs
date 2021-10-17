using BLL;
using DAL;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static Consts.Constantes;

namespace GUI
{
  public partial class frmCadastroProduto : GUI.frmModeloDeFormularioDeCadastro
  {
    private const string Inserir = "Inserir";
    private const string Alterar = "Alterar";
    private const string Excluir = "Excluir";   
    public string foto = string.Empty;

    public DALConexao Conexao
    {
      get
      {
        if (_conexao == null)
          _conexao = new DALConexao(DadosDaConexao.StringDeConexao);
        return _conexao;
      }
    }
    private DALConexao _conexao = null;

    public BLLProduto QueryDB
    {
      get
      {
        if (_queryDB == null)
          _queryDB = new BLLProduto(Conexao);
        return _queryDB;
      }
    }
    private BLLProduto _queryDB = null;

    public frmCadastroProduto()
    {
      InitializeComponent();
    }

    public void LimparDadosDaTela()
    {
      txtCodigoPrd.Clear();
      txtNomePrd.Clear();
      txtDescricaoPrd.Clear();
      txtValorPagoPrd.Clear();
      txtValorVendaPrd.Clear();
      txtQuantidadePrd.Clear();
      this.RemoverFoto();      
    }

    private void btnInserir_Click(object sender, EventArgs e)
    {
      this.operacao = Inserir;

      if (string.IsNullOrEmpty(txtValorPagoPrd.Text))
        txtValorPagoPrd.Text = "0,00";

      if (string.IsNullOrEmpty(txtValorVendaPrd.Text))
        txtValorVendaPrd.Text = "0,00";

      if (string.IsNullOrEmpty(txtQuantidadePrd.Text))
        txtQuantidadePrd.Text = "0,00";

      this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Salvar_Cancelar));
    }

    private void btnLocalizar_Click(object sender, EventArgs e)
    {
      using (frmPesquisarProduto pesquisar = new frmPesquisarProduto())
      {
        pesquisar.ShowDialog();

        if (pesquisar.codigo != 0)
        {
          ModeloProduto modeloProduto = QueryDB.CarregaProduto(pesquisar.codigo);

          txtCodigoPrd.Text = Convert.ToString(modeloProduto.ProdCod);
          txtNomePrd.Text = modeloProduto.ProdNome;
          txtDescricaoPrd.Text = modeloProduto.ProdDesc;
          txtValorPagoPrd.Text = Convert.ToString(modeloProduto.ProdValorPago);
          txtValorVendaPrd.Text = Convert.ToString(modeloProduto.ProdValorVenda);
          txtQuantidadePrd.Text = Convert.ToString(modeloProduto.ProdQuantidade);
          cboCatPrd.SelectedValue = modeloProduto.CatCod;
          cboSubCatPrd.SelectedValue = modeloProduto.SCatCod;
          cboUmedPrd.SelectedValue = modeloProduto.UmedCod;
          
          if(modeloProduto.ProdFoto != null)
          {
            this.foto = Alterar;
            pbFotoPrd.Image = Image.FromStream(new MemoryStream(modeloProduto.ProdFoto));
          }
            

          //this.txtQuantidadePrd_Leave(sender, e);
          this.txtValorVendaPrd_Leave(sender, e);
          this.txtValorPagoPrd_Leave(sender, e);

          this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Alterar_Excluir_Cancelar));
        }
        else
        {
          this.LimparDadosDaTela();
          this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
        }
      }
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
      this.operacao = Alterar;

      this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Salvar_Cancelar));
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      try
      {
        DialogResult exclusao = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

        if (exclusao.ToString() == "Yes")
        {
          QueryDB.ExcluirProduto(Convert.ToInt32(txtCodigoPrd.Text));

          LimparDadosDaTela();
          AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
        }
      }
      catch
      {
        MessageBox.Show("Impossivél excluir o registro. \nO registro está sendo utilizado em outro local.");
        this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Alterar_Excluir_Cancelar));
      }
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      try
      {
        ModeloProduto modeloProduto = new ModeloProduto();

        modeloProduto.ProdNome = txtNomePrd.Text;
        modeloProduto.ProdDesc = txtDescricaoPrd.Text;
        modeloProduto.ProdValorPago = Convert.ToDouble(txtValorPagoPrd.Text);
        modeloProduto.ProdValorVenda = Convert.ToDouble(txtValorVendaPrd.Text);
        modeloProduto.ProdQuantidade = Convert.ToDouble(txtQuantidadePrd.Text);
        modeloProduto.CatCod = Convert.ToInt32(cboCatPrd.SelectedValue);
        modeloProduto.SCatCod = Convert.ToInt32(cboSubCatPrd.SelectedValue);
        modeloProduto.UmedCod = Convert.ToInt32(cboUmedPrd.SelectedValue);         

        if (this.operacao == Inserir)
        {
          modeloProduto.CarregaImagem(this.foto);

          QueryDB.IncluirProduto(modeloProduto, operacao);
          MessageBox.Show("Cadastro efetuado com sucesso!! \nCódigo: " + modeloProduto.ProdCod.ToString());
        }
        else
        {
          modeloProduto.ProdCod = Convert.ToInt32(txtCodigoPrd.Text);

          if (this.foto == Alterar)
          {
            var modeloTemp = new ModeloProduto();
            modeloTemp = QueryDB.CarregaProduto(modeloProduto.ProdCod);
            modeloProduto.ProdFoto = modeloTemp.ProdFoto;
          }
          else
          {
            modeloProduto.CarregaImagem(this.foto);
          }          

          QueryDB.AlterarProduto(modeloProduto, operacao);
          MessageBox.Show("Cadastro alterado com sucesso!!");
        }

        this.LimparDadosDaTela();
        this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
      }
      catch (Exception Error)
      {
        MessageBox.Show(Error.Message);
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.LimparDadosDaTela();
      this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
    }

    private void frmCadastroProduto_Load(object sender, EventArgs e)
    {
      this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));

      this.ConfiguraComboBox();
    }

    private void txtValorPagoPrd_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
        e.Handled = true;

      if(e.KeyChar == ',' || e.KeyChar == '.')
      {
        if (!txtValorPagoPrd.Text.Contains(","))
          e.KeyChar = ',';
        else
          e.Handled = true;
      }

    }

    private void txtValorPagoPrd_Leave(object sender, EventArgs e)
    {
      if (txtValorPagoPrd.Text.Contains(",") == false)
        txtValorPagoPrd.Text += ",00";
      else
      {
        if (txtValorPagoPrd.Text.IndexOf(",") == txtValorPagoPrd.Text.Length - 1)
          txtValorPagoPrd.Text += "00";
      }

      try
      {
        double valor = Convert.ToDouble(txtValorPagoPrd.Text);
      }
      catch
      {
        txtValorPagoPrd.Text = "0,00";
      }
    }

    private void txtValorVendaPrd_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
        e.Handled = true;

      if (e.KeyChar == ',' || e.KeyChar == '.')
      {
        if (!txtValorVendaPrd.Text.Contains(","))
          e.KeyChar = ',';
        else
          e.Handled = true;
      }
    }

    private void txtValorVendaPrd_Leave(object sender, EventArgs e)
    {
      if (txtValorVendaPrd.Text.Contains(",") == false)
        txtValorVendaPrd.Text += ",00";
      else
      {
        if (txtValorVendaPrd.Text.IndexOf(",") == txtValorVendaPrd.Text.Length - 1)
          txtValorVendaPrd.Text += "00";
      }

      try
      {
        double valor = Convert.ToDouble(txtValorVendaPrd.Text);
      }
      catch
      {
        txtValorVendaPrd.Text = "0,00";
      }
    }

    private void txtQuantidadePrd_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
        e.Handled = true;

      if (e.KeyChar == ',' || e.KeyChar == '.')
      {
        if (!txtQuantidadePrd.Text.Contains(","))
          e.KeyChar = ',';
        else
          e.Handled = true;
      }
    }

    private void txtQuantidadePrd_Leave(object sender, EventArgs e)
    {
      if (txtQuantidadePrd.Text.Contains(",") == false)
        txtQuantidadePrd.Text += ",00";
      else
      {
        if (txtQuantidadePrd.Text.IndexOf(",") == txtQuantidadePrd.Text.Length - 1)
          txtQuantidadePrd.Text += "00";
      }

      try
      {
        double valor = Convert.ToDouble(txtQuantidadePrd.Text);
      }
      catch
      {
        txtQuantidadePrd.Text = "0,00";
      }
    }

    private void cboCatPrd_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        DataRowView categoria = (DataRowView)cboCatPrd.SelectedItem;
        cboSubCatPrd.Text = string.Empty;
        cboSubCatPrd.DisplayMember = "SCAT_NOME";
        cboSubCatPrd.ValueMember = "SCAT_COD";
        cboSubCatPrd.DataSource = QueryDB.Utils.CarregaComboBoxSubCategoriaPorCategoria(Convert.ToInt32(categoria.Row["CAT_COD"]));        
      }
      catch
      {

      }
    }

    private void btnCarregarFotoPrd_Click(object sender, EventArgs e)
    {
      OpenFileDialog imagem = new OpenFileDialog();
      imagem.ShowDialog();

      if(!string.IsNullOrEmpty(imagem.FileName))
      {
        this.foto = imagem.FileName;
        pbFotoPrd.Load(this.foto);
      }
    }

    private void btnRemoverFotoPrd_Click(object sender, EventArgs e)
    {
      this.RemoverFoto();
    }

    #region Metodos Auxiliares
    private void RemoverFoto()
    {
      this.foto = string.Empty;
      pbFotoPrd.Image = null;
    }

    private void ConfiguraComboBox()
    {
      //ComboBox Categoria
      cboCatPrd.DataSource = QueryDB.Utils.CarregaComboBoxCategoria();
      cboCatPrd.DisplayMember = "CAT_NOME";
      cboCatPrd.ValueMember = "CAT_COD";

      //ComboBox SubCategoria
      try
      {
        cboSubCatPrd.DisplayMember = "SCAT_NOME";
        cboSubCatPrd.ValueMember = "SCAT_COD";
        cboSubCatPrd.DataSource = QueryDB.Utils.CarregaComboBoxSubCategoriaPorCategoria(Convert.ToInt32(cboCatPrd.SelectedValue));
      }
      catch(Exception)
      {
        throw new WarningException("O combobox de categoria não pode ser vazio. Favor selecionar uma categoria.");
      }

      //ComboBox Unidade De Medida
      cboUmedPrd.DataSource = QueryDB.Utils.CarregaComboBoxUnidadeMedida();
      cboUmedPrd.DisplayMember = "UMED_NOME";
      cboUmedPrd.ValueMember = "UMED_COD";
    }

    #endregion

    private void btnNovaUndMed_Click(object sender, EventArgs e)
    {
      using (frmCadastroUnidadeDeMedida frmUmed = new frmCadastroUnidadeDeMedida())
      {
        frmUmed.ShowDialog();
        this.ConfiguraComboBox();
      }
    }

    private void btnNovaCategoria_Click(object sender, EventArgs e)
    {
      using (frmCadastroCategoria frmCategoria = new frmCadastroCategoria())
      {
        frmCategoria.ShowDialog();
        this.ConfiguraComboBox();
      }
    }

    private void btnNovaSubCategoria_Click(object sender, EventArgs e)
    {
      using (frmCadastroSubCategoria frmSubCategoria = new frmCadastroSubCategoria())
      {
        frmSubCategoria.ShowDialog();
        this.ConfiguraComboBox();
      }
    }
  }
}
