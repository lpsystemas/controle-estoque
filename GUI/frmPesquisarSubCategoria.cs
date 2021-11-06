using BLL;
using DAL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
  public partial class frmPesquisarSubCategoria : Form
  {
    public int codigo = 0;
    public frmPesquisarSubCategoria()
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

    public BLLSubCategoria QueryDB
    {
      get
      {
        if (_queryDB == null)
          _queryDB = new BLLSubCategoria(Conexao);
        return _queryDB;
      }
    }
    private BLLSubCategoria _queryDB = null;

    private void frmPesquisarSubCategoria_Load(object sender, EventArgs e)
    {
            BackColor = Color.LightBlue;
            btnLocalizar_Click(sender, e);
            ConfiguraColunasGrid();      
    }

    private void btnLocalizar_Click(object sender, EventArgs e)
    {
      dgvDados.DataSource =  QueryDB.LocalizarSubCategoria(txtNomeSubCategoria.Text);
    }

    private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
        this.Close();
      }
    }

        #region Metodos Auxiliares

        private void ConfiguraColunasGrid()
        {
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 60;
            dgvDados.Columns[1].HeaderText = "Nome";
            dgvDados.Columns[1].Width = 400;
            dgvDados.Columns[2].HeaderText = "Cod. Categoria";
            dgvDados.Columns[2].Width = 60;
            dgvDados.Columns[3].HeaderText = "Categoria";
            dgvDados.Columns[3].Width = 400;
        }
        #endregion
    }
}
