namespace TCC.VISÃO
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.lblexibe = new System.Windows.Forms.Label();
            this.cmbperfil = new System.Windows.Forms.ComboBox();
            this.lblperfil = new System.Windows.Forms.Label();
            this.chcSenha = new System.Windows.Forms.CheckBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtconfSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblconfSenha = new System.Windows.Forms.Label();
            this.lbldepart = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtdepart = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.lblcomplemento = new System.Windows.Forms.Label();
            this.rdbfeminino = new System.Windows.Forms.RadioButton();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.rdbmasculino = new System.Windows.Forms.RadioButton();
            this.lblsexo = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.lblbairro = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblcidade = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.btnprox = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblcep = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.txtestado = new System.Windows.Forms.ComboBox();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TCC.Properties.Resources.Seja_bem_vindo;
            this.pictureBox1.Location = new System.Drawing.Point(649, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.txtcpf);
            this.panel6.Controls.Add(this.lblexibe);
            this.panel6.Controls.Add(this.cmbperfil);
            this.panel6.Controls.Add(this.lblperfil);
            this.panel6.Controls.Add(this.chcSenha);
            this.panel6.Controls.Add(this.txtemail);
            this.panel6.Controls.Add(this.lblemail);
            this.panel6.Controls.Add(this.lbluser);
            this.panel6.Controls.Add(this.txtconfSenha);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.lblsenha);
            this.panel6.Controls.Add(this.lblcpf);
            this.panel6.Controls.Add(this.lblconfSenha);
            this.panel6.Controls.Add(this.lbldepart);
            this.panel6.Controls.Add(this.txtuser);
            this.panel6.Controls.Add(this.txtsenha);
            this.panel6.Controls.Add(this.txtdepart);
            this.panel6.Location = new System.Drawing.Point(3, 42);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(628, 535);
            this.panel6.TabIndex = 36;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseDown);
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(199, 390);
            this.txtcpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtcpf.Mask = "000,000,000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(185, 35);
            this.txtcpf.TabIndex = 6;
            this.txtcpf.Leave += new System.EventHandler(this.txtcpf_Leave);
            // 
            // lblexibe
            // 
            this.lblexibe.AutoSize = true;
            this.lblexibe.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexibe.ForeColor = System.Drawing.Color.Orange;
            this.lblexibe.Location = new System.Drawing.Point(476, 190);
            this.lblexibe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblexibe.Name = "lblexibe";
            this.lblexibe.Size = new System.Drawing.Size(129, 27);
            this.lblexibe.TabIndex = 39;
            this.lblexibe.Text = "Exibir Senha";
            // 
            // cmbperfil
            // 
            this.cmbperfil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbperfil.FormattingEnabled = true;
            this.cmbperfil.Items.AddRange(new object[] {
            "Administrador",
            "Compras",
            "Vendas",
            "Geral"});
            this.cmbperfil.Location = new System.Drawing.Point(199, 437);
            this.cmbperfil.Margin = new System.Windows.Forms.Padding(4);
            this.cmbperfil.Name = "cmbperfil";
            this.cmbperfil.Size = new System.Drawing.Size(185, 36);
            this.cmbperfil.TabIndex = 7;
            this.cmbperfil.SelectedIndexChanged += new System.EventHandler(this.cmbPerfil_SelectedIndexChanged);
            // 
            // lblperfil
            // 
            this.lblperfil.AutoSize = true;
            this.lblperfil.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperfil.ForeColor = System.Drawing.Color.Orange;
            this.lblperfil.Location = new System.Drawing.Point(107, 444);
            this.lblperfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblperfil.Name = "lblperfil";
            this.lblperfil.Size = new System.Drawing.Size(78, 27);
            this.lblperfil.TabIndex = 43;
            this.lblperfil.Text = "Perfil :";
            // 
            // chcSenha
            // 
            this.chcSenha.AutoSize = true;
            this.chcSenha.Cursor = System.Windows.Forms.Cursors.Default;
            this.chcSenha.Location = new System.Drawing.Point(451, 196);
            this.chcSenha.Margin = new System.Windows.Forms.Padding(4);
            this.chcSenha.Name = "chcSenha";
            this.chcSenha.Size = new System.Drawing.Size(18, 17);
            this.chcSenha.TabIndex = 100;
            this.chcSenha.UseVisualStyleBackColor = true;
            this.chcSenha.Click += new System.EventHandler(this.chcSenha_Click);
            this.chcSenha.MouseEnter += new System.EventHandler(this.chcSenha_MouseEnter);
            this.chcSenha.MouseLeave += new System.EventHandler(this.chcSenha_MouseLeave);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.Location = new System.Drawing.Point(199, 290);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(240, 28);
            this.txtemail.TabIndex = 4;
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Orange;
            this.lblemail.Location = new System.Drawing.Point(111, 292);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(76, 27);
            this.lblemail.TabIndex = 37;
            this.lblemail.Text = "Email :";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.Orange;
            this.lbluser.Location = new System.Drawing.Point(89, 134);
            this.lbluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(96, 27);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "Usuário :";
            // 
            // txtconfSenha
            // 
            this.txtconfSenha.BackColor = System.Drawing.Color.White;
            this.txtconfSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtconfSenha.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtconfSenha.ForeColor = System.Drawing.Color.Black;
            this.txtconfSenha.Location = new System.Drawing.Point(199, 242);
            this.txtconfSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfSenha.Name = "txtconfSenha";
            this.txtconfSenha.Size = new System.Drawing.Size(240, 28);
            this.txtconfSenha.TabIndex = 3;
            this.txtconfSenha.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(193, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 27);
            this.label6.TabIndex = 36;
            this.label6.Text = "NOVO USUÁRIO";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.ForeColor = System.Drawing.Color.Orange;
            this.lblsenha.Location = new System.Drawing.Point(101, 187);
            this.lblsenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(84, 27);
            this.lblsenha.TabIndex = 1;
            this.lblsenha.Text = "Senha :";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.ForeColor = System.Drawing.Color.Orange;
            this.lblcpf.Location = new System.Drawing.Point(125, 401);
            this.lblcpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(62, 27);
            this.lblcpf.TabIndex = 2;
            this.lblcpf.Text = "CPF :";
            // 
            // lblconfSenha
            // 
            this.lblconfSenha.AutoSize = true;
            this.lblconfSenha.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfSenha.ForeColor = System.Drawing.Color.Orange;
            this.lblconfSenha.Location = new System.Drawing.Point(-1, 241);
            this.lblconfSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblconfSenha.Name = "lblconfSenha";
            this.lblconfSenha.Size = new System.Drawing.Size(183, 27);
            this.lblconfSenha.TabIndex = 33;
            this.lblconfSenha.Text = "Confirmar Senha :";
            // 
            // lbldepart
            // 
            this.lbldepart.AutoSize = true;
            this.lbldepart.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepart.ForeColor = System.Drawing.Color.Orange;
            this.lbldepart.Location = new System.Drawing.Point(27, 347);
            this.lbldepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldepart.Name = "lbldepart";
            this.lbldepart.Size = new System.Drawing.Size(158, 27);
            this.lbldepart.TabIndex = 3;
            this.lbldepart.Text = "Departamento :";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.White;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.Black;
            this.txtuser.Location = new System.Drawing.Point(199, 133);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(240, 28);
            this.txtuser.TabIndex = 1;
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            this.txtuser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtsenha
            // 
            this.txtsenha.BackColor = System.Drawing.Color.White;
            this.txtsenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsenha.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtsenha.ForeColor = System.Drawing.Color.Black;
            this.txtsenha.Location = new System.Drawing.Point(199, 187);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(240, 28);
            this.txtsenha.TabIndex = 2;
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // txtdepart
            // 
            this.txtdepart.BackColor = System.Drawing.Color.White;
            this.txtdepart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdepart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepart.ForeColor = System.Drawing.Color.Black;
            this.txtdepart.Location = new System.Drawing.Point(199, 345);
            this.txtdepart.Margin = new System.Windows.Forms.Padding(4);
            this.txtdepart.Name = "txtdepart";
            this.txtdepart.Size = new System.Drawing.Size(240, 28);
            this.txtdepart.TabIndex = 5;
            this.txtdepart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepart_KeyPress);
            this.txtdepart.Leave += new System.EventHandler(this.txtDepart_Leave);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Lavender;
            this.btnlimpar.Enabled = false;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnlimpar.Location = new System.Drawing.Point(649, 682);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(133, 37);
            this.btnlimpar.TabIndex = 44;
            this.btnlimpar.Text = "Limpar Campos";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // lblcomplemento
            // 
            this.lblcomplemento.AutoSize = true;
            this.lblcomplemento.BackColor = System.Drawing.Color.Transparent;
            this.lblcomplemento.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomplemento.ForeColor = System.Drawing.Color.Orange;
            this.lblcomplemento.Location = new System.Drawing.Point(621, 489);
            this.lblcomplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcomplemento.Name = "lblcomplemento";
            this.lblcomplemento.Size = new System.Drawing.Size(154, 29);
            this.lblcomplemento.TabIndex = 42;
            this.lblcomplemento.Text = "Complemento :";
            this.lblcomplemento.Visible = false;
            // 
            // rdbfeminino
            // 
            this.rdbfeminino.AutoSize = true;
            this.rdbfeminino.BackColor = System.Drawing.Color.Transparent;
            this.rdbfeminino.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.rdbfeminino.ForeColor = System.Drawing.Color.Orange;
            this.rdbfeminino.Location = new System.Drawing.Point(987, 613);
            this.rdbfeminino.Margin = new System.Windows.Forms.Padding(4);
            this.rdbfeminino.Name = "rdbfeminino";
            this.rdbfeminino.Size = new System.Drawing.Size(116, 33);
            this.rdbfeminino.TabIndex = 19;
            this.rdbfeminino.TabStop = true;
            this.rdbfeminino.Text = "Feminino";
            this.rdbfeminino.UseVisualStyleBackColor = false;
            this.rdbfeminino.Visible = false;
            this.rdbfeminino.Click += new System.EventHandler(this.rdbFeminino_Click);
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.BackColor = System.Drawing.Color.Transparent;
            this.lbltelefone.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.ForeColor = System.Drawing.Color.Orange;
            this.lbltelefone.Location = new System.Drawing.Point(663, 549);
            this.lbltelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(114, 29);
            this.lbltelefone.TabIndex = 41;
            this.lbltelefone.Text = "Telefone :";
            this.lbltelefone.Visible = false;
            // 
            // rdbmasculino
            // 
            this.rdbmasculino.AutoSize = true;
            this.rdbmasculino.BackColor = System.Drawing.Color.Transparent;
            this.rdbmasculino.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.rdbmasculino.ForeColor = System.Drawing.Color.Orange;
            this.rdbmasculino.Location = new System.Drawing.Point(791, 613);
            this.rdbmasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rdbmasculino.Name = "rdbmasculino";
            this.rdbmasculino.Size = new System.Drawing.Size(125, 33);
            this.rdbmasculino.TabIndex = 18;
            this.rdbmasculino.TabStop = true;
            this.rdbmasculino.Text = "Masculino";
            this.rdbmasculino.UseVisualStyleBackColor = false;
            this.rdbmasculino.Visible = false;
            this.rdbmasculino.Click += new System.EventHandler(this.rdbMasculino_Click);
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.BackColor = System.Drawing.Color.Transparent;
            this.lblsexo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.ForeColor = System.Drawing.Color.Orange;
            this.lblsexo.Location = new System.Drawing.Point(701, 613);
            this.lblsexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(79, 29);
            this.lblsexo.TabIndex = 41;
            this.lblsexo.Text = "Sexo :";
            this.lblsexo.Visible = false;
            // 
            // txtbairro
            // 
            this.txtbairro.BackColor = System.Drawing.Color.White;
            this.txtbairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbairro.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtbairro.ForeColor = System.Drawing.Color.Black;
            this.txtbairro.Location = new System.Drawing.Point(785, 324);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(323, 28);
            this.txtbairro.TabIndex = 13;
            this.txtbairro.Visible = false;
            this.txtbairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            this.txtbairro.Leave += new System.EventHandler(this.txtBairro_Leave);
            // 
            // txtcidade
            // 
            this.txtcidade.BackColor = System.Drawing.Color.White;
            this.txtcidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcidade.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtcidade.ForeColor = System.Drawing.Color.Black;
            this.txtcidade.Location = new System.Drawing.Point(785, 274);
            this.txtcidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(323, 28);
            this.txtcidade.TabIndex = 12;
            this.txtcidade.Visible = false;
            this.txtcidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCidade_KeyPress);
            this.txtcidade.Leave += new System.EventHandler(this.txtCidade_Leave);
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.BackColor = System.Drawing.Color.Transparent;
            this.lblbairro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbairro.ForeColor = System.Drawing.Color.Orange;
            this.lblbairro.Location = new System.Drawing.Point(688, 324);
            this.lblbairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(92, 29);
            this.lblbairro.TabIndex = 40;
            this.lblbairro.Text = "Bairro :";
            this.lblbairro.Visible = false;
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.Color.White;
            this.txtnumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumero.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtnumero.ForeColor = System.Drawing.Color.Black;
            this.txtnumero.Location = new System.Drawing.Point(785, 225);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(323, 28);
            this.txtnumero.TabIndex = 11;
            this.txtnumero.Visible = false;
            this.txtnumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.BackColor = System.Drawing.Color.Transparent;
            this.lblcidade.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcidade.ForeColor = System.Drawing.Color.Orange;
            this.lblcidade.Location = new System.Drawing.Point(684, 274);
            this.lblcidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(95, 29);
            this.lblcidade.TabIndex = 40;
            this.lblcidade.Text = "Cidade :";
            this.lblcidade.Visible = false;
            // 
            // txtendereco
            // 
            this.txtendereco.BackColor = System.Drawing.Color.White;
            this.txtendereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtendereco.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtendereco.ForeColor = System.Drawing.Color.Black;
            this.txtendereco.Location = new System.Drawing.Point(785, 176);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(323, 28);
            this.txtendereco.TabIndex = 10;
            this.txtendereco.Visible = false;
            this.txtendereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndereco_KeyPress);
            this.txtendereco.Leave += new System.EventHandler(this.txtEndereco_Leave);
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.BackColor = System.Drawing.Color.Transparent;
            this.lblnumero.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.ForeColor = System.Drawing.Color.Orange;
            this.lblnumero.Location = new System.Drawing.Point(673, 225);
            this.lblnumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(105, 29);
            this.lblnumero.TabIndex = 39;
            this.lblnumero.Text = "Número :";
            this.lblnumero.Visible = false;
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.BackColor = System.Drawing.Color.Transparent;
            this.lblendereco.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereco.ForeColor = System.Drawing.Color.Orange;
            this.lblendereco.Location = new System.Drawing.Point(659, 176);
            this.lblendereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(118, 29);
            this.lblendereco.TabIndex = 38;
            this.lblendereco.Text = "Endereço :";
            this.lblendereco.Visible = false;
            // 
            // btnprox
            // 
            this.btnprox.BackColor = System.Drawing.Color.Lavender;
            this.btnprox.Enabled = false;
            this.btnprox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnprox.Location = new System.Drawing.Point(340, 682);
            this.btnprox.Margin = new System.Windows.Forms.Padding(4);
            this.btnprox.Name = "btnprox";
            this.btnprox.Size = new System.Drawing.Size(133, 37);
            this.btnprox.TabIndex = 8;
            this.btnprox.Text = "Próximo";
            this.btnprox.UseVisualStyleBackColor = false;
            this.btnprox.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Lavender;
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnCadastrar.Location = new System.Drawing.Point(497, 682);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(133, 37);
            this.btnCadastrar.TabIndex = 25;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-20, -18);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1092, 4);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(37, 34);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 49;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txttelefone
            // 
            this.txttelefone.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefone.Location = new System.Drawing.Point(785, 545);
            this.txttelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefone.Mask = "(00)00000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(189, 35);
            this.txttelefone.TabIndex = 17;
            this.txttelefone.Visible = false;
            this.txttelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            this.txttelefone.Leave += new System.EventHandler(this.txttelefone_Leave);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1047, 3);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(37, 34);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 50;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.BackColor = System.Drawing.Color.Transparent;
            this.lblestado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.ForeColor = System.Drawing.Color.Orange;
            this.lblestado.Location = new System.Drawing.Point(681, 373);
            this.lblestado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(96, 29);
            this.lblestado.TabIndex = 51;
            this.lblestado.Text = "Estado :";
            this.lblestado.Visible = false;
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.BackColor = System.Drawing.Color.Transparent;
            this.lblcep.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcep.ForeColor = System.Drawing.Color.Orange;
            this.lblcep.Location = new System.Drawing.Point(712, 422);
            this.lblcep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(66, 29);
            this.lblcep.TabIndex = 53;
            this.lblcep.Text = "CEP :";
            this.lblcep.Visible = false;
            // 
            // txtcep
            // 
            this.txtcep.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcep.Location = new System.Drawing.Point(785, 422);
            this.txtcep.Margin = new System.Windows.Forms.Padding(4);
            this.txtcep.Mask = "00000-000";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(136, 35);
            this.txtcep.TabIndex = 15;
            this.txtcep.Visible = false;
            this.txtcep.Leave += new System.EventHandler(this.txtcep_Leave);
            // 
            // txtestado
            // 
            this.txtestado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestado.FormattingEnabled = true;
            this.txtestado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas\t",
            "Bahia",
            "Ceará",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.txtestado.Location = new System.Drawing.Point(785, 372);
            this.txtestado.Margin = new System.Windows.Forms.Padding(4);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(321, 36);
            this.txtestado.TabIndex = 14;
            this.txtestado.Visible = false;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.BackColor = System.Drawing.Color.White;
            this.txtcomplemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcomplemento.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtcomplemento.ForeColor = System.Drawing.Color.Black;
            this.txtcomplemento.Location = new System.Drawing.Point(785, 489);
            this.txtcomplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(191, 28);
            this.txtcomplemento.TabIndex = 16;
            this.txtcomplemento.Visible = false;
            this.txtcomplemento.Leave += new System.EventHandler(this.txtcomplemento_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Location = new System.Drawing.Point(-5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1151, 48);
            this.panel3.TabIndex = 54;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::TCC.Properties.Resources.d6a55e0c15b8da392e5cec620a39e6e81;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1014, 711);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 109;
            this.pictureBox3.TabStop = false;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(38)))));
            this.BackgroundImage = global::TCC.Properties.Resources.ÍCONE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1133, 800);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtcomplemento);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.rdbfeminino);
            this.Controls.Add(this.rdbmasculino);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lblcomplemento);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnprox);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.lblendereco);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroUsuario";
            this.Shown += new System.EventHandler(this.CadastroUsuario_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroUsuario_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtconfSenha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblconfSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lbldepart;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtdepart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnprox;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.CheckBox chcSenha;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lblperfil;
        private System.Windows.Forms.ComboBox cmbperfil;
        private System.Windows.Forms.RadioButton rdbfeminino;
        private System.Windows.Forms.RadioButton rdbmasculino;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.Label lblcomplemento;
        private System.Windows.Forms.Label lblexibe;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.ComboBox txtestado;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}