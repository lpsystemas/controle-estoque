using DAL;
using Ferramentas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBackUpBancoDeDados : Form
    {
        public frmBackUpBancoDeDados()
        {
            InitializeComponent();
        }

        private void btnBackUpBanco_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog salvarBackUp = new SaveFileDialog();

                salvarBackUp.Filter = "Backup Files |*.bak";
                salvarBackUp.ShowDialog();

                if (!string.IsNullOrEmpty(salvarBackUp.FileName))
                {
                    string nomeBanco = DadosDaConexao.banco;
                    string localBackup = salvarBackUp.FileName;
                    string stringConexao = string.Format(@"Data Source={0}; Initial Catalog=master; User={1}; Password={2}",
                                                           DadosDaConexao.servidor, DadosDaConexao.usuario, DadosDaConexao.senha);

                    SQLServerBackup.BackupDataBase(stringConexao, nomeBanco, localBackup);
                    MessageBox.Show("BackUp realizado com sucesso!!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btnRestaurarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog salvarBackUp = new OpenFileDialog();

                salvarBackUp.Filter = "Backup Files |*.bak";
                salvarBackUp.ShowDialog();

                if (!string.IsNullOrEmpty(salvarBackUp.FileName))
                {
                    string nomeBanco = DadosDaConexao.banco;
                    string localBackup = salvarBackUp.FileName;
                    string stringConexao = string.Format(@"Data Source={0}; Initial Catalog=master; User={1}; Password={2}",
                                                           DadosDaConexao.servidor, DadosDaConexao.usuario, DadosDaConexao.senha);

                    SQLServerBackup.RestauraDatabase(stringConexao, nomeBanco, localBackup);
                    MessageBox.Show("BackUp restaurado com sucesso!!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void frmBackUpBancoDeDados_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }
    }
}
