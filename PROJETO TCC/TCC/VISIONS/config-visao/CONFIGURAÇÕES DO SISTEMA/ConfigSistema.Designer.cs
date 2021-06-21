
namespace TCC.VISÃO
{
    partial class ConfigSistema
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigSistema));
            this.dtgLogs = new System.Windows.Forms.DataGridView();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLogCadastro = new System.Windows.Forms.Label();
            this.lblExcluUsuario = new System.Windows.Forms.Label();
            this.lblEditUsuario = new System.Windows.Forms.Label();
            this.lblTotLogs = new System.Windows.Forms.Label();
            this.lblpreferenciaSistema = new System.Windows.Forms.Label();
            this.lblalterarUsuario = new System.Windows.Forms.Label();
            this.btnalterarUsuario = new System.Windows.Forms.Button();
            this.btnpreferenciaSistema = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tccDataSet = new TCC.tccDataSet();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logsTableAdapter = new TCC.tccDataSetTableAdapters.logsTableAdapter();
            this.tccDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblcadastros = new System.Windows.Forms.Label();
            this.btnfiltrarCadastros = new System.Windows.Forms.Button();
            this.lblexclu = new System.Windows.Forms.Label();
            this.btnfiltrarExclusoes = new System.Windows.Forms.Button();
            this.lblalteracoes = new System.Windows.Forms.Label();
            this.btnfiltrarAlteracoes = new System.Windows.Forms.Button();
            this.lbloperacoes = new System.Windows.Forms.Label();
            this.btntodasAsOperacoes = new System.Windows.Forms.Button();
            this.lblexportar = new System.Windows.Forms.Label();
            this.btnbaixas = new System.Windows.Forms.Button();
            this.lblbaixas = new System.Windows.Forms.Label();
            this.btnexportarExcel = new System.Windows.Forms.Button();
            this.btnexportar = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnacessos = new System.Windows.Forms.Button();
            this.lblacessos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogs)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLogs
            // 
            this.dtgLogs.AllowUserToAddRows = false;
            this.dtgLogs.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo,
            this.dataLog,
            this.usuario,
            this.perfil});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgLogs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgLogs.Location = new System.Drawing.Point(-2, 335);
            this.dtgLogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgLogs.Name = "dtgLogs";
            this.dtgLogs.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgLogs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgLogs.Size = new System.Drawing.Size(862, 252);
            this.dtgLogs.TabIndex = 0;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 6;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 200;
            // 
            // dataLog
            // 
            this.dataLog.HeaderText = "DataLog";
            this.dataLog.MinimumWidth = 6;
            this.dataLog.Name = "dataLog";
            this.dataLog.ReadOnly = true;
            this.dataLog.Width = 200;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 262;
            // 
            // perfil
            // 
            this.perfil.HeaderText = "Perfil";
            this.perfil.MinimumWidth = 6;
            this.perfil.Name = "perfil";
            this.perfil.Width = 150;
            // 
            // lblLogCadastro
            // 
            this.lblLogCadastro.AutoSize = true;
            this.lblLogCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblLogCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogCadastro.ForeColor = System.Drawing.Color.Black;
            this.lblLogCadastro.Location = new System.Drawing.Point(15, 27);
            this.lblLogCadastro.Name = "lblLogCadastro";
            this.lblLogCadastro.Size = new System.Drawing.Size(20, 18);
            this.lblLogCadastro.TabIndex = 1;
            this.lblLogCadastro.Text = "N";
            this.lblLogCadastro.Click += new System.EventHandler(this.LogCadastro_Click);
            // 
            // lblExcluUsuario
            // 
            this.lblExcluUsuario.AutoSize = true;
            this.lblExcluUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblExcluUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblExcluUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblExcluUsuario.Location = new System.Drawing.Point(17, 30);
            this.lblExcluUsuario.Name = "lblExcluUsuario";
            this.lblExcluUsuario.Size = new System.Drawing.Size(20, 18);
            this.lblExcluUsuario.TabIndex = 2;
            this.lblExcluUsuario.Text = "N";
            // 
            // lblEditUsuario
            // 
            this.lblEditUsuario.AutoSize = true;
            this.lblEditUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblEditUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEditUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblEditUsuario.Location = new System.Drawing.Point(12, 32);
            this.lblEditUsuario.Name = "lblEditUsuario";
            this.lblEditUsuario.Size = new System.Drawing.Size(20, 18);
            this.lblEditUsuario.TabIndex = 3;
            this.lblEditUsuario.Text = "N";
            this.lblEditUsuario.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblTotLogs
            // 
            this.lblTotLogs.AutoSize = true;
            this.lblTotLogs.BackColor = System.Drawing.Color.Transparent;
            this.lblTotLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTotLogs.ForeColor = System.Drawing.Color.Black;
            this.lblTotLogs.Location = new System.Drawing.Point(17, 32);
            this.lblTotLogs.Name = "lblTotLogs";
            this.lblTotLogs.Size = new System.Drawing.Size(20, 18);
            this.lblTotLogs.TabIndex = 4;
            this.lblTotLogs.Text = "N";
            // 
            // lblpreferenciaSistema
            // 
            this.lblpreferenciaSistema.AutoSize = true;
            this.lblpreferenciaSistema.BackColor = System.Drawing.Color.Transparent;
            this.lblpreferenciaSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblpreferenciaSistema.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.lblpreferenciaSistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblpreferenciaSistema.Location = new System.Drawing.Point(561, 157);
            this.lblpreferenciaSistema.Name = "lblpreferenciaSistema";
            this.lblpreferenciaSistema.Size = new System.Drawing.Size(178, 20);
            this.lblpreferenciaSistema.TabIndex = 31;
            this.lblpreferenciaSistema.Text = "Preferências do Sistema";
            this.lblpreferenciaSistema.Visible = false;
            // 
            // lblalterarUsuario
            // 
            this.lblalterarUsuario.AutoSize = true;
            this.lblalterarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblalterarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblalterarUsuario.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.lblalterarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblalterarUsuario.Location = new System.Drawing.Point(166, 157);
            this.lblalterarUsuario.Name = "lblalterarUsuario";
            this.lblalterarUsuario.Size = new System.Drawing.Size(106, 20);
            this.lblalterarUsuario.TabIndex = 32;
            this.lblalterarUsuario.Text = "EditarUsuário";
            this.lblalterarUsuario.Visible = false;
            // 
            // btnalterarUsuario
            // 
            this.btnalterarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnalterarUsuario.BackgroundImage = global::TCC.Properties.Resources.blue_user_client_person_12581;
            this.btnalterarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnalterarUsuario.FlatAppearance.BorderSize = 0;
            this.btnalterarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnalterarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnalterarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalterarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnalterarUsuario.Location = new System.Drawing.Point(121, 59);
            this.btnalterarUsuario.Name = "btnalterarUsuario";
            this.btnalterarUsuario.Size = new System.Drawing.Size(186, 95);
            this.btnalterarUsuario.TabIndex = 23;
            this.btnalterarUsuario.UseVisualStyleBackColor = false;
            this.btnalterarUsuario.Click += new System.EventHandler(this.btnalterarUsuario_Click);
            this.btnalterarUsuario.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnalterarUsuario.MouseLeave += new System.EventHandler(this.btnalterarUsuario_MouseLeave);
            // 
            // btnpreferenciaSistema
            // 
            this.btnpreferenciaSistema.BackColor = System.Drawing.Color.Transparent;
            this.btnpreferenciaSistema.BackgroundImage = global::TCC.Properties.Resources.blue__12447;
            this.btnpreferenciaSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnpreferenciaSistema.FlatAppearance.BorderSize = 0;
            this.btnpreferenciaSistema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnpreferenciaSistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnpreferenciaSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpreferenciaSistema.ForeColor = System.Drawing.Color.Black;
            this.btnpreferenciaSistema.Location = new System.Drawing.Point(552, 59);
            this.btnpreferenciaSistema.Name = "btnpreferenciaSistema";
            this.btnpreferenciaSistema.Size = new System.Drawing.Size(187, 95);
            this.btnpreferenciaSistema.TabIndex = 22;
            this.btnpreferenciaSistema.UseVisualStyleBackColor = false;
            this.btnpreferenciaSistema.MouseEnter += new System.EventHandler(this.btnpreferenciaSistema_MouseEnter);
            this.btnpreferenciaSistema.MouseLeave += new System.EventHandler(this.btnpreferenciaSistema_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Location = new System.Drawing.Point(-2, -10);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 46);
            this.panel3.TabIndex = 51;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(801, 15);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 48;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(835, 15);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 28);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 49;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblLogCadastro);
            this.panel1.Location = new System.Drawing.Point(12, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 81);
            this.panel1.TabIndex = 52;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(57, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cadastros feitos ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblExcluUsuario);
            this.panel2.Location = new System.Drawing.Point(221, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 81);
            this.panel2.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exclusões feitas ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(178)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblEditUsuario);
            this.panel4.Location = new System.Drawing.Point(438, 187);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 81);
            this.panel4.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(67, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alterações feitas";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lblTotLogs);
            this.panel5.Location = new System.Drawing.Point(651, 187);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 81);
            this.panel5.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(59, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Operações feitas";
            // 
            // timer1
            // 
            this.timer1.Interval = 50000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tccDataSet
            // 
            this.tccDataSet.DataSetName = "tccDataSet";
            this.tccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logsBindingSource
            // 
            this.logsBindingSource.DataMember = "logs";
            this.logsBindingSource.DataSource = this.tccDataSet;
            // 
            // logsTableAdapter
            // 
            this.logsTableAdapter.ClearBeforeFill = true;
            // 
            // tccDataSetBindingSource
            // 
            this.tccDataSetBindingSource.DataSource = this.tccDataSet;
            this.tccDataSetBindingSource.Position = 0;
            // 
            // lblcadastros
            // 
            this.lblcadastros.AutoSize = true;
            this.lblcadastros.BackColor = System.Drawing.Color.Transparent;
            this.lblcadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblcadastros.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Bold);
            this.lblcadastros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcadastros.Location = new System.Drawing.Point(11, 275);
            this.lblcadastros.Name = "lblcadastros";
            this.lblcadastros.Size = new System.Drawing.Size(93, 14);
            this.lblcadastros.TabIndex = 174;
            this.lblcadastros.Text = "Filtrar Cadastros";
            this.lblcadastros.Visible = false;
            // 
            // btnfiltrarCadastros
            // 
            this.btnfiltrarCadastros.BackColor = System.Drawing.Color.Transparent;
            this.btnfiltrarCadastros.BackgroundImage = global::TCC.Properties.Resources.DocumentEdit_40924;
            this.btnfiltrarCadastros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfiltrarCadastros.FlatAppearance.BorderSize = 0;
            this.btnfiltrarCadastros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnfiltrarCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnfiltrarCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfiltrarCadastros.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltrarCadastros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnfiltrarCadastros.Location = new System.Drawing.Point(20, 292);
            this.btnfiltrarCadastros.Name = "btnfiltrarCadastros";
            this.btnfiltrarCadastros.Size = new System.Drawing.Size(64, 38);
            this.btnfiltrarCadastros.TabIndex = 173;
            this.btnfiltrarCadastros.UseVisualStyleBackColor = false;
            this.btnfiltrarCadastros.Click += new System.EventHandler(this.btnfiltrarCadastros_Click);
            this.btnfiltrarCadastros.MouseEnter += new System.EventHandler(this.btnfiltrarCadastros_MouseEnter);
            this.btnfiltrarCadastros.MouseLeave += new System.EventHandler(this.btnfiltrarCadastros_MouseLeave);
            // 
            // lblexclu
            // 
            this.lblexclu.AutoSize = true;
            this.lblexclu.BackColor = System.Drawing.Color.Transparent;
            this.lblexclu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblexclu.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Bold);
            this.lblexclu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblexclu.Location = new System.Drawing.Point(88, 276);
            this.lblexclu.Name = "lblexclu";
            this.lblexclu.Size = new System.Drawing.Size(90, 14);
            this.lblexclu.TabIndex = 176;
            this.lblexclu.Text = "Filtrar Exclusões";
            this.lblexclu.Visible = false;
            // 
            // btnfiltrarExclusoes
            // 
            this.btnfiltrarExclusoes.BackColor = System.Drawing.Color.Transparent;
            this.btnfiltrarExclusoes.BackgroundImage = global::TCC.Properties.Resources.icons8_lixeira_vazia_96_removebg_preview;
            this.btnfiltrarExclusoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfiltrarExclusoes.FlatAppearance.BorderSize = 0;
            this.btnfiltrarExclusoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnfiltrarExclusoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnfiltrarExclusoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfiltrarExclusoes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltrarExclusoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnfiltrarExclusoes.Location = new System.Drawing.Point(90, 287);
            this.btnfiltrarExclusoes.Name = "btnfiltrarExclusoes";
            this.btnfiltrarExclusoes.Size = new System.Drawing.Size(64, 43);
            this.btnfiltrarExclusoes.TabIndex = 175;
            this.btnfiltrarExclusoes.UseVisualStyleBackColor = false;
            this.btnfiltrarExclusoes.Click += new System.EventHandler(this.btnfiltrarExclusoes_Click);
            this.btnfiltrarExclusoes.MouseEnter += new System.EventHandler(this.btnfiltrarExclusoes_MouseEnter);
            this.btnfiltrarExclusoes.MouseLeave += new System.EventHandler(this.btnfiltrarExclusoes_MouseLeave);
            // 
            // lblalteracoes
            // 
            this.lblalteracoes.AutoSize = true;
            this.lblalteracoes.BackColor = System.Drawing.Color.Transparent;
            this.lblalteracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblalteracoes.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Bold);
            this.lblalteracoes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblalteracoes.Location = new System.Drawing.Point(154, 276);
            this.lblalteracoes.Name = "lblalteracoes";
            this.lblalteracoes.Size = new System.Drawing.Size(97, 14);
            this.lblalteracoes.TabIndex = 178;
            this.lblalteracoes.Text = "Filtrar Alterações";
            this.lblalteracoes.Visible = false;
            // 
            // btnfiltrarAlteracoes
            // 
            this.btnfiltrarAlteracoes.BackColor = System.Drawing.Color.Transparent;
            this.btnfiltrarAlteracoes.BackgroundImage = global::TCC.Properties.Resources.troca;
            this.btnfiltrarAlteracoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfiltrarAlteracoes.FlatAppearance.BorderSize = 0;
            this.btnfiltrarAlteracoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnfiltrarAlteracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnfiltrarAlteracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfiltrarAlteracoes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltrarAlteracoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnfiltrarAlteracoes.Location = new System.Drawing.Point(160, 292);
            this.btnfiltrarAlteracoes.Name = "btnfiltrarAlteracoes";
            this.btnfiltrarAlteracoes.Size = new System.Drawing.Size(64, 38);
            this.btnfiltrarAlteracoes.TabIndex = 177;
            this.btnfiltrarAlteracoes.UseVisualStyleBackColor = false;
            this.btnfiltrarAlteracoes.Click += new System.EventHandler(this.btnfiltrarAlteracoes_Click);
            this.btnfiltrarAlteracoes.MouseEnter += new System.EventHandler(this.btnfiltrarAlteracoes_MouseEnter);
            this.btnfiltrarAlteracoes.MouseLeave += new System.EventHandler(this.btnfiltrarAlteracoes_MouseLeave);
            // 
            // lbloperacoes
            // 
            this.lbloperacoes.AutoSize = true;
            this.lbloperacoes.BackColor = System.Drawing.Color.Transparent;
            this.lbloperacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbloperacoes.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Bold);
            this.lbloperacoes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbloperacoes.Location = new System.Drawing.Point(358, 276);
            this.lbloperacoes.Name = "lbloperacoes";
            this.lbloperacoes.Size = new System.Drawing.Size(106, 14);
            this.lbloperacoes.TabIndex = 180;
            this.lbloperacoes.Text = "Todas as Operações";
            this.lbloperacoes.Visible = false;
            // 
            // btntodasAsOperacoes
            // 
            this.btntodasAsOperacoes.BackColor = System.Drawing.Color.Transparent;
            this.btntodasAsOperacoes.BackgroundImage = global::TCC.Properties.Resources.sistema;
            this.btntodasAsOperacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btntodasAsOperacoes.FlatAppearance.BorderSize = 0;
            this.btntodasAsOperacoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btntodasAsOperacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btntodasAsOperacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntodasAsOperacoes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntodasAsOperacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btntodasAsOperacoes.Location = new System.Drawing.Point(369, 292);
            this.btntodasAsOperacoes.Name = "btntodasAsOperacoes";
            this.btntodasAsOperacoes.Size = new System.Drawing.Size(64, 38);
            this.btntodasAsOperacoes.TabIndex = 179;
            this.btntodasAsOperacoes.UseVisualStyleBackColor = false;
            this.btntodasAsOperacoes.Click += new System.EventHandler(this.btntodasAsOperacoes_Click);
            this.btntodasAsOperacoes.MouseEnter += new System.EventHandler(this.btntodasAsOperacoes_MouseEnter);
            this.btntodasAsOperacoes.MouseLeave += new System.EventHandler(this.btntodasAsOperacoes_MouseLeave);
            // 
            // lblexportar
            // 
            this.lblexportar.AutoSize = true;
            this.lblexportar.BackColor = System.Drawing.Color.Transparent;
            this.lblexportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblexportar.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Bold);
            this.lblexportar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblexportar.Location = new System.Drawing.Point(776, 591);
            this.lblexportar.Name = "lblexportar";
            this.lblexportar.Size = new System.Drawing.Size(75, 14);
            this.lblexportar.TabIndex = 183;
            this.lblexportar.Text = "Exportar Logs";
            this.lblexportar.Visible = false;
            // 
            // btnbaixas
            // 
            this.btnbaixas.BackColor = System.Drawing.Color.Transparent;
            this.btnbaixas.BackgroundImage = global::TCC.Properties.Resources.dropbox_icon_icons_com_72004__1_;
            this.btnbaixas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbaixas.FlatAppearance.BorderSize = 0;
            this.btnbaixas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnbaixas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnbaixas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbaixas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbaixas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnbaixas.Location = new System.Drawing.Point(230, 292);
            this.btnbaixas.Name = "btnbaixas";
            this.btnbaixas.Size = new System.Drawing.Size(64, 38);
            this.btnbaixas.TabIndex = 184;
            this.btnbaixas.UseVisualStyleBackColor = false;
            this.btnbaixas.Click += new System.EventHandler(this.btnbaixas_Click);
            this.btnbaixas.MouseEnter += new System.EventHandler(this.btnbaixas_MouseEnter);
            this.btnbaixas.MouseLeave += new System.EventHandler(this.btnbaixas_MouseLeave);
            // 
            // lblbaixas
            // 
            this.lblbaixas.AutoSize = true;
            this.lblbaixas.BackColor = System.Drawing.Color.Transparent;
            this.lblbaixas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblbaixas.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Bold);
            this.lblbaixas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblbaixas.Location = new System.Drawing.Point(227, 276);
            this.lblbaixas.Name = "lblbaixas";
            this.lblbaixas.Size = new System.Drawing.Size(76, 14);
            this.lblbaixas.TabIndex = 185;
            this.lblbaixas.Text = "Filtrar Baixas";
            this.lblbaixas.Visible = false;
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
            this.btnexportarExcel.Location = new System.Drawing.Point(696, 609);
            this.btnexportarExcel.Name = "btnexportarExcel";
            this.btnexportarExcel.Size = new System.Drawing.Size(74, 40);
            this.btnexportarExcel.TabIndex = 186;
            this.btnexportarExcel.UseVisualStyleBackColor = false;
            this.btnexportarExcel.Click += new System.EventHandler(this.btnexportarExcel_Click);
            this.btnexportarExcel.MouseEnter += new System.EventHandler(this.btnexportarExcel_MouseEnter);
            this.btnexportarExcel.MouseLeave += new System.EventHandler(this.btnexportarExcel_MouseLeave);
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.Color.Transparent;
            this.btnexportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexportar.BackgroundImage")));
            this.btnexportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnexportar.FlatAppearance.BorderSize = 0;
            this.btnexportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.ForeColor = System.Drawing.Color.Transparent;
            this.btnexportar.Location = new System.Drawing.Point(776, 609);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(81, 40);
            this.btnexportar.TabIndex = 187;
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.MouseEnter += new System.EventHandler(this.btnexportar_MouseEnter);
            this.btnexportar.MouseLeave += new System.EventHandler(this.btnexportar_MouseLeave);
            // 
            // txtuser
            // 
            this.txtuser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtuser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtuser.Location = new System.Drawing.Point(651, 301);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(167, 30);
            this.txtuser.TabIndex = 188;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.BackgroundImage = global::TCC.Properties.Resources.icons8_pesquisar_481;
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnbuscar.Location = new System.Drawing.Point(824, 305);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(28, 23);
            this.btnbuscar.TabIndex = 189;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            this.btnbuscar.MouseEnter += new System.EventHandler(this.btnbuscar_MouseEnter);
            this.btnbuscar.MouseLeave += new System.EventHandler(this.btnbuscar_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(650, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 14);
            this.label4.TabIndex = 190;
            this.label4.Text = "Buscar por Usuário :";
            // 
            // btnacessos
            // 
            this.btnacessos.BackColor = System.Drawing.Color.Transparent;
            this.btnacessos.BackgroundImage = global::TCC.Properties.Resources.avatardefault_92824;
            this.btnacessos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnacessos.FlatAppearance.BorderSize = 0;
            this.btnacessos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnacessos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnacessos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacessos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacessos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnacessos.Location = new System.Drawing.Point(299, 292);
            this.btnacessos.Name = "btnacessos";
            this.btnacessos.Size = new System.Drawing.Size(64, 38);
            this.btnacessos.TabIndex = 191;
            this.btnacessos.UseVisualStyleBackColor = false;
            this.btnacessos.Click += new System.EventHandler(this.btnacessos_Click);
            this.btnacessos.MouseEnter += new System.EventHandler(this.btnacessos_MouseEnter);
            this.btnacessos.MouseLeave += new System.EventHandler(this.btnacessos_MouseLeave);
            // 
            // lblacessos
            // 
            this.lblacessos.AutoSize = true;
            this.lblacessos.BackColor = System.Drawing.Color.Transparent;
            this.lblacessos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblacessos.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Bold);
            this.lblacessos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblacessos.Location = new System.Drawing.Point(293, 276);
            this.lblacessos.Name = "lblacessos";
            this.lblacessos.Size = new System.Drawing.Size(82, 14);
            this.lblacessos.TabIndex = 192;
            this.lblacessos.Text = "Filtrar Acessos";
            this.lblacessos.Visible = false;
            // 
            // ConfigSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(38)))));
            this.BackgroundImage = global::TCC.Properties.Resources._1555492a6_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(863, 654);
            this.Controls.Add(this.lblacessos);
            this.Controls.Add(this.btnacessos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.btnexportarExcel);
            this.Controls.Add(this.lblbaixas);
            this.Controls.Add(this.btnbaixas);
            this.Controls.Add(this.lblexportar);
            this.Controls.Add(this.lbloperacoes);
            this.Controls.Add(this.btntodasAsOperacoes);
            this.Controls.Add(this.lblalteracoes);
            this.Controls.Add(this.btnfiltrarAlteracoes);
            this.Controls.Add(this.lblexclu);
            this.Controls.Add(this.btnfiltrarExclusoes);
            this.Controls.Add(this.lblcadastros);
            this.Controls.Add(this.btnfiltrarCadastros);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblalterarUsuario);
            this.Controls.Add(this.lblpreferenciaSistema);
            this.Controls.Add(this.btnalterarUsuario);
            this.Controls.Add(this.btnpreferenciaSistema);
            this.Controls.Add(this.dtgLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N";
            this.Load += new System.EventHandler(this.ConfigSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogs)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLogs;
        private System.Windows.Forms.Label lblLogCadastro;
        private System.Windows.Forms.Label lblExcluUsuario;
        private System.Windows.Forms.Label lblEditUsuario;
        private System.Windows.Forms.Label lblTotLogs;
        private System.Windows.Forms.Button btnpreferenciaSistema;
        private System.Windows.Forms.Button btnalterarUsuario;
        private System.Windows.Forms.Label lblpreferenciaSistema;
        private System.Windows.Forms.Label lblalterarUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSair;
        private tccDataSet tccDataSet;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private tccDataSetTableAdapters.logsTableAdapter logsTableAdapter;
        private System.Windows.Forms.BindingSource tccDataSetBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblcadastros;
        private System.Windows.Forms.Button btnfiltrarCadastros;
        private System.Windows.Forms.Label lblexclu;
        private System.Windows.Forms.Button btnfiltrarExclusoes;
        private System.Windows.Forms.Label lblalteracoes;
        private System.Windows.Forms.Button btnfiltrarAlteracoes;
        private System.Windows.Forms.Label lbloperacoes;
        private System.Windows.Forms.Button btntodasAsOperacoes;
        private System.Windows.Forms.Label lblexportar;
        private System.Windows.Forms.Button btnbaixas;
        private System.Windows.Forms.Label lblbaixas;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfil;
        public System.Windows.Forms.Button btnexportarExcel;
        public System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnacessos;
        private System.Windows.Forms.Label lblacessos;
    }
}