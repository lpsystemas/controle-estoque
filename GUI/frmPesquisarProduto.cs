using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace GUI
{
  public partial class frmPesquisarProduto : Form
  {
    public int codigo;

    public frmPesquisarProduto()
    {
      InitializeComponent();
    }

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

    private void frmPesquisarProduto_Load(object sender, EventArgs e)
    {
      BackColor = Color.LightBlue;
      btnLocalizar_Click(sender, e);
      ConfiguraColunasGrid();
      ConfiguraVisibilidadeGrid();
    }

    #region Metodos Auxiliares

    public void ConfiguraColunasGrid()
    {

      dgvDados.RowsDefaultCellStyle.BackColor = Color.White;
      dgvDados.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
      dgvDados.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

      foreach (DataGridViewColumn colunas in dgvDados.Columns)
        colunas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[0].HeaderText = "Código";
      dgvDados.Columns[0].Width = 50;
      dgvDados.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[1].HeaderText = "Nome";
      dgvDados.Columns[1].Width = 150;
      dgvDados.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[2].HeaderText = "Descrição";
      dgvDados.Columns[2].Width = 150;
      dgvDados.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[3].HeaderText = "Foto";
      dgvDados.Columns[3].Width = 50;
      dgvDados.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[4].HeaderText = "Valor Pago";
      dgvDados.Columns[4].Width = 100;
      dgvDados.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[5].HeaderText = "Valor de Venda";
      dgvDados.Columns[5].Width = 130;
      dgvDados.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[6].HeaderText = "Quantidade";
      dgvDados.Columns[6].Width = 100;
      dgvDados.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[7].HeaderText = "Cod. Und. Medida";
      dgvDados.Columns[7].Width = 50;
      dgvDados.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[8].HeaderText = "Und. Medida";
      dgvDados.Columns[8].Width = 100;
      dgvDados.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[9].HeaderText = "Cod. Categoria";
      dgvDados.Columns[9].Width = 50;
      dgvDados.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[10].HeaderText = "Categoria";
      dgvDados.Columns[10].Width = 100;
      dgvDados.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[11].HeaderText = "Cod Subcategoria";
      dgvDados.Columns[11].Width = 50;
      dgvDados.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[12].HeaderText = "Subcategoria";
      dgvDados.Columns[12].Width = 100;
      dgvDados.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
    }

    public void ConfiguraVisibilidadeGrid()
    {
      dgvDados.Columns["PRO_FOTO"].Visible = false;
      dgvDados.Columns["PRO_VALORPAGO"].Visible = false;
      dgvDados.Columns["UMED_COD"].Visible = false;
      dgvDados.Columns["CAT_COD"].Visible = false;
      dgvDados.Columns["SCAT_COD"].Visible = false;
    }

    #endregion

    private void btnLocalizar_Click(object sender, EventArgs e)
    {
      dgvDados.DataSource = QueryDB.LocalizarProduto(txtNomeProduto.Text);
    }

    private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
        this.Close();
      }
    }
  }
}
