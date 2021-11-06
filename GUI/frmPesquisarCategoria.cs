using BLL;
using DAL;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace GUI
{
  public partial class frmPesquisarCategoria : Form
  {
    public int codigo = 0;

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

    public BLLCategoria QueryDB
    {
      get
      {
        if (_queryDB == null)
          _queryDB = new BLLCategoria(Conexao);
        return _queryDB;
      }
    }
    private BLLCategoria _queryDB = null;

    public frmPesquisarCategoria()
    {
      InitializeComponent();
    }
    
    private void btnLocalizar_Click(object sender, EventArgs e)
    {
      dgvDados.DataSource = QueryDB.LocalizarCategoria(Convert.ToString(txtNomeCategoria.Text));    
    }

    private void frmPesquisarCategoria_Load(object sender, EventArgs e)
    {
            BackColor = Color.LightBlue;
            btnLocalizar_Click(sender, e);
            ConfiguraColunasGrid();
    }

    private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if(e.RowIndex >= 0)
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
            dgvDados.Columns[1].HeaderText = "Categoria";
            dgvDados.Columns[1].Width = 400;
        }
        #endregion
    }
}
