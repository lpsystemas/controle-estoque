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
  public partial class frmPesquisarTipoDePagamento : Form
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

    public BLLTipoPagamento QueryDB
    {
      get
      {
        if (_queryDB == null)
          _queryDB = new BLLTipoPagamento(Conexao);
        return _queryDB;
      }
    }
    private BLLTipoPagamento _queryDB = null;

    public frmPesquisarTipoDePagamento()
    {
      InitializeComponent();
    }

    private void btnLocalizar_Click(object sender, EventArgs e)
    {
      dgvDados.DataSource = QueryDB.LocalizarTipoDePagamento(Convert.ToString(txtNomeTipoDePagamento.Text));
    }

    private void frmPesquisarTipoDePagamento_Load(object sender, EventArgs e)
    {
      btnLocalizar_Click(sender, e);

      dgvDados.Columns[0].HeaderText = "Código do Tipo de Pagamento";
      dgvDados.Columns[0].Width = 54;
      dgvDados.Columns[1].HeaderText = "Nome do Tipo de Pagamento";
      dgvDados.Columns[1].Width = 400;
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
