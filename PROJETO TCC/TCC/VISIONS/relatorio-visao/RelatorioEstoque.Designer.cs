namespace TCC.VISÃO
{
    partial class RelatorioEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioEstoque));
            this.label8 = new System.Windows.Forms.Label();
            this.barra = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblsaida = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbloperacao = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btnfiltrarPersonalizado = new System.Windows.Forms.Button();
            this.btnfiltrarAno = new System.Windows.Forms.Button();
            this.btnfiltroMes = new System.Windows.Forms.Button();
            this.btnfiltroSemana = new System.Windows.Forms.Button();
            this.dtgestoque = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordeCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordeVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblprecoTotal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnexportarPdf = new System.Windows.Forms.Button();
            this.btnexportarExcel = new System.Windows.Forms.Button();
            this.lbl6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnfiltro = new System.Windows.Forms.Panel();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.txtdataInicial = new System.Windows.Forms.MaskedTextBox();
            this.pnvar = new System.Windows.Forms.Panel();
            this.btnfecharPanel = new System.Windows.Forms.PictureBox();
            this.txtdataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgestoque)).BeginInit();
            this.pnfiltro.SuspendLayout();
            this.pnvar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnfecharPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Orange;
            this.label8.Location = new System.Drawing.Point(347, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 21);
            this.label8.TabIndex = 157;
            this.label8.Text = "RELATÓRIO ESTOQUE";
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.barra.Controls.Add(this.btnMinimizar);
            this.barra.Controls.Add(this.btnSair);
            this.barra.Location = new System.Drawing.Point(-2, -10);
            this.barra.Margin = new System.Windows.Forms.Padding(2);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(865, 46);
            this.barra.TabIndex = 165;
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(800, 15);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 61;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(834, 15);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 28);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 60;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(178)))));
            this.panel3.Controls.Add(this.lblsaida);
            this.panel3.Controls.Add(this.lbl1);
            this.panel3.Location = new System.Drawing.Point(12, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 81);
            this.panel3.TabIndex = 168;
            // 
            // lblsaida
            // 
            this.lblsaida.AutoSize = true;
            this.lblsaida.BackColor = System.Drawing.Color.Transparent;
            this.lblsaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaida.ForeColor = System.Drawing.Color.Black;
            this.lblsaida.Location = new System.Drawing.Point(20, 30);
            this.lblsaida.Name = "lblsaida";
            this.lblsaida.Size = new System.Drawing.Size(143, 15);
            this.lblsaida.TabIndex = 3;
            this.lblsaida.Text = "QUANTIDADE ENTRADA";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(80, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(20, 18);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "N";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(318, 293);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(150, 15);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "QUANTIDADE PRODUTO ";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(474, 291);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(20, 18);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "N";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(178)))));
            this.panel2.Controls.Add(this.lbloperacao);
            this.panel2.Controls.Add(this.lbl2);
            this.panel2.Location = new System.Drawing.Point(649, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 81);
            this.panel2.TabIndex = 167;
            // 
            // lbloperacao
            // 
            this.lbloperacao.AutoSize = true;
            this.lbloperacao.BackColor = System.Drawing.Color.Transparent;
            this.lbloperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloperacao.ForeColor = System.Drawing.Color.Black;
            this.lbloperacao.Location = new System.Drawing.Point(43, 30);
            this.lbloperacao.Name = "lbloperacao";
            this.lbloperacao.Size = new System.Drawing.Size(121, 15);
            this.lbloperacao.TabIndex = 3;
            this.lbloperacao.Text = "QUANTIDADE SAÍDA";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(92, 45);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(20, 18);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "N";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl5);
            this.panel1.Location = new System.Drawing.Point(336, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 81);
            this.panel1.TabIndex = 166;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUANTIDADE OPERAÇÕES";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.Black;
            this.lbl5.Location = new System.Drawing.Point(83, 45);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(20, 18);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "N";
            // 
            // btnfiltrarPersonalizado
            // 
            this.btnfiltrarPersonalizado.BackColor = System.Drawing.Color.Transparent;
            this.btnfiltrarPersonalizado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfiltrarPersonalizado.BackgroundImage")));
            this.btnfiltrarPersonalizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfiltrarPersonalizado.FlatAppearance.BorderSize = 0;
            this.btnfiltrarPersonalizado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnfiltrarPersonalizado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnfiltrarPersonalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfiltrarPersonalizado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltrarPersonalizado.ForeColor = System.Drawing.Color.Transparent;
            this.btnfiltrarPersonalizado.Location = new System.Drawing.Point(250, 273);
            this.btnfiltrarPersonalizado.Name = "btnfiltrarPersonalizado";
            this.btnfiltrarPersonalizado.Size = new System.Drawing.Size(62, 35);
            this.btnfiltrarPersonalizado.TabIndex = 172;
            this.btnfiltrarPersonalizado.UseVisualStyleBackColor = false;
            this.btnfiltrarPersonalizado.Click += new System.EventHandler(this.btnfiltrarPersonalizado_Click);
            this.btnfiltrarPersonalizado.MouseEnter += new System.EventHandler(this.btnfiltrarPersonalizado_MouseEnter);
            this.btnfiltrarPersonalizado.MouseLeave += new System.EventHandler(this.btnfiltrarPersonalizado_MouseLeave);
            // 
            // btnfiltrarAno
            // 
            this.btnfiltrarAno.BackColor = System.Drawing.Color.Transparent;
            this.btnfiltrarAno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfiltrarAno.BackgroundImage")));
            this.btnfiltrarAno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfiltrarAno.FlatAppearance.BorderSize = 0;
            this.btnfiltrarAno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnfiltrarAno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnfiltrarAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfiltrarAno.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltrarAno.ForeColor = System.Drawing.Color.Transparent;
            this.btnfiltrarAno.Location = new System.Drawing.Point(169, 273);
            this.btnfiltrarAno.Name = "btnfiltrarAno";
            this.btnfiltrarAno.Size = new System.Drawing.Size(62, 35);
            this.btnfiltrarAno.TabIndex = 171;
            this.btnfiltrarAno.UseVisualStyleBackColor = false;
            this.btnfiltrarAno.Click += new System.EventHandler(this.btn3_Click);
            this.btnfiltrarAno.MouseEnter += new System.EventHandler(this.btn3_MouseEnter);
            this.btnfiltrarAno.MouseLeave += new System.EventHandler(this.btnfiltrarAno_MouseLeave);
            // 
            // btnfiltroMes
            // 
            this.btnfiltroMes.BackColor = System.Drawing.Color.Transparent;
            this.btnfiltroMes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfiltroMes.BackgroundImage")));
            this.btnfiltroMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfiltroMes.FlatAppearance.BorderSize = 0;
            this.btnfiltroMes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnfiltroMes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnfiltroMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfiltroMes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltroMes.ForeColor = System.Drawing.Color.Transparent;
            this.btnfiltroMes.Location = new System.Drawing.Point(84, 273);
            this.btnfiltroMes.Name = "btnfiltroMes";
            this.btnfiltroMes.Size = new System.Drawing.Size(62, 35);
            this.btnfiltroMes.TabIndex = 170;
            this.btnfiltroMes.UseVisualStyleBackColor = false;
            this.btnfiltroMes.Click += new System.EventHandler(this.btnfiltroMes_Click);
            this.btnfiltroMes.MouseEnter += new System.EventHandler(this.btnfiltroMes_MouseEnter);
            this.btnfiltroMes.MouseLeave += new System.EventHandler(this.btnfiltroMes_MouseLeave);
            // 
            // btnfiltroSemana
            // 
            this.btnfiltroSemana.BackColor = System.Drawing.Color.Transparent;
            this.btnfiltroSemana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfiltroSemana.BackgroundImage")));
            this.btnfiltroSemana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfiltroSemana.FlatAppearance.BorderSize = 0;
            this.btnfiltroSemana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnfiltroSemana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnfiltroSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfiltroSemana.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltroSemana.ForeColor = System.Drawing.Color.Transparent;
            this.btnfiltroSemana.Location = new System.Drawing.Point(3, 273);
            this.btnfiltroSemana.Name = "btnfiltroSemana";
            this.btnfiltroSemana.Size = new System.Drawing.Size(62, 35);
            this.btnfiltroSemana.TabIndex = 169;
            this.btnfiltroSemana.UseVisualStyleBackColor = false;
            this.btnfiltroSemana.Click += new System.EventHandler(this.btnfiltroSemana_Click);
            this.btnfiltroSemana.MouseEnter += new System.EventHandler(this.btnfiltroSemana_MouseEnter);
            this.btnfiltroSemana.MouseLeave += new System.EventHandler(this.btnfiltroSemana_MouseLeave_1);
            // 
            // dtgestoque
            // 
            this.dtgestoque.AllowUserToAddRows = false;
            this.dtgestoque.BackgroundColor = System.Drawing.Color.Lavender;
            this.dtgestoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgestoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.fornecedor,
            this.tipo,
            this.modelo,
            this.quantidade,
            this.valordeCompra,
            this.valordeVenda,
            this.dataDeCadastro});
            this.dtgestoque.Location = new System.Drawing.Point(0, 314);
            this.dtgestoque.Name = "dtgestoque";
            this.dtgestoque.ReadOnly = true;
            this.dtgestoque.RowHeadersWidth = 51;
            this.dtgestoque.Size = new System.Drawing.Size(863, 265);
            this.dtgestoque.TabIndex = 173;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 116;
            // 
            // fornecedor
            // 
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.MinimumWidth = 6;
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.Width = 125;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 6;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 125;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.MinimumWidth = 6;
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 125;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.MinimumWidth = 6;
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 125;
            // 
            // valordeCompra
            // 
            this.valordeCompra.HeaderText = "Valor de Compra";
            this.valordeCompra.MinimumWidth = 6;
            this.valordeCompra.Name = "valordeCompra";
            this.valordeCompra.ReadOnly = true;
            this.valordeCompra.Width = 125;
            // 
            // valordeVenda
            // 
            this.valordeVenda.HeaderText = "Valor de Venda";
            this.valordeVenda.MinimumWidth = 6;
            this.valordeVenda.Name = "valordeVenda";
            this.valordeVenda.ReadOnly = true;
            this.valordeVenda.Width = 125;
            // 
            // dataDeCadastro
            // 
            this.dataDeCadastro.HeaderText = "Data de Cadastro";
            this.dataDeCadastro.MinimumWidth = 6;
            this.dataDeCadastro.Name = "dataDeCadastro";
            this.dataDeCadastro.ReadOnly = true;
            this.dataDeCadastro.Width = 125;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(744, 289);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(20, 18);
            this.lbl4.TabIndex = 174;
            this.lbl4.Text = "N";
            // 
            // lblprecoTotal
            // 
            this.lblprecoTotal.AutoSize = true;
            this.lblprecoTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblprecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecoTotal.ForeColor = System.Drawing.Color.White;
            this.lblprecoTotal.Location = new System.Drawing.Point(535, 291);
            this.lblprecoTotal.Name = "lblprecoTotal";
            this.lblprecoTotal.Size = new System.Drawing.Size(203, 15);
            this.lblprecoTotal.TabIndex = 175;
            this.lblprecoTotal.Text = "TOTAL DESPESAS (COM FILTROS)";
            // 
            // timer1
            // 
            this.timer1.Interval = 50000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnexportarPdf
            // 
            this.btnexportarPdf.BackColor = System.Drawing.Color.Transparent;
            this.btnexportarPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexportarPdf.BackgroundImage")));
            this.btnexportarPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnexportarPdf.FlatAppearance.BorderSize = 0;
            this.btnexportarPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexportarPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexportarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportarPdf.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportarPdf.ForeColor = System.Drawing.Color.Transparent;
            this.btnexportarPdf.Location = new System.Drawing.Point(779, 585);
            this.btnexportarPdf.Name = "btnexportarPdf";
            this.btnexportarPdf.Size = new System.Drawing.Size(81, 40);
            this.btnexportarPdf.TabIndex = 176;
            this.btnexportarPdf.UseVisualStyleBackColor = false;
            this.btnexportarPdf.MouseEnter += new System.EventHandler(this.btnexportarPdf_MouseEnter);
            this.btnexportarPdf.MouseLeave += new System.EventHandler(this.btnexportarPdf_MouseLeave);
            // 
            // btnexportarExcel
            // 
            this.btnexportarExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnexportarExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexportarExcel.BackgroundImage")));
            this.btnexportarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnexportarExcel.FlatAppearance.BorderSize = 0;
            this.btnexportarExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexportarExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportarExcel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportarExcel.ForeColor = System.Drawing.Color.Transparent;
            this.btnexportarExcel.Location = new System.Drawing.Point(686, 585);
            this.btnexportarExcel.Name = "btnexportarExcel";
            this.btnexportarExcel.Size = new System.Drawing.Size(74, 40);
            this.btnexportarExcel.TabIndex = 177;
            this.btnexportarExcel.UseVisualStyleBackColor = false;
            this.btnexportarExcel.Click += new System.EventHandler(this.btnexportarExcel_Click);
            this.btnexportarExcel.MouseEnter += new System.EventHandler(this.btnexportarExcel_MouseEnter);
            this.btnexportarExcel.MouseLeave += new System.EventHandler(this.btnexportarExcel_MouseLeave);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.Transparent;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.ForeColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(221, 610);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(20, 18);
            this.lbl6.TabIndex = 178;
            this.lbl6.Text = "N";
            this.lbl6.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 610);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 15);
            this.label3.TabIndex = 179;
            this.label3.Text = "TOTAL DESPESAS (SEM FILTRO)";
            this.label3.Visible = false;
            // 
            // pnfiltro
            // 
            this.pnfiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(38)))));
            this.pnfiltro.Controls.Add(this.btnfiltrar);
            this.pnfiltro.Controls.Add(this.txtdataInicial);
            this.pnfiltro.Controls.Add(this.pnvar);
            this.pnfiltro.Controls.Add(this.txtdataFinal);
            this.pnfiltro.Controls.Add(this.label2);
            this.pnfiltro.Controls.Add(this.label9);
            this.pnfiltro.Location = new System.Drawing.Point(405, 57);
            this.pnfiltro.Name = "pnfiltro";
            this.pnfiltro.Size = new System.Drawing.Size(372, 229);
            this.pnfiltro.TabIndex = 180;
            this.pnfiltro.Visible = false;
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.BackColor = System.Drawing.Color.Transparent;
            this.btnfiltrar.BackgroundImage = global::TCC.Properties.Resources.icons8_botão_de_opção_marcado_48;
            this.btnfiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfiltrar.FlatAppearance.BorderSize = 0;
            this.btnfiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnfiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfiltrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnfiltrar.Location = new System.Drawing.Point(152, 158);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(68, 36);
            this.btnfiltrar.TabIndex = 183;
            this.btnfiltrar.UseVisualStyleBackColor = false;
            this.btnfiltrar.Visible = false;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // txtdataInicial
            // 
            this.txtdataInicial.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdataInicial.Location = new System.Drawing.Point(185, 67);
            this.txtdataInicial.Mask = "00/00/0000";
            this.txtdataInicial.Name = "txtdataInicial";
            this.txtdataInicial.Size = new System.Drawing.Size(127, 30);
            this.txtdataInicial.TabIndex = 179;
            this.txtdataInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdataInicial.Visible = false;
            // 
            // pnvar
            // 
            this.pnvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnvar.Controls.Add(this.btnfecharPanel);
            this.pnvar.Location = new System.Drawing.Point(2, 2);
            this.pnvar.Margin = new System.Windows.Forms.Padding(2);
            this.pnvar.Name = "pnvar";
            this.pnvar.Size = new System.Drawing.Size(369, 36);
            this.pnvar.TabIndex = 184;
            this.pnvar.Visible = false;
            // 
            // btnfecharPanel
            // 
            this.btnfecharPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfecharPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfecharPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnfecharPanel.Image")));
            this.btnfecharPanel.Location = new System.Drawing.Point(338, 5);
            this.btnfecharPanel.Name = "btnfecharPanel";
            this.btnfecharPanel.Size = new System.Drawing.Size(28, 28);
            this.btnfecharPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnfecharPanel.TabIndex = 61;
            this.btnfecharPanel.TabStop = false;
            this.btnfecharPanel.Click += new System.EventHandler(this.btnfecharPanel_Click);
            // 
            // txtdataFinal
            // 
            this.txtdataFinal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdataFinal.Location = new System.Drawing.Point(185, 111);
            this.txtdataFinal.Mask = "00/00/0000";
            this.txtdataFinal.Name = "txtdataFinal";
            this.txtdataFinal.Size = new System.Drawing.Size(127, 30);
            this.txtdataFinal.TabIndex = 181;
            this.txtdataFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdataFinal.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 182;
            this.label2.Text = "Data Final :";
            this.label2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(70, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 21);
            this.label9.TabIndex = 180;
            this.label9.Text = "Data Inicial :";
            this.label9.Visible = false;
            // 
            // RelatorioEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(38)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(863, 654);
            this.Controls.Add(this.pnfiltro);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnexportarExcel);
            this.Controls.Add(this.btnexportarPdf);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblprecoTotal);
            this.Controls.Add(this.dtgestoque);
            this.Controls.Add(this.btnfiltrarPersonalizado);
            this.Controls.Add(this.btnfiltrarAno);
            this.Controls.Add(this.btnfiltroMes);
            this.Controls.Add(this.btnfiltroSemana);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioEstoque";
            this.Load += new System.EventHandler(this.RelatorioEstoque_Load);
            this.barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgestoque)).EndInit();
            this.pnfiltro.ResumeLayout(false);
            this.pnfiltro.PerformLayout();
            this.pnvar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnfecharPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbloperacao;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblsaida;
        private System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Button btnfiltrarPersonalizado;
        public System.Windows.Forms.Button btnfiltrarAno;
        public System.Windows.Forms.Button btnfiltroMes;
        public System.Windows.Forms.Button btnfiltroSemana;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblprecoTotal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl5;
        public System.Windows.Forms.Button btnexportarPdf;
        public System.Windows.Forms.Button btnexportarExcel;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnfiltro;
        public System.Windows.Forms.DataGridView dtgestoque;
        private System.Windows.Forms.Panel pnvar;
        public System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.MaskedTextBox txtdataFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtdataInicial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox btnfecharPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordeVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeCadastro;
    }
}