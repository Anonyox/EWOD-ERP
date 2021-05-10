namespace TCC.VISÃO
{
    partial class CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtnomeProduto = new System.Windows.Forms.TextBox();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtvalordevenda = new System.Windows.Forms.TextBox();
            this.txtvalordecompra = new System.Windows.Forms.TextBox();
            this.txtquantidadeprodutocadastra = new System.Windows.Forms.TextBox();
            this.txtcadastroproduto = new System.Windows.Forms.TextBox();
            this.txtcodigoprodutocadastro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnpesqisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.barra = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblconfirmar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BackgroundImage = global::TCC.Properties.Resources.icons8_botão_de_opção_marcado_48;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnConfirmar.Location = new System.Drawing.Point(212, 389);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(64, 38);
            this.btnConfirmar.TabIndex = 157;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.MouseEnter += new System.EventHandler(this.btnConfirmar_MouseEnter);
            this.btnConfirmar.MouseLeave += new System.EventHandler(this.btnConfirmar_MouseLeave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::TCC.Properties.Resources.icons8_cancelar_48;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(282, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 38);
            this.btnCancelar.TabIndex = 156;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtnomeProduto
            // 
            this.txtnomeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtnomeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtnomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomeProduto.Location = new System.Drawing.Point(122, 118);
            this.txtnomeProduto.Name = "txtnomeProduto";
            this.txtnomeProduto.Size = new System.Drawing.Size(304, 20);
            this.txtnomeProduto.TabIndex = 107;
            // 
            // txtcep
            // 
            this.txtcep.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcep.Location = new System.Drawing.Point(566, 303);
            this.txtcep.Mask = "00/00/0000";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(112, 30);
            this.txtcep.TabIndex = 105;
            this.txtcep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(502, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 104;
            this.label9.Text = "Data :";
            // 
            // cmbtipo
            // 
            this.cmbtipo.Enabled = false;
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Location = new System.Drawing.Point(566, 154);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(100, 21);
            this.cmbtipo.TabIndex = 102;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(41, 68);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(710, 20);
            this.textBox6.TabIndex = 101;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtvalordevenda
            // 
            this.txtvalordevenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvalordevenda.Enabled = false;
            this.txtvalordevenda.Location = new System.Drawing.Point(122, 144);
            this.txtvalordevenda.Name = "txtvalordevenda";
            this.txtvalordevenda.Size = new System.Drawing.Size(100, 20);
            this.txtvalordevenda.TabIndex = 98;
            // 
            // txtvalordecompra
            // 
            this.txtvalordecompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvalordecompra.Enabled = false;
            this.txtvalordecompra.Location = new System.Drawing.Point(566, 259);
            this.txtvalordecompra.Name = "txtvalordecompra";
            this.txtvalordecompra.Size = new System.Drawing.Size(112, 20);
            this.txtvalordecompra.TabIndex = 97;
            // 
            // txtquantidadeprodutocadastra
            // 
            this.txtquantidadeprodutocadastra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtquantidadeprodutocadastra.Enabled = false;
            this.txtquantidadeprodutocadastra.Location = new System.Drawing.Point(176, 308);
            this.txtquantidadeprodutocadastra.Name = "txtquantidadeprodutocadastra";
            this.txtquantidadeprodutocadastra.Size = new System.Drawing.Size(100, 20);
            this.txtquantidadeprodutocadastra.TabIndex = 96;
            // 
            // txtcadastroproduto
            // 
            this.txtcadastroproduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcadastroproduto.Enabled = false;
            this.txtcadastroproduto.Location = new System.Drawing.Point(566, 122);
            this.txtcadastroproduto.Name = "txtcadastroproduto";
            this.txtcadastroproduto.Size = new System.Drawing.Size(288, 20);
            this.txtcadastroproduto.TabIndex = 95;
            // 
            // txtcodigoprodutocadastro
            // 
            this.txtcodigoprodutocadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigoprodutocadastro.Enabled = false;
            this.txtcodigoprodutocadastro.Location = new System.Drawing.Point(178, 262);
            this.txtcodigoprodutocadastro.Name = "txtcodigoprodutocadastro";
            this.txtcodigoprodutocadastro.Size = new System.Drawing.Size(100, 20);
            this.txtcodigoprodutocadastro.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(506, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 92;
            this.label4.Text = "Tipo :";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::TCC.Properties.Resources.icons8_lixeira_vazia_48;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button5.Location = new System.Drawing.Point(142, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 38);
            this.button5.TabIndex = 91;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::TCC.Properties.Resources.icons8_editar_propriedade_100;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button4.Location = new System.Drawing.Point(2, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 34);
            this.button4.TabIndex = 90;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::TCC.Properties.Resources.icons8_salvar_48;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button3.Location = new System.Drawing.Point(72, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 38);
            this.button3.TabIndex = 89;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnpesqisar
            // 
            this.btnpesqisar.BackColor = System.Drawing.Color.Transparent;
            this.btnpesqisar.BackgroundImage = global::TCC.Properties.Resources.icons8_pesquisar_481;
            this.btnpesqisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnpesqisar.FlatAppearance.BorderSize = 0;
            this.btnpesqisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnpesqisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnpesqisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpesqisar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesqisar.ForeColor = System.Drawing.Color.Transparent;
            this.btnpesqisar.Location = new System.Drawing.Point(762, 63);
            this.btnpesqisar.Name = "btnpesqisar";
            this.btnpesqisar.Size = new System.Drawing.Size(44, 30);
            this.btnpesqisar.TabIndex = 86;
            this.btnpesqisar.UseVisualStyleBackColor = false;
            this.btnpesqisar.MouseEnter += new System.EventHandler(this.btnpesqisar_MouseEnter);
            this.btnpesqisar.MouseLeave += new System.EventHandler(this.btnpesqisar_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 429);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(864, 228);
            this.dataGridView1.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(456, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 21);
            this.label7.TabIndex = 80;
            this.label7.Text = "Fornecedor :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(60, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 74;
            this.label6.Text = "COD :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(28, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 21);
            this.label5.TabIndex = 67;
            this.label5.Text = "Valor de Compra :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(37, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 59;
            this.label3.Text = "Valor de Venda :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(454, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 58;
            this.label2.Text = "Quantidade :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(37, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 57;
            this.label1.Text = "Produto :";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(790, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 61;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(826, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 28);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 60;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            this.barra.TabIndex = 62;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(2, 204);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 21);
            this.panel1.TabIndex = 158;
            // 
            // lblconfirmar
            // 
            this.lblconfirmar.AutoSize = true;
            this.lblconfirmar.BackColor = System.Drawing.Color.Transparent;
            this.lblconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblconfirmar.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Bold);
            this.lblconfirmar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblconfirmar.Location = new System.Drawing.Point(221, 372);
            this.lblconfirmar.Name = "lblconfirmar";
            this.lblconfirmar.Size = new System.Drawing.Size(55, 14);
            this.lblconfirmar.TabIndex = 172;
            this.lblconfirmar.Text = "Confirmar";
            this.lblconfirmar.Visible = false;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(38)))));
            this.BackgroundImage = global::TCC.Properties.Resources._1555492a6_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(863, 654);
            this.Controls.Add(this.lblconfirmar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtvalordevenda);
            this.Controls.Add(this.txtnomeProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.cmbtipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtcadastroproduto);
            this.Controls.Add(this.btnpesqisar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtvalordecompra);
            this.Controls.Add(this.txtcodigoprodutocadastro);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtquantidadeprodutocadastra);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRARPRODUTO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CADASTRARPRODUTO_FormClosed);
            this.Load += new System.EventHandler(this.CadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.barra.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtvalordevenda;
        private System.Windows.Forms.TextBox txtvalordecompra;
        private System.Windows.Forms.TextBox txtquantidadeprodutocadastra;
        private System.Windows.Forms.TextBox txtcadastroproduto;
        private System.Windows.Forms.TextBox txtcodigoprodutocadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnpesqisar;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.TextBox txtnomeProduto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblconfirmar;
    }
}