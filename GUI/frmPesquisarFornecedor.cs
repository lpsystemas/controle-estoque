using BLL;
using DAL;
using Ferramentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ConstsEnumerados.Enumerados;

namespace GUI
{
    public partial class frmPesquisarFornecedor : Form
    {
        public int codigo;

        public frmPesquisarFornecedor()
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

        public BLLFornecedor QueryDB
        {
            get
            {
                if (_queryDB == null)
                    _queryDB = new BLLFornecedor(Conexao);
                return _queryDB;
            }
        }
        private BLLFornecedor _queryDB = null;

        private void frmPesquisarFornecedor_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
            btnLocalizar.Enabled = false;
            rbNomeFornecedor.Checked = true;

            btnLocalizar_Click(sender, e);
            ConfiguraColunasGrid();            
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

            dgvDados.Columns[2].HeaderText = "CNPJ";
            dgvDados.Columns[2].Width = 100;
            dgvDados.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDados.Columns[3].HeaderText = "Inscrição Estadual";
            dgvDados.Columns[3].Width = 110;
            dgvDados.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDados.Columns[4].HeaderText = "Razão Social";
            dgvDados.Columns[4].Width = 150;
            dgvDados.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDados.Columns[5].HeaderText = "CEP";
            dgvDados.Columns[5].Width = 50;
            dgvDados.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDados.Columns[6].HeaderText = "Endereço";
            dgvDados.Columns[6].Width = 150;
            dgvDados.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDados.Columns[7].HeaderText = "Bairro";
            dgvDados.Columns[7].Width = 100;
            dgvDados.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDados.Columns[8].HeaderText = "Telefone";
            dgvDados.Columns[8].Width = 100;
            dgvDados.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDados.Columns[9].HeaderText = "Celular";
            dgvDados.Columns[9].Width = 100;
            dgvDados.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDados.Columns[10].HeaderText = "Email";
            dgvDados.Columns[10].Width = 100;
            dgvDados.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDados.Columns[11].HeaderText = "Numero";
            dgvDados.Columns[11].Width = 50;
            dgvDados.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDados.Columns[12].HeaderText = "Cidade";
            dgvDados.Columns[12].Width = 100;
            dgvDados.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDados.Columns[13].HeaderText = "Estado";
            dgvDados.Columns[13].Width = 100;
            dgvDados.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }       
        private void HabilitaBotaoLocalizar()
        {
            if (rbCnpjFornecedor.Checked == true && txtValorPesquisaFornecedor.TextLength == 18)
                btnLocalizar.Enabled = true;

            if (rbNomeFornecedor.Checked == true && txtValorPesquisaFornecedor.TextLength > 3)
            {
                btnLocalizar.Enabled = true;
                txtValorPesquisaFornecedor.MaxLength = 50;
            }
        }

        private void LimpaCampoPesquisa()
        {
            txtValorPesquisaFornecedor.Clear();
        }
        #endregion

        private void txtValorPesquisaFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                if(rbCnpjFornecedor.Checked)
                {
                    if (!char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        MessageBox.Show("Com o tipo de pesquisa marcado como CNPJ, o campo VALOR aceita somente numeros");
                    }

                    CampoParaFormatacao campo = CampoParaFormatacao.CNPJ;
                    FormataMascaraDeCampos.FormataMascaraCampoCpfCnpj(campo, txtValorPesquisaFornecedor);
                }
                
            }

            if (string.IsNullOrEmpty(txtValorPesquisaFornecedor.Text))
                lblMsgConsistCnpj.Visible = false;
        }

        private void txtValorPesquisaFornecedor_Leave(object sender, EventArgs e)
        {
            if (rbCnpjFornecedor.Checked == true && !string.IsNullOrEmpty(txtValorPesquisaFornecedor.Text))
                lblMsgConsistCnpj.Visible = true ? !Validacao.ValidaCnpj(txtValorPesquisaFornecedor.Text) : lblMsgConsistCnpj.Visible = false;
        }

        private void txtValorPesquisaFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (txtValorPesquisaFornecedor.TextLength <= 0)
                btnLocalizar.Enabled = false;

            HabilitaBotaoLocalizar();
        }

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
            if (rbNomeFornecedor.Checked == true)
                dgvDados.DataSource = QueryDB.LocalizarFornecedor(Convert.ToInt32(TipoPesquisa.NOME), txtValorPesquisaFornecedor.Text);            

            if (rbCnpjFornecedor.Checked == true)
                dgvDados.DataSource = QueryDB.LocalizarFornecedor(Convert.ToInt32(TipoPesquisa.CPNJ), txtValorPesquisaFornecedor.Text);
        }

        private void rbNomeFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            LimpaCampoPesquisa();
            lblMsgConsistCnpj.Visible = false;
        }

        private void rbCnpjFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            LimpaCampoPesquisa();
            lblMsgConsistCnpj.Visible = false;
        }
    }
}
