
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
            this.tccDataSet = new TCC.tccDataSet();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logsTableAdapter = new TCC.tccDataSetTableAdapters.logsTableAdapter();
            this.tccDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogs)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgLogs
            // 
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
            this.dtgLogs.Location = new System.Drawing.Point(-3, 416);
            this.dtgLogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgLogs.Name = "dtgLogs";
            this.dtgLogs.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgLogs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgLogs.Size = new System.Drawing.Size(1153, 257);
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
            this.perfil.Width = 125;
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
            this.lblpreferenciaSistema.Location = new System.Drawing.Point(703, 214);
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
            this.lblalterarUsuario.Location = new System.Drawing.Point(255, 214);
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
            this.btnalterarUsuario.Location = new System.Drawing.Point(207, 94);
            this.btnalterarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnpreferenciaSistema.Location = new System.Drawing.Point(691, 94);
            this.btnpreferenciaSistema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.panel3.Location = new System.Drawing.Point(-3, 1);
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
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(37, 34);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 48;
            this.btnMinimizar.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1113, 18);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(37, 34);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 49;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblLogCadastro);
            this.panel1.Location = new System.Drawing.Point(16, 309);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.panel2.Location = new System.Drawing.Point(295, 309);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.panel4.Location = new System.Drawing.Point(584, 309);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label2.Location = new System.Drawing.Point(103, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edições feitas";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lblTotLogs);
            this.panel5.Location = new System.Drawing.Point(868, 309);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // ConfigSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(38)))));
            this.BackgroundImage = global::TCC.Properties.Resources._1555492a6_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1151, 673);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConfigSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N";
            this.Load += new System.EventHandler(this.ConfigSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogs)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfil;
    }
}