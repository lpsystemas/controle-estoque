using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
  public partial class frmPesquisarUnidadeDeMedida : Form
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

    public BLLUnidadeDeMedida QueryDB
    {
      get
      {
        if (_queryDB == null)
          _queryDB = new BLLUnidadeDeMedida(Conexao);
        return _queryDB;
      }
    }
    private BLLUnidadeDeMedida _queryDB = null;

    public frmPesquisarUnidadeDeMedida()
    {
      InitializeComponent();
    }
    
    private void frmPesquisarUnidadeDeMedida_Load(object sender, EventArgs e)
    {
            BackColor = Color.LightBlue;
            btnLocalizar_Click(sender, e);
            ConfiguraColunasGrid();
    }

    private void btnLocalizar_Click(object sender, EventArgs e)
    {
      dgvDados.DataSource = QueryDB.LocalizarUnidadeDeMedida(txtNomeUmed.Text);
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
            dgvDados.Columns[1].HeaderText = "Unidade de Medida";
            dgvDados.Columns[1].Width = 400;
        }
        #endregion
    }
}
