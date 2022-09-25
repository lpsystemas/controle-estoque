namespace GUI
{
    partial class frmMovimentacaoCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.btLocProd = new System.Windows.Forms.Button();
            this.txtProCod = new System.Windows.Forms.TextBox();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lCliente = new System.Windows.Forms.Label();
            this.btLocFor = new System.Windows.Forms.Button();
            this.txtForCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.proCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDataini = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNParcela = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTpagto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDataCompra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNFiscal = new System.Windows.Forms.TextBox();
            this.txtComCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lProduto = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btCancelarFinal = new System.Windows.Forms.Button();
            this.btSalvarFinal = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_datavecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.pnFinalizaCompra = new System.Windows.Forms.Panel();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.pnFinalizaCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.txtValor);
            this.pnDados.Controls.Add(this.txtQtde);
            this.pnDados.Controls.Add(this.btLocProd);
            this.pnDados.Controls.Add(this.txtProCod);
            this.pnDados.Controls.Add(this.txtTotalCompra);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.lCliente);
            this.pnDados.Controls.Add(this.btLocFor);
            this.pnDados.Controls.Add(this.txtForCodigo);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.dgvItens);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.dtDataini);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.cbNParcela);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.cbTpagto);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.dtDataCompra);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtNFiscal);
            this.pnDados.Controls.Add(this.txtComCodigo);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.label15);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.lProduto);
            this.pnDados.Size = new System.Drawing.Size(818, 419);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(8, 431);
            this.pnBotoes.Size = new System.Drawing.Size(818, 84);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(698, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 22);
            this.label12.TabIndex = 100;
            this.label12.Text = "Valor Unitário";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(588, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 22);
            this.label11.TabIndex = 99;
            this.label11.Text = "Quantidade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 15);
            this.label13.TabIndex = 98;
            this.label13.Text = "Itens da Compra";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(698, 143);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(107, 26);
            this.txtValor.TabIndex = 97;
            this.txtValor.Text = "0.00";
            // 
            // txtQtde
            // 
            this.txtQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(588, 143);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(94, 26);
            this.txtQtde.TabIndex = 96;
            this.txtQtde.Text = "0";
            // 
            // btLocProd
            // 
            this.btLocProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocProd.Location = new System.Drawing.Point(167, 120);
            this.btLocProd.Name = "btLocProd";
            this.btLocProd.Size = new System.Drawing.Size(77, 27);
            this.btLocProd.TabIndex = 94;
            this.btLocProd.Text = "Localizar";
            this.btLocProd.UseVisualStyleBackColor = true;
            // 
            // txtProCod
            // 
            this.txtProCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProCod.Location = new System.Drawing.Point(14, 124);
            this.txtProCod.Name = "txtProCod";
            this.txtProCod.Size = new System.Drawing.Size(133, 19);
            this.txtProCod.TabIndex = 93;
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompra.Location = new System.Drawing.Point(718, 384);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(87, 26);
            this.txtTotalCompra.TabIndex = 91;
            this.txtTotalCompra.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(400, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 90;
            this.label9.Text = "Data da Compra";
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCliente.Location = new System.Drawing.Point(250, 84);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(305, 15);
            this.lCliente.TabIndex = 89;
            this.lCliente.Text = "Informe o código do Fornecedor ou clique em localizar";
            // 
            // btLocFor
            // 
            this.btLocFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocFor.Location = new System.Drawing.Point(168, 75);
            this.btLocFor.Name = "btLocFor";
            this.btLocFor.Size = new System.Drawing.Size(77, 27);
            this.btLocFor.TabIndex = 88;
            this.btLocFor.Text = "Localizar";
            this.btLocFor.UseVisualStyleBackColor = true;
            // 
            // txtForCodigo
            // 
            this.txtForCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForCodigo.Location = new System.Drawing.Point(14, 80);
            this.txtForCodigo.Name = "txtForCodigo";
            this.txtForCodigo.Size = new System.Drawing.Size(133, 19);
            this.txtForCodigo.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 15);
            this.label7.TabIndex = 86;
            this.label7.Text = "Código do Fornecedor";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proCod,
            this.forNome,
            this.forQtde,
            this.provund,
            this.provTotal});
            this.dgvItens.Location = new System.Drawing.Point(14, 181);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(791, 169);
            this.dgvItens.TabIndex = 85;
            // 
            // proCod
            // 
            this.proCod.HeaderText = "Código";
            this.proCod.Name = "proCod";
            this.proCod.ReadOnly = true;
            this.proCod.Width = 80;
            // 
            // forNome
            // 
            this.forNome.HeaderText = "Nome";
            this.forNome.Name = "forNome";
            this.forNome.ReadOnly = true;
            this.forNome.Width = 250;
            // 
            // forQtde
            // 
            this.forQtde.HeaderText = "Quantidade";
            this.forQtde.Name = "forQtde";
            this.forQtde.ReadOnly = true;
            // 
            // provund
            // 
            this.provund.HeaderText = "Valor Unitário";
            this.provund.Name = "provund";
            this.provund.ReadOnly = true;
            this.provund.Width = 130;
            // 
            // provTotal
            // 
            this.provTotal.HeaderText = "Valor Total";
            this.provTotal.Name = "provTotal";
            this.provTotal.ReadOnly = true;
            this.provTotal.Width = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(287, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 15);
            this.label6.TabIndex = 84;
            this.label6.Text = "Data Inicial do Pagamento";
            // 
            // dtDataini
            // 
            this.dtDataini.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataini.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataini.Location = new System.Drawing.Point(289, 375);
            this.dtDataini.Name = "dtDataini";
            this.dtDataini.Size = new System.Drawing.Size(128, 19);
            this.dtDataini.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 82;
            this.label5.Text = "Numero de Parcelas";
            // 
            // cbNParcela
            // 
            this.cbNParcela.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNParcela.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNParcela.FormattingEnabled = true;
            this.cbNParcela.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbNParcela.Location = new System.Drawing.Point(19, 373);
            this.cbNParcela.Name = "cbNParcela";
            this.cbNParcela.Size = new System.Drawing.Size(117, 21);
            this.cbNParcela.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 80;
            this.label4.Text = "Tipo de Pagamento";
            // 
            // cbTpagto
            // 
            this.cbTpagto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTpagto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTpagto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTpagto.FormattingEnabled = true;
            this.cbTpagto.Location = new System.Drawing.Point(157, 372);
            this.cbTpagto.Name = "cbTpagto";
            this.cbTpagto.Size = new System.Drawing.Size(114, 21);
            this.cbTpagto.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(718, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 78;
            this.label3.Text = "Valor Total";
            // 
            // dtDataCompra
            // 
            this.dtDataCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataCompra.Location = new System.Drawing.Point(403, 38);
            this.dtDataCompra.Name = "dtDataCompra";
            this.dtDataCompra.Size = new System.Drawing.Size(214, 19);
            this.dtDataCompra.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 76;
            this.label2.Text = "Numero da Nota Fiscal";
            // 
            // txtNFiscal
            // 
            this.txtNFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNFiscal.Location = new System.Drawing.Point(164, 38);
            this.txtNFiscal.Name = "txtNFiscal";
            this.txtNFiscal.Size = new System.Drawing.Size(217, 19);
            this.txtNFiscal.TabIndex = 75;
            // 
            // txtComCodigo
            // 
            this.txtComCodigo.Enabled = false;
            this.txtComCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComCodigo.Location = new System.Drawing.Point(12, 36);
            this.txtComCodigo.Name = "txtComCodigo";
            this.txtComCodigo.Size = new System.Drawing.Size(129, 19);
            this.txtComCodigo.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 73;
            this.label1.Text = "Código";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(682, 387);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 20);
            this.label15.TabIndex = 101;
            this.label15.Text = "R$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 92;
            this.label10.Text = "Código do Produto:";
            // 
            // lProduto
            // 
            this.lProduto.AutoSize = true;
            this.lProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProduto.Location = new System.Drawing.Point(250, 125);
            this.lProduto.Name = "lProduto";
            this.lProduto.Size = new System.Drawing.Size(284, 15);
            this.lProduto.TabIndex = 95;
            this.lProduto.Text = "Informe o código do produto ou clique em localizar";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(726, 393);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 17);
            this.label20.TabIndex = 38;
            this.label20.Text = "R$";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Red;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(760, 390);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(45, 20);
            this.lbTotal.TabIndex = 28;
            this.lbTotal.Text = "0000";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(631, 395);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 15);
            this.label19.TabIndex = 27;
            this.label19.Text = "Total da Compra:";
            // 
            // btCancelarFinal
            // 
            this.btCancelarFinal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarFinal.Image = global::GUI.Properties.Resources.Cancelar;
            this.btCancelarFinal.Location = new System.Drawing.Point(99, 423);
            this.btCancelarFinal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btCancelarFinal.Name = "btCancelarFinal";
            this.btCancelarFinal.Size = new System.Drawing.Size(72, 73);
            this.btCancelarFinal.TabIndex = 26;
            this.btCancelarFinal.Text = "Cancelar";
            this.btCancelarFinal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelarFinal.UseVisualStyleBackColor = true;
            // 
            // btSalvarFinal
            // 
            this.btSalvarFinal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarFinal.Image = global::GUI.Properties.Resources.Salvar1_fw;
            this.btSalvarFinal.Location = new System.Drawing.Point(17, 423);
            this.btSalvarFinal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btSalvarFinal.Name = "btSalvarFinal";
            this.btSalvarFinal.Size = new System.Drawing.Size(72, 73);
            this.btSalvarFinal.TabIndex = 25;
            this.btSalvarFinal.Text = "Salvar";
            this.btSalvarFinal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvarFinal.UseVisualStyleBackColor = true;
            this.btSalvarFinal.Click += new System.EventHandler(this.btSalvarFinal_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 59);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Parcelas da Compra";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 35);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Dados do Pagamento";
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pco_cod,
            this.pco_valor,
            this.pco_datavecto});
            this.dgvParcelas.Location = new System.Drawing.Point(10, 80);
            this.dgvParcelas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowTemplate.Height = 24;
            this.dgvParcelas.Size = new System.Drawing.Size(795, 294);
            this.dgvParcelas.TabIndex = 0;
            // 
            // pco_cod
            // 
            this.pco_cod.HeaderText = "Parcela";
            this.pco_cod.Name = "pco_cod";
            this.pco_cod.ReadOnly = true;
            // 
            // pco_valor
            // 
            this.pco_valor.HeaderText = "Valor da parcela";
            this.pco_valor.Name = "pco_valor";
            this.pco_valor.ReadOnly = true;
            // 
            // pco_datavecto
            // 
            this.pco_datavecto.HeaderText = "Data do vencimento";
            this.pco_datavecto.Name = "pco_datavecto";
            this.pco_datavecto.ReadOnly = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(612, 20);
            this.label17.TabIndex = 24;
            this.label17.Text = "___________________________________________________________________";
            // 
            // pnFinalizaCompra
            // 
            this.pnFinalizaCompra.Controls.Add(this.label20);
            this.pnFinalizaCompra.Controls.Add(this.lbTotal);
            this.pnFinalizaCompra.Controls.Add(this.label19);
            this.pnFinalizaCompra.Controls.Add(this.btCancelarFinal);
            this.pnFinalizaCompra.Controls.Add(this.btSalvarFinal);
            this.pnFinalizaCompra.Controls.Add(this.label18);
            this.pnFinalizaCompra.Controls.Add(this.label16);
            this.pnFinalizaCompra.Controls.Add(this.dgvParcelas);
            this.pnFinalizaCompra.Controls.Add(this.label17);
            this.pnFinalizaCompra.Location = new System.Drawing.Point(830, 8);
            this.pnFinalizaCompra.Margin = new System.Windows.Forms.Padding(2);
            this.pnFinalizaCompra.Name = "pnFinalizaCompra";
            this.pnFinalizaCompra.Size = new System.Drawing.Size(818, 507);
            this.pnFinalizaCompra.TabIndex = 8;
            this.pnFinalizaCompra.Visible = false;
            // 
            // frmMovimentacaoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1783, 518);
            this.Controls.Add(this.pnFinalizaCompra);
            this.Name = "frmMovimentacaoCompra";
            this.Text = "Formulário de Compra";
            this.Controls.SetChildIndex(this.pnFinalizaCompra, 0);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.pnFinalizaCompra.ResumeLayout(false);
            this.pnFinalizaCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Button btLocProd;
        private System.Windows.Forms.TextBox txtProCod;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.Button btLocFor;
        private System.Windows.Forms.TextBox txtForCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn forNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn forQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn provund;
        private System.Windows.Forms.DataGridViewTextBoxColumn provTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDataini;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNParcela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTpagto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDataCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNFiscal;
        private System.Windows.Forms.TextBox txtComCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lProduto;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label19;
        protected System.Windows.Forms.Button btCancelarFinal;
        protected System.Windows.Forms.Button btSalvarFinal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavecto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel pnFinalizaCompra;
    }
}
