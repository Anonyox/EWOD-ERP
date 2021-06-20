
namespace TCC.VISIONS.relatorio_visao
{
    partial class FiltroRelatorioEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroRelatorioEstoque));
            this.txtdataInicial = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barra = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdataInicial
            // 
            this.txtdataInicial.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdataInicial.Location = new System.Drawing.Point(162, 59);
            this.txtdataInicial.Mask = "00/00/0000";
            this.txtdataInicial.Name = "txtdataInicial";
            this.txtdataInicial.Size = new System.Drawing.Size(127, 30);
            this.txtdataInicial.TabIndex = 119;
            this.txtdataInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(47, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 21);
            this.label9.TabIndex = 120;
            this.label9.Text = "Data Inicial :";
            // 
            // txtdataFinal
            // 
            this.txtdataFinal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdataFinal.Location = new System.Drawing.Point(162, 95);
            this.txtdataFinal.Mask = "00/00/0000";
            this.txtdataFinal.Name = "txtdataFinal";
            this.txtdataFinal.Size = new System.Drawing.Size(127, 30);
            this.txtdataFinal.TabIndex = 121;
            this.txtdataFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdataFinal.Leave += new System.EventHandler(this.txtdataFinal_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 122;
            this.label1.Text = "Data Final :";
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.barra.Controls.Add(this.btnSair);
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Margin = new System.Windows.Forms.Padding(2);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(369, 36);
            this.barra.TabIndex = 178;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(338, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 28);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 60;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.BackColor = System.Drawing.Color.Transparent;
            this.btnfiltrar.BackgroundImage = global::TCC.Properties.Resources.icons8_botão_de_opção_marcado_481;
            this.btnfiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfiltrar.FlatAppearance.BorderSize = 0;
            this.btnfiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnfiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfiltrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnfiltrar.Location = new System.Drawing.Point(141, 142);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(68, 36);
            this.btnfiltrar.TabIndex = 177;
            this.btnfiltrar.UseVisualStyleBackColor = false;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            this.btnfiltrar.MouseEnter += new System.EventHandler(this.btnfiltrar_MouseEnter);
            this.btnfiltrar.MouseLeave += new System.EventHandler(this.btnfiltrar_MouseLeave);
            // 
            // FiltroRelatorioEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(367, 200);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.txtdataFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdataInicial);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FiltroRelatorioEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiltroRelatorioEstoque";
            this.barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtdataInicial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtdataFinal;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.PictureBox btnSair;
    }
}