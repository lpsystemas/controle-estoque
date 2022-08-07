using BLL.Util;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public BLLUtils Utils
        {
            get
            {
                if (_utils == null)
                    _utils = new BLLUtils();
                return _utils;
            }
        }
        private BLLUtils _utils = null;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmCadastroCategoria frmCategoria = new frmCadastroCategoria())
            {
                frmCategoria.ShowDialog();
            }
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmPesquisarCategoria pesquisar = new frmPesquisarCategoria())
            {
                pesquisar.ShowDialog();
            }
        }

        private void subToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmCadastroSubCategoria frmSubCategoria = new frmCadastroSubCategoria())
            {
                frmSubCategoria.ShowDialog();
            }
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmPesquisarSubCategoria pesquisar = new frmPesquisarSubCategoria())
            {
                pesquisar.ShowDialog();
            }
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmCadastroUnidadeDeMedida frmUmed = new frmCadastroUnidadeDeMedida())
            {
                frmUmed.ShowDialog();
            }
        }

        private void unidadeDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmPesquisarUnidadeDeMedida pesquisar = new frmPesquisarUnidadeDeMedida())
            {
                pesquisar.ShowDialog();
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmCadastroProduto frmProduto = new frmCadastroProduto())
            {
                frmProduto.ShowDialog();
            }
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmPesquisarProduto pesquisar = new frmPesquisarProduto())
            {
                pesquisar.ShowDialog();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.ConfiguraFormulario();
            VerificaConexaoComBancoDeDados();
        }

        private void ConfiguraFormulario()
        {
            BackColor = Color.LightBlue;
            menuStripPrincipal.Font = new Font(MenuStrip.DefaultFont, FontStyle.Bold);
        }

        private void VerificaConexaoComBancoDeDados()
        {
            string message = @"Não foi possivel estabelecer uma conexão com o banco de dados.\n\n
                               Acesse [Ferramentas - Configurações de Banco de Dados] e informe os dados corretamente.";

            if (File.Exists("ConfiguracaoBancoDeDados.txt") && Utils.VerificaConexaoComArquivoDeConfigDB())
            {
                menuStripPrincipal.Items[0].Enabled = true;
                menuStripPrincipal.Items[1].Enabled = true;
                menuStripPrincipal.Items[2].Enabled = true;
                menuStripPrincipal.Items[3].Enabled = true;
                menuStripPrincipal.Items[5].Enabled = true;
            }
            else
            {
                menuStripPrincipal.Items[0].Enabled = false;
                menuStripPrincipal.Items[1].Enabled = false;
                menuStripPrincipal.Items[2].Enabled = false;
                menuStripPrincipal.Items[3].Enabled = false;
                menuStripPrincipal.Items[5].Enabled = false;

                MessageBox.Show(message);
            }
        }

        private void configuraçãoDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmConfiguracaoBancoDeDados frmConfigDB = new frmConfiguracaoBancoDeDados())
            {
                frmConfigDB.ShowDialog();
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmBackUpBancoDeDados frmBackupDB = new frmBackUpBancoDeDados())
            {
                frmBackupDB.ShowDialog();
            }
        }

        private void tipoDePagamentotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmCadastroTipoPagamento frmTipoPagto = new frmCadastroTipoPagamento())
            {
                frmTipoPagto.ShowDialog();
            }
        }

        private void tPagtotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmPesquisarTipoDePagamento frmTipoPagto = new frmPesquisarTipoDePagamento())
            {
                frmTipoPagto.ShowDialog();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmCadastroCliente frmCliente = new frmCadastroCliente())
            {
                frmCliente.ShowDialog();
            }
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmPesquisarCliente pesquisar = new frmPesquisarCliente())
            {
                pesquisar.ShowDialog();
            }
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmCadastroFornecedor frmFornecedor = new frmCadastroFornecedor())
            {
                frmFornecedor.ShowDialog();
            }

        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmPesquisarFornecedor pesquisar = new frmPesquisarFornecedor())
            {
                pesquisar.ShowDialog();
            }
        }
    }
}
