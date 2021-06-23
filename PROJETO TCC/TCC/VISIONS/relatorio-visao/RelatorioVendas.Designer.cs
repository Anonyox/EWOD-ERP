namespace TCC.VISÃO
{
    partial class RelatorioVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioVendas));
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsaida = new System.Windows.Forms.Label();
            this.lbltot = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbloperacao = new System.Windows.Forms.Label();
            this.lblopera = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblvendas = new System.Windows.Forms.Label();
            this.barra = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnfiltrarPersonalizado = new System.Windows.Forms.Button();
            this.btnfiltrarAno = new System.Windows.Forms.Button();
            this.btnfiltroMes = new System.Windows.Forms.Button();
            this.btnfiltroSemana = new System.Windows.Forms.Button();
            this.lbllucrofiltro = new System.Windows.Forms.Label();
            this.lblprecoTotal = new System.Windows.Forms.Label();
            this.dtgvendas = new System.Windows.Forms.DataGridView();
            this.extornar = new System.Windows.Forms.DataGridViewImageColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totfinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnexportarExcel = new System.Windows.Forms.Button();
            this.btnexportarPdf = new System.Windows.Forms.Button();
            this.pnitens = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtgitens = new System.Windows.Forms.DataGridView();
            this.codIten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnfiltro = new System.Windows.Forms.Panel();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.txtdataInicial = new System.Windows.Forms.MaskedTextBox();
            this.pnvar = new System.Windows.Forms.Panel();
            this.btnfecharPanel = new System.Windows.Forms.PictureBox();
            this.txtdataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvendas)).BeginInit();
            this.pnitens.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgitens)).BeginInit();
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
            this.label8.Location = new System.Drawing.Point(374, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 21);
            this.label8.TabIndex = 156;
            this.label8.Text = "RELATÓRIO VENDA ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.lblsaida);
            this.panel1.Controls.Add(this.lbltot);
            this.panel1.Location = new System.Drawing.Point(12, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 81);
            this.panel1.TabIndex = 157;
            // 
            // lblsaida
            // 
            this.lblsaida.AutoSize = true;
            this.lblsaida.BackColor = System.Drawing.Color.Transparent;
            this.lblsaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaida.ForeColor = System.Drawing.Color.Black;
            this.lblsaida.Location = new System.Drawing.Point(54, 30);
            this.lblsaida.Name = "lblsaida";
            this.lblsaida.Size = new System.Drawing.Size(71, 15);
            this.lblsaida.TabIndex = 3;
            this.lblsaida.Text = "ENTRADAS";
            // 
            // lbltot
            // 
            this.lbltot.AutoSize = true;
            this.lbltot.BackColor = System.Drawing.Color.Transparent;
            this.lbltot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltot.ForeColor = System.Drawing.Color.Black;
            this.lbltot.Location = new System.Drawing.Point(54, 45);
            this.lbltot.Name = "lbltot";
            this.lbltot.Size = new System.Drawing.Size(20, 18);
            this.lbltot.TabIndex = 1;
            this.lbltot.Text = "N";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbloperacao);
            this.panel2.Controls.Add(this.lblopera);
            this.panel2.Location = new System.Drawing.Point(350, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 81);
            this.panel2.TabIndex = 158;
            // 
            // lbloperacao
            // 
            this.lbloperacao.AutoSize = true;
            this.lbloperacao.BackColor = System.Drawing.Color.Transparent;
            this.lbloperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloperacao.ForeColor = System.Drawing.Color.Black;
            this.lbloperacao.Location = new System.Drawing.Point(25, 30);
            this.lbloperacao.Name = "lbloperacao";
            this.lbloperacao.Size = new System.Drawing.Size(161, 15);
            this.lbloperacao.TabIndex = 3;
            this.lbloperacao.Text = "QUANTIDADE OPERAÇÕES";
            // 
            // lblopera
            // 
            this.lblopera.AutoSize = true;
            this.lblopera.BackColor = System.Drawing.Color.Transparent;
            this.lblopera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblopera.ForeColor = System.Drawing.Color.Black;
            this.lblopera.Location = new System.Drawing.Point(87, 45);
            this.lblopera.Name = "lblopera";
            this.lblopera.Size = new System.Drawing.Size(20, 18);
            this.lblopera.TabIndex = 1;
            this.lblopera.Text = "N";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(178)))));
            this.panel3.Controls.Add(this.lbltotal);
            this.panel3.Controls.Add(this.lblvendas);
            this.panel3.Location = new System.Drawing.Point(662, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 81);
            this.panel3.TabIndex = 159;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.Black;
            this.lbltotal.Location = new System.Drawing.Point(40, 30);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(115, 15);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "TOTAL DE VENDAS";
            // 
            // lblvendas
            // 
            this.lblvendas.AutoSize = true;
            this.lblvendas.BackColor = System.Drawing.Color.Transparent;
            this.lblvendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvendas.ForeColor = System.Drawing.Color.Black;
            this.lblvendas.Location = new System.Drawing.Point(89, 45);
            this.lblvendas.Name = "lblvendas";
            this.lblvendas.Size = new System.Drawing.Size(20, 18);
            this.lblvendas.TabIndex = 1;
            this.lblvendas.Text = "N";
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
            this.barra.TabIndex = 164;
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
            this.btnfiltrarPersonalizado.TabIndex = 176;
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
            this.btnfiltrarAno.TabIndex = 175;
            this.btnfiltrarAno.UseVisualStyleBackColor = false;
            this.btnfiltrarAno.Click += new System.EventHandler(this.btnfiltrarAno_Click);
            this.btnfiltrarAno.MouseEnter += new System.EventHandler(this.btnfiltrarAno_MouseEnter);
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
            this.btnfiltroMes.TabIndex = 174;
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
            this.btnfiltroSemana.TabIndex = 173;
            this.btnfiltroSemana.UseVisualStyleBackColor = false;
            this.btnfiltroSemana.Click += new System.EventHandler(this.btnfiltroSemana_Click);
            this.btnfiltroSemana.MouseEnter += new System.EventHandler(this.btnfiltroSemana_MouseEnter);
            this.btnfiltroSemana.MouseLeave += new System.EventHandler(this.btnfiltroSemana_MouseLeave);
            // 
            // lbllucrofiltro
            // 
            this.lbllucrofiltro.AutoSize = true;
            this.lbllucrofiltro.BackColor = System.Drawing.Color.Transparent;
            this.lbllucrofiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllucrofiltro.ForeColor = System.Drawing.Color.White;
            this.lbllucrofiltro.Location = new System.Drawing.Point(744, 289);
            this.lbllucrofiltro.Name = "lbllucrofiltro";
            this.lbllucrofiltro.Size = new System.Drawing.Size(20, 18);
            this.lbllucrofiltro.TabIndex = 177;
            this.lbllucrofiltro.Text = "N";
            // 
            // lblprecoTotal
            // 
            this.lblprecoTotal.AutoSize = true;
            this.lblprecoTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblprecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecoTotal.ForeColor = System.Drawing.Color.White;
            this.lblprecoTotal.Location = new System.Drawing.Point(535, 291);
            this.lblprecoTotal.Name = "lblprecoTotal";
            this.lblprecoTotal.Size = new System.Drawing.Size(181, 15);
            this.lblprecoTotal.TabIndex = 178;
            this.lblprecoTotal.Text = "TOTAL LUCRO (COM FILTROS)";
            // 
            // dtgvendas
            // 
            this.dtgvendas.AllowUserToAddRows = false;
            this.dtgvendas.BackgroundColor = System.Drawing.Color.Lavender;
            this.dtgvendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.extornar,
            this.cod,
            this.pagamento,
            this.desconto,
            this.totfinal,
            this.data});
            this.dtgvendas.Location = new System.Drawing.Point(0, 314);
            this.dtgvendas.Name = "dtgvendas";
            this.dtgvendas.ReadOnly = true;
            this.dtgvendas.RowHeadersWidth = 51;
            this.dtgvendas.Size = new System.Drawing.Size(863, 265);
            this.dtgvendas.TabIndex = 184;
            this.dtgvendas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgestoque_CellDoubleClick);
            this.dtgvendas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvendas_CellMouseClick);
            // 
            // extornar
            // 
            this.extornar.HeaderText = "";
            this.extornar.Image = global::TCC.Properties.Resources.estorno__1_1;
            this.extornar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.extornar.MinimumWidth = 6;
            this.extornar.Name = "extornar";
            this.extornar.ReadOnly = true;
            this.extornar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.extornar.Width = 50;
            // 
            // cod
            // 
            this.cod.HeaderText = "Código";
            this.cod.MinimumWidth = 6;
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Width = 116;
            // 
            // pagamento
            // 
            this.pagamento.HeaderText = "Método pg/t";
            this.pagamento.MinimumWidth = 6;
            this.pagamento.Name = "pagamento";
            this.pagamento.ReadOnly = true;
            this.pagamento.Width = 160;
            // 
            // desconto
            // 
            this.desconto.HeaderText = "Desconto";
            this.desconto.MinimumWidth = 6;
            this.desconto.Name = "desconto";
            this.desconto.ReadOnly = true;
            this.desconto.Width = 160;
            // 
            // totfinal
            // 
            this.totfinal.HeaderText = "Valor Total";
            this.totfinal.MinimumWidth = 6;
            this.totfinal.Name = "totfinal";
            this.totfinal.ReadOnly = true;
            this.totfinal.Width = 160;
            // 
            // data
            // 
            this.data.HeaderText = "Data da Venda";
            this.data.MinimumWidth = 6;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 160;
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
            this.btnexportarExcel.TabIndex = 186;
            this.btnexportarExcel.UseVisualStyleBackColor = false;
            this.btnexportarExcel.Click += new System.EventHandler(this.btnexportarExcel_Click);
            this.btnexportarExcel.MouseEnter += new System.EventHandler(this.btnexportarExcel_MouseEnter);
            this.btnexportarExcel.MouseLeave += new System.EventHandler(this.btnexportarExcel_MouseLeave);
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
            this.btnexportarPdf.TabIndex = 185;
            this.btnexportarPdf.UseVisualStyleBackColor = false;
            this.btnexportarPdf.MouseEnter += new System.EventHandler(this.btnexportarPdf_MouseEnter);
            this.btnexportarPdf.MouseLeave += new System.EventHandler(this.btnexportarPdf_MouseLeave);
            // 
            // pnitens
            // 
            this.pnitens.Controls.Add(this.panel5);
            this.pnitens.Controls.Add(this.dtgitens);
            this.pnitens.Location = new System.Drawing.Point(51, 630);
            this.pnitens.Margin = new System.Windows.Forms.Padding(2);
            this.pnitens.Name = "pnitens";
            this.pnitens.Size = new System.Drawing.Size(709, 261);
            this.pnitens.TabIndex = 187;
            this.pnitens.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(709, 32);
            this.panel5.TabIndex = 186;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(678, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dtgitens
            // 
            this.dtgitens.AllowUserToAddRows = false;
            this.dtgitens.BackgroundColor = System.Drawing.Color.Lavender;
            this.dtgitens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgitens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codIten,
            this.prod,
            this.tipo,
            this.modelo,
            this.quantidade,
            this.valvenda,
            this.tot});
            this.dtgitens.Location = new System.Drawing.Point(-13, 32);
            this.dtgitens.Name = "dtgitens";
            this.dtgitens.ReadOnly = true;
            this.dtgitens.RowHeadersWidth = 51;
            this.dtgitens.Size = new System.Drawing.Size(725, 229);
            this.dtgitens.TabIndex = 185;
            // 
            // codIten
            // 
            this.codIten.HeaderText = "Código";
            this.codIten.Name = "codIten";
            this.codIten.ReadOnly = true;
            this.codIten.Width = 70;
            // 
            // prod
            // 
            this.prod.HeaderText = "Nome Produto";
            this.prod.MinimumWidth = 6;
            this.prod.Name = "prod";
            this.prod.ReadOnly = true;
            this.prod.Width = 150;
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
            this.quantidade.Width = 70;
            // 
            // valvenda
            // 
            this.valvenda.FillWeight = 90F;
            this.valvenda.HeaderText = "Valor de Venda";
            this.valvenda.MinimumWidth = 6;
            this.valvenda.Name = "valvenda";
            this.valvenda.ReadOnly = true;
            this.valvenda.Width = 150;
            // 
            // tot
            // 
            this.tot.FillWeight = 90F;
            this.tot.HeaderText = "Total";
            this.tot.MinimumWidth = 6;
            this.tot.Name = "tot";
            this.tot.ReadOnly = true;
            this.tot.Width = 125;
            // 
            // timer1
            // 
            this.timer1.Interval = 50000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.pnfiltro.Location = new System.Drawing.Point(350, 62);
            this.pnfiltro.Name = "pnfiltro";
            this.pnfiltro.Size = new System.Drawing.Size(372, 229);
            this.pnfiltro.TabIndex = 188;
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
            // RelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(38)))));
            this.BackgroundImage = global::TCC.Properties.Resources._1555492a6_111;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(863, 654);
            this.Controls.Add(this.pnfiltro);
            this.Controls.Add(this.pnitens);
            this.Controls.Add(this.btnexportarExcel);
            this.Controls.Add(this.btnexportarPdf);
            this.Controls.Add(this.dtgvendas);
            this.Controls.Add(this.lbllucrofiltro);
            this.Controls.Add(this.lblprecoTotal);
            this.Controls.Add(this.btnfiltrarPersonalizado);
            this.Controls.Add(this.btnfiltrarAno);
            this.Controls.Add(this.btnfiltroMes);
            this.Controls.Add(this.btnfiltroSemana);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatorioVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioVendas";
            this.Load += new System.EventHandler(this.RelatorioVendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvendas)).EndInit();
            this.pnitens.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgitens)).EndInit();
            this.pnfiltro.ResumeLayout(false);
            this.pnfiltro.PerformLayout();
            this.pnvar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnfecharPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblsaida;
        private System.Windows.Forms.Label lbltot;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbloperacao;
        private System.Windows.Forms.Label lblopera;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblvendas;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSair;
        public System.Windows.Forms.Button btnfiltrarPersonalizado;
        public System.Windows.Forms.Button btnfiltrarAno;
        public System.Windows.Forms.Button btnfiltroMes;
        public System.Windows.Forms.Button btnfiltroSemana;
        private System.Windows.Forms.Label lbllucrofiltro;
        private System.Windows.Forms.Label lblprecoTotal;
        public System.Windows.Forms.DataGridView dtgvendas;
        public System.Windows.Forms.Button btnexportarExcel;
        public System.Windows.Forms.Button btnexportarPdf;
        private System.Windows.Forms.Panel pnitens;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.DataGridView dtgitens;
        private System.Windows.Forms.DataGridViewImageColumn extornar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn totfinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codIten;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valvenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn tot;
        private System.Windows.Forms.Panel pnfiltro;
        public System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.MaskedTextBox txtdataInicial;
        private System.Windows.Forms.Panel pnvar;
        private System.Windows.Forms.PictureBox btnfecharPanel;
        private System.Windows.Forms.MaskedTextBox txtdataFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
    }
}