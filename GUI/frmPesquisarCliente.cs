using BLL;
using DAL;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Consts.Constantes; 

namespace GUI
{
  public partial class frmPesquisarCliente : Form
  {
    public int codigo;

    public frmPesquisarCliente()
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

    public BLLCliente QueryDB
    {
      get
      {
        if (_queryDB == null)
          _queryDB = new BLLCliente(Conexao);
        return _queryDB;
      }
    }
    private BLLCliente _queryDB = null;

    private void frmPesquisarCliente_Load(object sender, EventArgs e)
    {
      BackColor = Color.LightBlue;
      btnLocalizar.Enabled = false;
      rbNomeCliente.Checked = true;

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

      dgvDados.Columns[2].HeaderText = "CPF/CNPJ";
      dgvDados.Columns[2].Width = 100;
      dgvDados.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[3].HeaderText = "RG/Inscrição Estadual";
      dgvDados.Columns[3].Width = 110;
      dgvDados.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[4].HeaderText = "Razão Social";
      dgvDados.Columns[4].Width = 150;
      dgvDados.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;        

      dgvDados.Columns[5].HeaderText = "Tipo";
      dgvDados.Columns[5].Width = 50;
      dgvDados.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[6].HeaderText = "CEP";
      dgvDados.Columns[6].Width = 50;
      dgvDados.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[7].HeaderText = "Endereço";
      dgvDados.Columns[7].Width = 150;
      dgvDados.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[8].HeaderText = "Bairro";
      dgvDados.Columns[8].Width = 100;
      dgvDados.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[9].HeaderText = "Telefone";
      dgvDados.Columns[9].Width = 100;
      dgvDados.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[10].HeaderText = "Celular";
      dgvDados.Columns[10].Width = 100;
      dgvDados.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[11].HeaderText = "Email";
      dgvDados.Columns[11].Width = 100;
      dgvDados.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[12].HeaderText = "Numero";
      dgvDados.Columns[12].Width = 50;
      dgvDados.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[13].HeaderText = "Cidade";
      dgvDados.Columns[13].Width = 100;
      dgvDados.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[14].HeaderText = "Estado";
      dgvDados.Columns[14].Width = 100;
      dgvDados.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
    }
    public void ConfiguraVisibilidadeGrid()
    {
      dgvDados.Columns["CLI_TIPO"].Visible = false;      
    }
    private void TrataPesquisaPorCPF()
    {
      if (rbCpfCliente.Checked == true && txtValorPesquisaCliente.TextLength < 11)
        btnLocalizar.Enabled = false;

      if (rbCpfCliente.Checked == true && txtValorPesquisaCliente.TextLength == 11)
      {
        btnLocalizar.Enabled = true;
        txtValorPesquisaCliente.MaxLength = 11;
      }

      if (rbCpfCliente.Checked == true && txtValorPesquisaCliente.TextLength > 11)
        txtValorPesquisaCliente.Clear();
    }
    private void TrataPesquisaPorCNPJ()
    {
      if (rbCnpjCliente.Checked == true && txtValorPesquisaCliente.TextLength < 14)
      {
        btnLocalizar.Enabled = false;
        txtValorPesquisaCliente.MaxLength = 14;
      }

      if (rbCnpjCliente.Checked == true && txtValorPesquisaCliente.TextLength == 14)
      {
        btnLocalizar.Enabled = true;
        txtValorPesquisaCliente.MaxLength = 14;
      }

      if (rbCnpjCliente.Checked == true && txtValorPesquisaCliente.TextLength > 14)
        txtValorPesquisaCliente.Clear();
    }
    private void TrataPesquisaPorNome()
    {
      if (rbNomeCliente.Checked == true && txtValorPesquisaCliente.TextLength > 3)
      {
        btnLocalizar.Enabled = true;
        txtValorPesquisaCliente.MaxLength = 50;
      }
    }
    #endregion


    private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
        this.Close();
      }
    }

    private void btnLocalizar_Click(object sender, EventArgs e)
    {
      if (rbNomeCliente.Checked == true)
        dgvDados.DataSource = QueryDB.LocalizarCliente(Convert.ToInt32(TipoPesquisaCliente.Nome), txtValorPesquisaCliente.Text); 
      else
        dgvDados.DataSource = QueryDB.LocalizarCliente(Convert.ToInt32(TipoPesquisaCliente.CPF_CNPJ), txtValorPesquisaCliente.Text);

    }

    private void txtValorPesquisaCliente_TextChanged(object sender, EventArgs e)
    {
      if (txtValorPesquisaCliente.TextLength <= 0)
        btnLocalizar.Enabled = false;

      TrataPesquisaPorCPF();
      TrataPesquisaPorCNPJ();
      TrataPesquisaPorNome();

      
    }
  }
}
