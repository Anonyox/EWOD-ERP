﻿
namespace TCC.VISÃO
{
    partial class EditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtbairroUsuario = new System.Windows.Forms.TextBox();
            this.txtcepUsuario = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtcomplementoUsuario = new System.Windows.Forms.TextBox();
            this.txtenderecoUsuario = new System.Windows.Forms.TextBox();
            this.txttelefoneUsuario = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.lblnomeUsuario = new System.Windows.Forms.Label();
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccDataSet = new TCC.tccDataSet();
            this.lblteste = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbperfilUsuario = new System.Windows.Forms.ComboBox();
            this.cbdepartamentoUsuario = new System.Windows.Forms.ComboBox();
            this.cbestadoUsuario = new System.Windows.Forms.ComboBox();
            this.loginsTableAdapter = new TCC.tccDataSetTableAdapters.loginsTableAdapter();
            this.txtnomeUsuario = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblteste)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 46);
            this.panel3.TabIndex = 53;
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
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDepartamento.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDepartamento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDepartamento.Location = new System.Drawing.Point(30, 113);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(190, 21);
            this.lblDepartamento.TabIndex = 70;
            this.lblDepartamento.Text = "Alterar Departamento  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(34, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 73;
            this.label4.Text = "Alterar Bairro :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(51, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 74;
            this.label5.Text = "Alterar CEP :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(509, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 21);
            this.label6.TabIndex = 75;
            this.label6.Text = "Alterar Endereço  :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(30, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 21);
            this.label7.TabIndex = 76;
            this.label7.Text = "Alterar Cidade :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(30, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 21);
            this.label8.TabIndex = 77;
            this.label8.Text = "Alterar Estado :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(509, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 78;
            this.label2.Text = "Alterar Telefone  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(479, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 21);
            this.label9.TabIndex = 79;
            this.label9.Text = "Alterar Complemento  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(455, 419);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 21);
            this.label10.TabIndex = 80;
            this.label10.Text = "Senha do Administrador  :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 21);
            this.panel1.TabIndex = 135;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Location = new System.Drawing.Point(0, 380);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(931, 21);
            this.panel4.TabIndex = 137;
            // 
            // txtbairroUsuario
            // 
            this.txtbairroUsuario.Location = new System.Drawing.Point(175, 316);
            this.txtbairroUsuario.Name = "txtbairroUsuario";
            this.txtbairroUsuario.Size = new System.Drawing.Size(179, 20);
            this.txtbairroUsuario.TabIndex = 140;
            // 
            // txtcepUsuario
            // 
            this.txtcepUsuario.Location = new System.Drawing.Point(175, 347);
            this.txtcepUsuario.Name = "txtcepUsuario";
            this.txtcepUsuario.Size = new System.Drawing.Size(181, 20);
            this.txtcepUsuario.TabIndex = 141;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(171, 254);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(132, 20);
            this.txtCidade.TabIndex = 143;
            // 
            // txtcomplementoUsuario
            // 
            this.txtcomplementoUsuario.Location = new System.Drawing.Point(667, 254);
            this.txtcomplementoUsuario.Name = "txtcomplementoUsuario";
            this.txtcomplementoUsuario.Size = new System.Drawing.Size(154, 20);
            this.txtcomplementoUsuario.TabIndex = 144;
            // 
            // txtenderecoUsuario
            // 
            this.txtenderecoUsuario.Location = new System.Drawing.Point(667, 195);
            this.txtenderecoUsuario.Name = "txtenderecoUsuario";
            this.txtenderecoUsuario.Size = new System.Drawing.Size(154, 20);
            this.txtenderecoUsuario.TabIndex = 145;
            // 
            // txttelefoneUsuario
            // 
            this.txttelefoneUsuario.Location = new System.Drawing.Point(667, 313);
            this.txttelefoneUsuario.Name = "txttelefoneUsuario";
            this.txttelefoneUsuario.Size = new System.Drawing.Size(161, 20);
            this.txttelefoneUsuario.TabIndex = 146;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(667, 422);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(164, 20);
            this.textBox10.TabIndex = 147;
            // 
            // lblnomeUsuario
            // 
            this.lblnomeUsuario.AutoSize = true;
            this.lblnomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblnomeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblnomeUsuario.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblnomeUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblnomeUsuario.Location = new System.Drawing.Point(65, 62);
            this.lblnomeUsuario.Name = "lblnomeUsuario";
            this.lblnomeUsuario.Size = new System.Drawing.Size(155, 21);
            this.lblnomeUsuario.TabIndex = 150;
            this.lblnomeUsuario.Text = "Nome do Usuário  :";
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "logins";
            this.loginsBindingSource.DataSource = this.tccDataSet;
            // 
            // tccDataSet
            // 
            this.tccDataSet.DataSetName = "tccDataSet";
            this.tccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblteste
            // 
            this.lblteste.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lblteste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lblteste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lblteste.Location = new System.Drawing.Point(-2, 471);
            this.lblteste.Name = "lblteste";
            this.lblteste.RowHeadersWidth = 51;
            this.lblteste.Size = new System.Drawing.Size(867, 185);
            this.lblteste.TabIndex = 153;
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
            this.btnCancelar.Location = new System.Drawing.Point(69, 422);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(49, 35);
            this.btnCancelar.TabIndex = 155;
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.btnConfirmar.Location = new System.Drawing.Point(12, 422);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(49, 35);
            this.btnConfirmar.TabIndex = 154;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(532, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 157;
            this.label1.Text = "Alterar Perfil  :";
            // 
            // cbperfilUsuario
            // 
            this.cbperfilUsuario.FormattingEnabled = true;
            this.cbperfilUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Geral",
            "Venda",
            "Compra"});
            this.cbperfilUsuario.Location = new System.Drawing.Point(674, 62);
            this.cbperfilUsuario.Name = "cbperfilUsuario";
            this.cbperfilUsuario.Size = new System.Drawing.Size(154, 21);
            this.cbperfilUsuario.TabIndex = 159;
            // 
            // cbdepartamentoUsuario
            // 
            this.cbdepartamentoUsuario.FormattingEnabled = true;
            this.cbdepartamentoUsuario.Items.AddRange(new object[] {
            "Venda",
            "Compra",
            "Geral",
            "Administrador "});
            this.cbdepartamentoUsuario.Location = new System.Drawing.Point(237, 117);
            this.cbdepartamentoUsuario.Name = "cbdepartamentoUsuario";
            this.cbdepartamentoUsuario.Size = new System.Drawing.Size(121, 21);
            this.cbdepartamentoUsuario.TabIndex = 160;
            // 
            // cbestadoUsuario
            // 
            this.cbestadoUsuario.FormattingEnabled = true;
            this.cbestadoUsuario.Location = new System.Drawing.Point(171, 195);
            this.cbestadoUsuario.Name = "cbestadoUsuario";
            this.cbestadoUsuario.Size = new System.Drawing.Size(132, 21);
            this.cbestadoUsuario.TabIndex = 161;
            // 
            // loginsTableAdapter
            // 
            this.loginsTableAdapter.ClearBeforeFill = true;
            // 
            // txtnomeUsuario
            // 
            this.txtnomeUsuario.Location = new System.Drawing.Point(237, 65);
            this.txtnomeUsuario.Name = "txtnomeUsuario";
            this.txtnomeUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtnomeUsuario.TabIndex = 162;
            this.txtnomeUsuario.Leave += new System.EventHandler(this.txtnomeUsuario_Leave_1);
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(38)))));
            this.BackgroundImage = global::TCC.Properties.Resources._1555492a6_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(863, 654);
            this.Controls.Add(this.txtnomeUsuario);
            this.Controls.Add(this.cbestadoUsuario);
            this.Controls.Add(this.cbdepartamentoUsuario);
            this.Controls.Add(this.cbperfilUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblteste);
            this.Controls.Add(this.lblnomeUsuario);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.txttelefoneUsuario);
            this.Controls.Add(this.txtenderecoUsuario);
            this.Controls.Add(this.txtcomplementoUsuario);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtcepUsuario);
            this.Controls.Add(this.txtbairroUsuario);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarUsuario";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditarUsuario_MouseMove);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblteste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtbairroUsuario;
        private System.Windows.Forms.TextBox txtcepUsuario;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtcomplementoUsuario;
        private System.Windows.Forms.TextBox txtenderecoUsuario;
        private System.Windows.Forms.TextBox txttelefoneUsuario;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label lblnomeUsuario;
        private System.Windows.Forms.DataGridView lblteste;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbperfilUsuario;
        private System.Windows.Forms.ComboBox cbdepartamentoUsuario;
        private System.Windows.Forms.ComboBox cbestadoUsuario;
        private tccDataSet tccDataSet;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        private tccDataSetTableAdapters.loginsTableAdapter loginsTableAdapter;
        private System.Windows.Forms.TextBox txtnomeUsuario;
    }
}