using BLL.Compra;
using DAL;
using ModeloDB.Compra;
using System;
using System.Windows.Forms;
using static ConstsEnumerados.Constantes;
using static ConstsEnumerados.Enumerados;

namespace GUI
{
    public partial class frmMovimentacaoCompra : GUI.frmModeloDeFormularioDeCadastro
    {
        public double totalCompra = 0;//Variavel Global

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

        public BLLCompra QueryDB_Compra
        {
            get
            {
                if (_queryDB == null)
                    _queryDB = new BLLCompra(Conexao);
                return _queryDB;
            }
        }
        private BLLCompra _queryDB = null;

        public BLLItensCompra QueryDB_ItensCompra
        {
            get
            {
                if (_queryDB_ItensCompra == null)
                    _queryDB_ItensCompra = new BLLItensCompra(Conexao);
                return _queryDB_ItensCompra;
            }
        }
        private BLLItensCompra _queryDB_ItensCompra = null;

        public BLLParcelasCompra QueryDB_ParcelaCompra
        {
            get
            {
                if (_queryDB_ParcelaCompra == null)
                    _queryDB_ParcelaCompra = new BLLParcelasCompra(Conexao);
                return _queryDB_ParcelaCompra;
            }
        }
        private BLLParcelasCompra _queryDB_ParcelaCompra = null;

        public frmMovimentacaoCompra()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = Inserir;

            this.totalCompra = 0;
            cbNParcela.SelectedIndex = 0;
            
            this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Salvar_Cancelar));
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtForCodigo.Text) <= 0)
                {
                    MessageBox.Show("Informe um código válido para o cliente");
                    return;
                }

                if (Convert.ToInt32(txtNFiscal.Text) < 0)
                {
                    MessageBox.Show("Informe um número válido para a nota fiscal");
                    return;
                }

                if (totalCompra <= 0)
                {
                    MessageBox.Show("Insira itens em sua venda para continuar...");
                    return;
                }

                dgvParcelas.Rows.Clear();
                
                int parcelas = Convert.ToInt32(cbNParcela.Text);
                //Double totallocal = Convert.ToDouble(txtTotalCompra.Text);
                Double totallocal = this.totalCompra;
                double valor = totallocal / parcelas; //valor = this.total/parcelas
                DateTime dt = new DateTime();
                dt = dtDataini.Value;
                lbTotal.Text = this.totalCompra.ToString();

                for (int i = 1; i <= parcelas; i++)
                {
                    String[] k = new String[] { i.ToString(), valor.ToString(), dt.Date.ToString() };
                    this.dgvParcelas.Rows.Add(k);

                    if (dt.Month != 12)
                    {
                        dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                    }
                    else
                    {
                        dt = new DateTime(dt.Year + 1, 1, dt.Day);
                    }
                }
                pnFinalizaCompra.Visible = true;                
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Verifique os campos da tela de venda", ex);                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btSalvarFinal_Click(object sender, EventArgs e)
        {
            Conexao.Conectar();
            Conexao.IniciarTransacao();

            try
            {
                ModeloCompra modeloCompra = new ModeloCompra();
                ModeloItensCompra itensCompra = new ModeloItensCompra();
                ModeloParcelasCompra parcelasCompra = new ModeloParcelasCompra();
                

                modeloCompra.ComData = dtDataCompra.Value;
                modeloCompra.ComNFiscal = Convert.ToInt32(txtNFiscal.Text);
                modeloCompra.ComNParcelas = Convert.ToInt32(cbNParcela.Text);
                modeloCompra.ComStatus = "ativa"; //Verificar para alterar
                modeloCompra.ComTotal = this.totalCompra;
                modeloCompra.ForCod = Convert.ToInt32(txtForCodigo.Text);
                modeloCompra.TpaCod = Convert.ToInt32(cbTpagto.SelectedValue);

                if (this.operacao == Inserir)
                {               

                    QueryDB_Compra.IncluirCompra(modeloCompra, operacao);

                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        itensCompra.ItcCod = i + 1;
                        itensCompra.ComCod = modeloCompra.ComCod;
                        itensCompra.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        itensCompra.ItcQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        itensCompra.ItcValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);

                        QueryDB_ItensCompra.IncluirItens(itensCompra, Inserir);
                        //alterar a quantidade de produtos comprados na tabela de produtos
                        //Trigger
                    }
                    // inserir os itens na tabela parcelas compra
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        parcelasCompra.ComCod = modeloCompra.ComCod;
                        parcelasCompra.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        parcelasCompra.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        parcelasCompra.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);

                        QueryDB_ParcelaCompra.IncluirParcelas(parcelasCompra, Inserir);
                    }
                    MessageBox.Show("Compra inserida com sucesso!! \nCódigo da compra: " + modeloCompra.ComCod.ToString());
                }
                else
                {
                    //alterar uma compra
                    modeloCompra.ComCod = Convert.ToInt32(txtComCodigo.Text);
                    QueryDB_Compra.AlterarCompra(modeloCompra, Alterar);

                    QueryDB_ItensCompra.ExcluirTodosOsItens(modeloCompra.ComCod);
                    //cadastrar os itens da compra
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        itensCompra.ItcCod = i + 1;
                        itensCompra.ComCod = modeloCompra.ComCod;
                        itensCompra.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        itensCompra.ItcQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        itensCompra.ItcValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        QueryDB_ItensCompra.IncluirItens(itensCompra, Inserir);
                        //alterar a quantidade de produtos comprados na tabela de produtos
                        //Trigger
                    }
                    QueryDB_ParcelaCompra.ExcluirTodasAsParcela(parcelasCompra, Excluir);
                    // inserir os itens na tabela parcelas compra
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        parcelasCompra.ComCod = modeloCompra.ComCod;
                        parcelasCompra.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        parcelasCompra.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        parcelasCompra.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        QueryDB_ParcelaCompra.IncluirParcelas(parcelasCompra, Inserir);
                    }
                    MessageBox.Show("Cadastro alterado com Sucesso");
                }

                this.LimparDadosDaTela();
                pnFinalizaCompra.Visible = false;
                this.AlteraBotoes(Convert.ToInt32(OperacaoFormulario.Inserir_Localizar));
                Conexao.TerminarTransacao();
                Conexao.Desconectar();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                Conexao.CancelarTransacao();
                Conexao.Desconectar();
            }
        }

        private void LimparDadosDaTela()
        {
            txtComCodigo.Clear(); 
            txtNFiscal.Clear(); 
            txtForCodigo.Clear(); 
            txtProCod.Clear();

            lProduto.Text = "Informe o código do produto ou clique em localizar";

            txtQtde.Clear(); 
            txtValor.Clear(); 
            txtTotalCompra.Clear();
            dgvItens.Rows.Clear(); //limpar as linhas da dataGrid
        }
    }
}
