
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnexportar = new System.Windows.Forms.Button();
            this.lblexportar = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo,
            this.dataLog,
            this.usuario,
            this.perfil});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgLogs.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtgLogs.Location = new System.Drawing.Point(-3, 412);
            this.dtgLogs.Margin = new System.Windows.Forms.Padding(5);
            this.dtgLogs.Name = "dtgLogs";
            this.dtgLogs.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgLogs.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgLogs.Size = new System.Drawing.Size(1150, 310);
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
            this.lblLogCadastro.Location = new System.Drawing.Point(20, 33);
            this.lblLogCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogCadastro.Name = "lblLogCadastro";
            this.lblLogCadastro.Size = new System.Drawing.Size(25, 24);
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
            this.lblExcluUsuario.Location = new System.Drawing.Point(23, 37);
            this.lblExcluUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExcluUsuario.Name = "lblExcluUsuario";
            this.lblExcluUsuario.Size = new System.Drawing.Size(25, 24);
            this.lblExcluUsuario.TabIndex = 2;
            this.lblExcluUsuario.Text = "N";
            // 
            // lblEditUsuario
            // 
            this.lblEditUsuario.AutoSize = true;
            this.lblEditUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblEditUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEditUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblEditUsuario.Location = new System.Drawing.Point(16, 39);
            this.lblEditUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditUsuario.Name = "lblEditUsuario";
            this.lblEditUsuario.Size = new System.Drawing.Size(25, 24);
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
            this.lblTotLogs.Location = new System.Drawing.Point(23, 39);
            this.lblTotLogs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotLogs.Name = "lblTotLogs";
            this.lblTotLogs.Size = new System.Drawing.Size(25, 24);
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
            this.lblpreferenciaSistema.Location = new System.Drawing.Point(748, 193);
            this.lblpreferenciaSistema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpreferenciaSistema.Name = "lblpreferenciaSistema";
            this.lblpreferenciaSistema.Size = new System.Drawing.Size(225, 26);
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
            this.lblalterarUsuario.Location = new System.Drawing.Point(221, 193);
            this.lblalterarUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblalterarUsuario.Name = "lblalterarUsuario";
            this.lblalterarUsuario.Size = new System.Drawing.Size(132, 26);
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
            this.btnalterarUsuario.Location = new System.Drawing.Point(161, 73);
            this.btnalterarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnalterarUsuario.Name = "btnalterarUsuario";
            this.btnalterarUsuario.Size = new System.Drawing.Size(248, 117);
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
            this.btnpreferenciaSistema.Location = new System.Drawing.Point(736, 73);
            this.btnpreferenciaSistema.Margin = new System.Windows.Forms.Padding(4);
            this.btnpreferenciaSistema.Name = "btnpreferenciaSistema";
            this.btnpreferenciaSistema.Size = new System.Drawing.Size(249, 117);
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
            this.panel3.Location = new System.Drawing.Point(-3, -12);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1153, 57);
            this.panel3.TabIndex = 51;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1068, 18);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(37, 34);
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
            this.btnSair.Location = new System.Drawing.Point(1113, 18);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(37, 34);
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
            this.panel1.Location = new System.Drawing.Point(16, 230);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 100);
            this.panel1.TabIndex = 52;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(76, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cadastros feitos ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblExcluUsuario);
            this.panel2.Location = new System.Drawing.Point(295, 230);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 100);
            this.panel2.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(73, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exclusões feitas ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(178)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblEditUsuario);
            this.panel4.Location = new System.Drawing.Point(584, 230);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(253, 100);
            this.panel4.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(89, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alterações feitas";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lblTotLogs);
            this.panel5.Location = new System.Drawing.Point(868, 230);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 100);
            this.panel5.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(79, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Operações feitas";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
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
            this.lblcadastros.Location = new System.Drawing.Point(15, 338);
            this.lblcadastros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcadastros.Name = "lblcadastros";
            this.lblcadastros.Size = new System.Drawing.Size(109, 16);
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
            this.btnfiltrarCadastros.Location = new System.Drawing.Point(27, 359);
            this.btnfiltrarCadastros.Margin = new System.Windows.Forms.Padding(4);
            this.btnfiltrarCadastros.Name = "btnfiltrarCadastros";
            this.btnfiltrarCadastros.Size = new System.Drawing.Size(85, 47);
            this.btnfiltrarCadastros.TabIndex = 173;
            this.btnfiltrarCadastros.UseVisualStyleBackColor = false;
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
            this.lblexclu.Location = new System.Drawing.Point(117, 340);
            this.lblexclu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblexclu.Name = "lblexclu";
            this.lblexclu.Size = new System.Drawing.Size(106, 16);
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
            this.btnfiltrarExclusoes.Location = new System.Drawing.Point(120, 353);
            this.btnfiltrarExclusoes.Margin = new System.Windows.Forms.Padding(4);
            this.btnfiltrarExclusoes.Name = "btnfiltrarExclusoes";
            this.btnfiltrarExclusoes.Size = new System.Drawing.Size(85, 53);
            this.btnfiltrarExclusoes.TabIndex = 175;
            this.btnfiltrarExclusoes.UseVisualStyleBackColor = false;
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
            this.lblalteracoes.Location = new System.Drawing.Point(205, 340);
            this.lblalteracoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblalteracoes.Name = "lblalteracoes";
            this.lblalteracoes.Size = new System.Drawing.Size(114, 16);
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
            this.btnfiltrarAlteracoes.Location = new System.Drawing.Point(213, 359);
            this.btnfiltrarAlteracoes.Margin = new System.Windows.Forms.Padding(4);
            this.btnfiltrarAlteracoes.Name = "btnfiltrarAlteracoes";
            this.btnfiltrarAlteracoes.Size = new System.Drawing.Size(85, 47);
            this.btnfiltrarAlteracoes.TabIndex = 177;
            this.btnfiltrarAlteracoes.UseVisualStyleBackColor = false;
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
            this.lbloperacoes.Location = new System.Drawing.Point(1013, 338);
            this.lbloperacoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbloperacoes.Name = "lbloperacoes";
            this.lbloperacoes.Size = new System.Drawing.Size(126, 16);
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
            this.btntodasAsOperacoes.Location = new System.Drawing.Point(1031, 359);
            this.btntodasAsOperacoes.Margin = new System.Windows.Forms.Padding(4);
            this.btntodasAsOperacoes.Name = "btntodasAsOperacoes";
            this.btntodasAsOperacoes.Size = new System.Drawing.Size(85, 47);
            this.btntodasAsOperacoes.TabIndex = 179;
            this.btntodasAsOperacoes.UseVisualStyleBackColor = false;
            this.btntodasAsOperacoes.Click += new System.EventHandler(this.btntodasAsOperacoes_Click);
            this.btntodasAsOperacoes.MouseEnter += new System.EventHandler(this.btntodasAsOperacoes_MouseEnter);
            this.btntodasAsOperacoes.MouseLeave += new System.EventHandler(this.btntodasAsOperacoes_MouseLeave);
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.Color.Transparent;
            this.btnexportar.BackgroundImage = global::TCC.Properties.Resources.exportar;
            this.btnexportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnexportar.FlatAppearance.BorderSize = 0;
            this.btnexportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportar.ForeColor = System.Drawing.Color.Black;
            this.btnexportar.Location = new System.Drawing.Point(1035, 750);
            this.btnexportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(85, 47);
            this.btnexportar.TabIndex = 181;
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.MouseEnter += new System.EventHandler(this.btnexportar_MouseEnter);
            this.btnexportar.MouseLeave += new System.EventHandler(this.btnexportar_MouseLeave);
            // 
            // lblexportar
            // 
            this.lblexportar.AutoSize = true;
            this.lblexportar.BackColor = System.Drawing.Color.Transparent;
            this.lblexportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblexportar.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Bold);
            this.lblexportar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblexportar.Location = new System.Drawing.Point(1035, 727);
            this.lblexportar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblexportar.Name = "lblexportar";
            this.lblexportar.Size = new System.Drawing.Size(90, 16);
            this.lblexportar.TabIndex = 183;
            this.lblexportar.Text = "Exportar Logs";
            this.lblexportar.Visible = false;
            // 
            // ConfigSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(38)))));
            this.BackgroundImage = global::TCC.Properties.Resources._1555492a6_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1151, 805);
            this.Controls.Add(this.lblexportar);
            this.Controls.Add(this.btnexportar);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.Label lblexportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfil;
    }
}