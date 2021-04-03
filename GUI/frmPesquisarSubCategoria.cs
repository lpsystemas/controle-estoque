using BLL;
using DAL;
using System;
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
      btnLocalizar_Click(sender, e);
      
      dgvDados.Columns[0].HeaderText = "Código da SubCategoria";
      dgvDados.Columns[0].Width = 150;
      dgvDados.Columns[1].HeaderText = "Nome da SubCategoria";
      dgvDados.Columns[1].Width = 200;
      dgvDados.Columns[2].HeaderText = "Código da Categoria";
      dgvDados.Columns[2].Width = 150;
      dgvDados.Columns[3].HeaderText = "Nome da Categoria";
      dgvDados.Columns[3].Width = 200;
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
  }
}
