namespace TCC.VISÃO
{
    partial class CadastroVendas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVendas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barra = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbllol = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtestiloModelo = new System.Windows.Forms.ComboBox();
            this.lsbpgt = new System.Windows.Forms.ComboBox();
            this.lsbProduto = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtcidadeCliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvalorDeVenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvalordeCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblteste = new System.Windows.Forms.DataGridView();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccDataSet = new TCC.tccDataSet();
            this.produtosTableAdapter = new TCC.tccDataSetTableAdapters.produtosTableAdapter();
            this.tccDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnexcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.coddeOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estiloModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordeCompraPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordeVendaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblteste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.barra.Controls.Add(this.btnMinimizar);
            this.barra.Controls.Add(this.btnSair);
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Margin = new System.Windows.Forms.Padding(2);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(867, 39);
            this.barra.TabIndex = 63;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(802, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 61;
            this.btnMinimizar.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(836, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 28);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 60;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::TCC.Properties.Resources._1555492a6_11;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Controls.Add(this.lbllol);
            this.panel6.Controls.Add(this.txtDesconto);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.txtestiloModelo);
            this.panel6.Controls.Add(this.lsbpgt);
            this.panel6.Controls.Add(this.lsbProduto);
            this.panel6.Controls.Add(this.btnFinalizar);
            this.panel6.Controls.Add(this.btnAdicionar);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.txtcidadeCliente);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.txtEndereco);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.txtReferencia);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.btnCancelar);
            this.panel6.Controls.Add(this.btnCadastrar);
            this.panel6.Controls.Add(this.txtquantidade);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtTotal);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtvalorDeVenda);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.txtvalordeCompra);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txtData);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txttipo);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.lblteste);
            this.panel6.Location = new System.Drawing.Point(1, 58);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(866, 604);
            this.panel6.TabIndex = 64;
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseMove);
            // 
            // lbllol
            // 
            this.lbllol.AutoSize = true;
            this.lbllol.BackColor = System.Drawing.Color.Transparent;
            this.lbllol.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllol.ForeColor = System.Drawing.Color.White;
            this.lbllol.Location = new System.Drawing.Point(404, 292);
            this.lbllol.Name = "lbllol";
            this.lbllol.Size = new System.Drawing.Size(61, 21);
            this.lbllol.TabIndex = 157;
            this.lbllol.Text = "Total :";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(485, 148);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(105, 30);
            this.txtDesconto.TabIndex = 156;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Orange;
            this.label8.Location = new System.Drawing.Point(352, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 21);
            this.label8.TabIndex = 155;
            this.label8.Text = "CADASTRAR VENDA";
            // 
            // txtestiloModelo
            // 
            this.txtestiloModelo.Enabled = false;
            this.txtestiloModelo.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtestiloModelo.FormattingEnabled = true;
            this.txtestiloModelo.Location = new System.Drawing.Point(733, 71);
            this.txtestiloModelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtestiloModelo.Name = "txtestiloModelo";
            this.txtestiloModelo.Size = new System.Drawing.Size(105, 31);
            this.txtestiloModelo.TabIndex = 6;
            this.txtestiloModelo.Leave += new System.EventHandler(this.txtestiloModelo_Leave);
            // 
            // lsbpgt
            // 
            this.lsbpgt.Enabled = false;
            this.lsbpgt.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lsbpgt.FormattingEnabled = true;
            this.lsbpgt.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão",
            "Cheque",
            "Boleto"});
            this.lsbpgt.Location = new System.Drawing.Point(138, 147);
            this.lsbpgt.Margin = new System.Windows.Forms.Padding(2);
            this.lsbpgt.Name = "lsbpgt";
            this.lsbpgt.Size = new System.Drawing.Size(105, 31);
            this.lsbpgt.TabIndex = 7;
            // 
            // lsbProduto
            // 
            this.lsbProduto.Enabled = false;
            this.lsbProduto.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lsbProduto.FormattingEnabled = true;
            this.lsbProduto.Location = new System.Drawing.Point(83, 33);
            this.lsbProduto.Margin = new System.Windows.Forms.Padding(2);
            this.lsbProduto.Name = "lsbProduto";
            this.lsbProduto.Size = new System.Drawing.Size(207, 31);
            this.lsbProduto.TabIndex = 1;
            this.lsbProduto.TextChanged += new System.EventHandler(this.lsbProduto_TextChanged);
            this.lsbProduto.Leave += new System.EventHandler(this.lsbProduto_Leave);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.BackgroundImage = global::TCC.Properties.Resources.icons8_botão_de_opção_marcado_48;
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.Location = new System.Drawing.Point(790, 360);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(49, 35);
            this.btnFinalizar.TabIndex = 150;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            this.btnFinalizar.MouseEnter += new System.EventHandler(this.btnFinalizar_MouseEnter);
            this.btnFinalizar.MouseLeave += new System.EventHandler(this.btnFinalizar_MouseLeave);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.BackgroundImage = global::TCC.Properties.Resources.adicionar_ao_carrinho;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.Location = new System.Drawing.Point(719, 360);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(49, 35);
            this.btnAdicionar.TabIndex = 149;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            this.btnAdicionar.MouseEnter += new System.EventHandler(this.btnAdicionar_MouseEnter);
            this.btnAdicionar.MouseLeave += new System.EventHandler(this.btnAdicionar_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Location = new System.Drawing.Point(-10, 323);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(895, 21);
            this.panel3.TabIndex = 148;
            // 
            // txtcidadeCliente
            // 
            this.txtcidadeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcidadeCliente.Enabled = false;
            this.txtcidadeCliente.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtcidadeCliente.Location = new System.Drawing.Point(139, 281);
            this.txtcidadeCliente.Name = "txtcidadeCliente";
            this.txtcidadeCliente.Size = new System.Drawing.Size(142, 30);
            this.txtcidadeCliente.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(60, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 21);
            this.label15.TabIndex = 143;
            this.label15.Text = "Cidade  :";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtEndereco.Location = new System.Drawing.Point(620, 232);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(220, 30);
            this.txtEndereco.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(524, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 21);
            this.label14.TabIndex = 141;
            this.label14.Text = "Endereço  :";
            // 
            // txtReferencia
            // 
            this.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReferencia.Enabled = false;
            this.txtReferencia.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtReferencia.Location = new System.Drawing.Point(140, 234);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(220, 30);
            this.txtReferencia.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(38, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 21);
            this.label12.TabIndex = 136;
            this.label12.Text = "Referência :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(-28, 196);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 21);
            this.panel2.TabIndex = 135;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(-10, 104);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 21);
            this.panel1.TabIndex = 134;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::TCC.Properties.Resources.icons8_cancelar_48;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(64, 366);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(49, 35);
            this.btnCancelar.TabIndex = 133;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BackgroundImage = global::TCC.Properties.Resources.add_77928;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnCadastrar.Location = new System.Drawing.Point(7, 367);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(44, 31);
            this.btnCadastrar.TabIndex = 132;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtquantidade
            // 
            this.txtquantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtquantidade.Enabled = false;
            this.txtquantidade.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtquantidade.Location = new System.Drawing.Point(733, 36);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(105, 30);
            this.txtquantidade.TabIndex = 5;
            this.txtquantidade.TextChanged += new System.EventHandler(this.txtquantidade_TextChanged);
            this.txtquantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantidade_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(626, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 21);
            this.label11.TabIndex = 130;
            this.label11.Text = "Quantidade :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(354, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 21);
            this.label10.TabIndex = 128;
            this.label10.Text = "Desconto Total :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 21);
            this.label7.TabIndex = 126;
            this.label7.Text = "Método de Pgt/ :";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtTotal.Location = new System.Drawing.Point(733, 148);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(105, 30);
            this.txtTotal.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(670, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 124;
            this.label6.Text = "Total :";
            // 
            // txtvalorDeVenda
            // 
            this.txtvalorDeVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvalorDeVenda.Enabled = false;
            this.txtvalorDeVenda.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtvalorDeVenda.Location = new System.Drawing.Point(485, 71);
            this.txtvalorDeVenda.Name = "txtvalorDeVenda";
            this.txtvalorDeVenda.Size = new System.Drawing.Size(105, 30);
            this.txtvalorDeVenda.TabIndex = 4;
            this.txtvalorDeVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorDeVenda_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(352, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 122;
            this.label5.Text = "Valor de Venda :";
            // 
            // txtvalordeCompra
            // 
            this.txtvalordeCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvalordeCompra.Enabled = false;
            this.txtvalordeCompra.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtvalordeCompra.Location = new System.Drawing.Point(485, 36);
            this.txtvalordeCompra.Name = "txtvalordeCompra";
            this.txtvalordeCompra.Size = new System.Drawing.Size(105, 30);
            this.txtvalordeCompra.TabIndex = 3;
            this.txtvalordeCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalordeCompra_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(344, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 120;
            this.label4.Text = "Valor de Compra :";
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(620, 281);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(105, 30);
            this.txtData.TabIndex = 15;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(559, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 118;
            this.label9.Text = "Data :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(613, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 115;
            this.label3.Text = "Estilo/Modelo :";
            // 
            // txttipo
            // 
            this.txttipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipo.Enabled = false;
            this.txttipo.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txttipo.Location = new System.Drawing.Point(83, 70);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(105, 30);
            this.txttipo.TabIndex = 2;
            this.txttipo.Leave += new System.EventHandler(this.txttipo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 113;
            this.label2.Text = "Tipo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 111;
            this.label1.Text = "Produto :";
            // 
            // lblteste
            // 
            this.lblteste.AllowUserToAddRows = false;
            this.lblteste.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lblteste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lblteste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lblteste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnexcluir,
            this.coddeOperacao,
            this.produtoPedido,
            this.tipoProduto,
            this.estiloModelo,
            this.valordeCompraPedido,
            this.valordeVendaPedido,
            this.quantidadePedido,
            this.valortotal});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lblteste.DefaultCellStyle = dataGridViewCellStyle4;
            this.lblteste.Enabled = false;
            this.lblteste.Location = new System.Drawing.Point(-4, 416);
            this.lblteste.Name = "lblteste";
            this.lblteste.RowHeadersWidth = 51;
            this.lblteste.Size = new System.Drawing.Size(867, 185);
            this.lblteste.TabIndex = 85;
            this.lblteste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lblteste_CellContentClick);
            this.lblteste.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.lblteste_CellMouseClick);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.tccDataSetBindingSource;
            // 
            // tccDataSetBindingSource
            // 
            this.tccDataSetBindingSource.DataSource = this.tccDataSet;
            this.tccDataSetBindingSource.Position = 0;
            // 
            // tccDataSet
            // 
            this.tccDataSet.DataSetName = "tccDataSet";
            this.tccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // tccDataSetBindingSource1
            // 
            this.tccDataSetBindingSource1.DataSource = this.tccDataSet;
            this.tccDataSetBindingSource1.Position = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnexcluir
            // 
            this.btnexcluir.HeaderText = "";
            this.btnexcluir.Image = global::TCC.Properties.Resources.icons8_lixeira_vazia_48_removebg_preview;
            this.btnexcluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnexcluir.MinimumWidth = 6;
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Width = 30;
            // 
            // coddeOperacao
            // 
            this.coddeOperacao.HeaderText = "Código";
            this.coddeOperacao.MinimumWidth = 6;
            this.coddeOperacao.Name = "coddeOperacao";
            this.coddeOperacao.ReadOnly = true;
            this.coddeOperacao.Width = 50;
            // 
            // produtoPedido
            // 
            this.produtoPedido.HeaderText = "Produto";
            this.produtoPedido.MinimumWidth = 6;
            this.produtoPedido.Name = "produtoPedido";
            this.produtoPedido.ReadOnly = true;
            this.produtoPedido.Width = 170;
            // 
            // tipoProduto
            // 
            this.tipoProduto.HeaderText = " Tipo";
            this.tipoProduto.MinimumWidth = 6;
            this.tipoProduto.Name = "tipoProduto";
            this.tipoProduto.ReadOnly = true;
            this.tipoProduto.Width = 90;
            // 
            // estiloModelo
            // 
            this.estiloModelo.HeaderText = "Estilo/Modelo";
            this.estiloModelo.MinimumWidth = 6;
            this.estiloModelo.Name = "estiloModelo";
            this.estiloModelo.ReadOnly = true;
            this.estiloModelo.Width = 105;
            // 
            // valordeCompraPedido
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.valordeCompraPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.valordeCompraPedido.HeaderText = "Valor de Compra";
            this.valordeCompraPedido.MinimumWidth = 6;
            this.valordeCompraPedido.Name = "valordeCompraPedido";
            this.valordeCompraPedido.ReadOnly = true;
            this.valordeCompraPedido.Width = 90;
            // 
            // valordeVendaPedido
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            this.valordeVendaPedido.DefaultCellStyle = dataGridViewCellStyle3;
            this.valordeVendaPedido.HeaderText = "Valor de Venda";
            this.valordeVendaPedido.MinimumWidth = 6;
            this.valordeVendaPedido.Name = "valordeVendaPedido";
            this.valordeVendaPedido.ReadOnly = true;
            this.valordeVendaPedido.Width = 90;
            // 
            // quantidadePedido
            // 
            this.quantidadePedido.HeaderText = "Quantidade";
            this.quantidadePedido.MinimumWidth = 6;
            this.quantidadePedido.Name = "quantidadePedido";
            this.quantidadePedido.ReadOnly = true;
            this.quantidadePedido.Width = 80;
            // 
            // valortotal
            // 
            this.valortotal.HeaderText = "   Valor Total";
            this.valortotal.MinimumWidth = 6;
            this.valortotal.Name = "valortotal";
            this.valortotal.Width = 110;
            // 
            // CadastroVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(863, 654);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastroVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroVendas";
            this.Load += new System.EventHandler(this.CadastroVendas_Load);
            this.barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblteste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvalorDeVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvalordeCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcidadeCliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.BindingSource tccDataSetBindingSource;
        private tccDataSet tccDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private tccDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.ComboBox lsbpgt;
        private System.Windows.Forms.BindingSource tccDataSetBindingSource1;
        private System.Windows.Forms.ComboBox txtestiloModelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtDesconto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbllol;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ComboBox lsbProduto;
        public System.Windows.Forms.DataGridView lblteste;
        private System.Windows.Forms.DataGridViewImageColumn btnexcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddeOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estiloModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordeCompraPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordeVendaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotal;
    }
}