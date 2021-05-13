
namespace TCC.VISÃO
{
    partial class AlterarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarUsuario));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lsbNomeUsuario = new System.Windows.Forms.ListBox();
            this.lblSenhaAdm = new System.Windows.Forms.Label();
            this.txtSenhaAdm = new System.Windows.Forms.TextBox();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.tccDataSet = new TCC.tccDataSet();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logsTableAdapter = new TCC.tccDataSetTableAdapters.logsTableAdapter();
            //this.tccDataSet1 = new TCC.tccDataSet1();
            this.tccDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.loginsTableAdapter = new TCC.tccDataSet1TableAdapters.loginsTableAdapter();
            this.lblExcluirUsuario = new System.Windows.Forms.Label();
            this.btnEditData = new System.Windows.Forms.Button();
            this.btnConfirmarExcluirUser = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblEditData = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.tccDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Location = new System.Drawing.Point(1, -3);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 46);
            this.panel3.TabIndex = 52;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(800, 11);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 48;
            this.btnMinimizar.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(834, 11);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 28);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 49;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNomeUsuario.Location = new System.Drawing.Point(9, 257);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(92, 13);
            this.lblNomeUsuario.TabIndex = 55;
            this.lblNomeUsuario.Text = "Nome do Usuário ";
            this.lblNomeUsuario.Visible = false;
            // 
            // lsbNomeUsuario
            // 
            this.lsbNomeUsuario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.loginsBindingSource, "usuario", true));
            this.lsbNomeUsuario.DataSource = this.loginsBindingSource;
            this.lsbNomeUsuario.DisplayMember = "usuario";
            this.lsbNomeUsuario.FormattingEnabled = true;
            this.lsbNomeUsuario.Location = new System.Drawing.Point(107, 257);
            this.lsbNomeUsuario.Name = "lsbNomeUsuario";
            this.lsbNomeUsuario.Size = new System.Drawing.Size(91, 17);
            this.lsbNomeUsuario.TabIndex = 56;
            this.lsbNomeUsuario.ValueMember = "usuario";
            this.lsbNomeUsuario.Visible = false;
            // 
            // lblSenhaAdm
            // 
            this.lblSenhaAdm.AutoSize = true;
            this.lblSenhaAdm.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaAdm.ForeColor = System.Drawing.Color.White;
            this.lblSenhaAdm.Location = new System.Drawing.Point(9, 304);
            this.lblSenhaAdm.Name = "lblSenhaAdm";
            this.lblSenhaAdm.Size = new System.Drawing.Size(122, 13);
            this.lblSenhaAdm.TabIndex = 57;
            this.lblSenhaAdm.Text = "Senha do Administrador ";
            this.lblSenhaAdm.Visible = false;
            // 
            // txtSenhaAdm
            // 
            this.txtSenhaAdm.Location = new System.Drawing.Point(137, 301);
            this.txtSenhaAdm.Name = "txtSenhaAdm";
            this.txtSenhaAdm.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaAdm.TabIndex = 58;
            this.txtSenhaAdm.Visible = false;
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirUsuario.BackgroundImage")));
            this.btnExcluirUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluirUsuario.FlatAppearance.BorderSize = 0;
            this.btnExcluirUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExcluirUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExcluirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirUsuario.Location = new System.Drawing.Point(107, 257);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(186, 95);
            this.btnExcluirUsuario.TabIndex = 59;
            this.btnExcluirUsuario.UseVisualStyleBackColor = false;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            this.btnExcluirUsuario.MouseEnter += new System.EventHandler(this.btnExcluirUsuario_MouseEnter);
            this.btnExcluirUsuario.MouseLeave += new System.EventHandler(this.btnExcluirUsuario_MouseLeave);
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
            // tccDataSet1
            // 
            //this.tccDataSet1.DataSetName = "tccDataSet1";
            //this.tccDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tccDataSet1BindingSource
            // 
            //this.tccDataSet1BindingSource.DataSource = this.tccDataSet1;
            this.tccDataSet1BindingSource.Position = 0;
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "logins";
            this.loginsBindingSource.DataSource = this.tccDataSet1BindingSource;
            // 
            // loginsTableAdapter
            // 
            //this.loginsTableAdapter.ClearBeforeFill = true;
            // 
            // lblExcluirUsuario
            // 
            this.lblExcluirUsuario.AutoSize = true;
            this.lblExcluirUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblExcluirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExcluirUsuario.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.lblExcluirUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblExcluirUsuario.Location = new System.Drawing.Point(147, 373);
            this.lblExcluirUsuario.Name = "lblExcluirUsuario";
            this.lblExcluirUsuario.Size = new System.Drawing.Size(119, 20);
            this.lblExcluirUsuario.TabIndex = 60;
            this.lblExcluirUsuario.Text = "Excluir Usuário ";
            this.lblExcluirUsuario.Visible = false;
            // 
            // btnEditData
            // 
            this.btnEditData.BackColor = System.Drawing.Color.Transparent;
            this.btnEditData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditData.BackgroundImage")));
            this.btnEditData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditData.FlatAppearance.BorderSize = 0;
            this.btnEditData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditData.ForeColor = System.Drawing.Color.Black;
            this.btnEditData.Location = new System.Drawing.Point(330, 263);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(186, 95);
            this.btnEditData.TabIndex = 61;
            this.btnEditData.UseVisualStyleBackColor = false;
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            this.btnEditData.MouseEnter += new System.EventHandler(this.btnEditData_MouseEnter);
            this.btnEditData.MouseLeave += new System.EventHandler(this.btnEditData_MouseLeave);
            // 
            // btnConfirmarExcluirUser
            // 
            this.btnConfirmarExcluirUser.Location = new System.Drawing.Point(12, 361);
            this.btnConfirmarExcluirUser.Name = "btnConfirmarExcluirUser";
            this.btnConfirmarExcluirUser.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarExcluirUser.TabIndex = 62;
            this.btnConfirmarExcluirUser.Text = "Confirmar ";
            this.btnConfirmarExcluirUser.UseVisualStyleBackColor = true;
            this.btnConfirmarExcluirUser.Visible = false;
            this.btnConfirmarExcluirUser.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(107, 361);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 63;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Visible = false;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lblEditData
            // 
            this.lblEditData.AutoSize = true;
            this.lblEditData.BackColor = System.Drawing.Color.Transparent;
            this.lblEditData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEditData.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.lblEditData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEditData.Location = new System.Drawing.Point(364, 373);
            this.lblEditData.Name = "lblEditData";
            this.lblEditData.Size = new System.Drawing.Size(104, 20);
            this.lblEditData.TabIndex = 64;
            this.lblEditData.Text = "Editar Dados ";
            this.lblEditData.Visible = false;
            // 
            // AlterarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(38)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(863, 547);
            this.Controls.Add(this.lblEditData);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConfirmarExcluirUser);
            this.Controls.Add(this.txtSenhaAdm);
            this.Controls.Add(this.lblSenhaAdm);
            this.Controls.Add(this.lsbNomeUsuario);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.btnEditData);
            this.Controls.Add(this.lblExcluirUsuario);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlterarUsuario";
            this.Text = "AlterarUsuario";
            this.Load += new System.EventHandler(this.AlterarUsuario_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.tccDataSet1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.tccDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.ListBox lsbNomeUsuario;
        private System.Windows.Forms.Label lblSenhaAdm;
        private System.Windows.Forms.TextBox txtSenhaAdm;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private tccDataSet tccDataSet;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private tccDataSetTableAdapters.logsTableAdapter logsTableAdapter;
        private System.Windows.Forms.BindingSource tccDataSet1BindingSource;
        //private tccDataSet1 tccDataSet1;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        //private tccDataSet1TableAdapters.loginsTableAdapter loginsTableAdapter;
        private System.Windows.Forms.Label lblExcluirUsuario;
        private System.Windows.Forms.Button btnEditData;
        private System.Windows.Forms.Button btnConfirmarExcluirUser;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblEditData;
    }
}