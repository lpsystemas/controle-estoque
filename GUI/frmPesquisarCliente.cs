using BLL;
using DAL;
using Ferramentas;
using System;
using System.Drawing;
using System.Windows.Forms;
using static ConstsEnumerados.Enumerados; 

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
      rbNomeCliente.Checked = true;
      btnLocalizar.Enabled = false;
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
      dgvDados.Columns[0].Width = 60;
      dgvDados.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[1].HeaderText = "Nome";
      dgvDados.Columns[1].Width = 200;
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
      dgvDados.Columns[5].Width = 60;
      dgvDados.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[6].HeaderText = "CEP";
      dgvDados.Columns[6].Width = 60;
      dgvDados.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgvDados.Columns[7].HeaderText = "Endereço";
      dgvDados.Columns[7].Width = 200;
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
      dgvDados.Columns[12].Width = 60;
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
    
        private void HabilitaBotaoLocalizar()
        {
            if (rbCpfCliente.Checked == true && txtValorPesquisaCliente.TextLength == 14)
                btnLocalizar.Enabled = true;

            if (rbCnpjCliente.Checked == true && txtValorPesquisaCliente.TextLength == 18)
                btnLocalizar.Enabled = true;

            if (rbNomeCliente.Checked == true && txtValorPesquisaCliente.TextLength > 3)
            {
                btnLocalizar.Enabled = true;
                txtValorPesquisaCliente.MaxLength = 50;
            }
        }

        private void LimpaCampoPesquisa()
        {
            txtValorPesquisaCliente.Clear();          
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
      if(rbNomeCliente.Checked == true)
        dgvDados.DataSource = QueryDB.LocalizarCliente(Convert.ToInt32(TipoPesquisa.NOME), txtValorPesquisaCliente.Text); 
      
      if(rbCpfCliente.Checked == true)
        dgvDados.DataSource = QueryDB.LocalizarCliente(Convert.ToInt32(TipoPesquisa.CPF), txtValorPesquisaCliente.Text);

      if (rbCnpjCliente.Checked == true)
        dgvDados.DataSource = QueryDB.LocalizarCliente(Convert.ToInt32(TipoPesquisa.CPNJ), txtValorPesquisaCliente.Text);
    }

    private void txtValorPesquisaCliente_TextChanged(object sender, EventArgs e)
    {
            
            if (txtValorPesquisaCliente.TextLength <= 0)
                btnLocalizar.Enabled = false;

            if (string.IsNullOrEmpty(txtValorPesquisaCliente.Text) || txtValorPesquisaCliente.TextLength <= 0)
                lblMsgConsisteCpfCnpj.Visible = false;

            HabilitaBotaoLocalizar();            
    }

        private void txtValorPesquisaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                CampoParaFormatacao campo;

                if (rbCpfCliente.Checked)
                {
                    if (!char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        MessageBox.Show("Com o tipo de pesquisa marcado como CPF, o campo VALOR aceita somente numeros");                        
                    }                    

                    campo = CampoParaFormatacao.CPF;
                    FormataMascaraDeCampos.FormataMascaraCampoCpfCnpj(campo, txtValorPesquisaCliente);
                }                    

                if (rbCnpjCliente.Checked)
                {
                    if (!char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        MessageBox.Show("Com o tipo de pesquisa marcado como CNPJ, o campo VALOR aceita somente numeros");                        
                    }                         

                    campo = CampoParaFormatacao.CNPJ;
                    FormataMascaraDeCampos.FormataMascaraCampoCpfCnpj(campo, txtValorPesquisaCliente);
                } 
            }            
        }

        private void txtValorPesquisaCliente_Leave(object sender, EventArgs e)
        {
            if (rbCpfCliente.Checked == true && !string.IsNullOrEmpty(txtValorPesquisaCliente.Text))
                lblMsgConsisteCpfCnpj.Visible = true ? !Validacao.ValidaCpf(txtValorPesquisaCliente.Text) : lblMsgConsisteCpfCnpj.Visible = false;

            if (rbCnpjCliente.Checked == true && !string.IsNullOrEmpty(txtValorPesquisaCliente.Text))
                lblMsgConsisteCpfCnpj.Visible = true ? !Validacao.ValidaCnpj(txtValorPesquisaCliente.Text) : lblMsgConsisteCpfCnpj.Visible = false;
        }

        private void rbCnpjCliente_CheckedChanged(object sender, EventArgs e)
        {
            LimpaCampoPesquisa();
            lblMsgConsisteCpfCnpj.Visible = false;
        }

        private void rbCpfCliente_CheckedChanged(object sender, EventArgs e)
        {
            LimpaCampoPesquisa();
            lblMsgConsisteCpfCnpj.Visible = false;
        }

        private void rbNomeCliente_CheckedChanged(object sender, EventArgs e)
        {
            LimpaCampoPesquisa();
            lblMsgConsisteCpfCnpj.Visible = false;

        }
    }
}
