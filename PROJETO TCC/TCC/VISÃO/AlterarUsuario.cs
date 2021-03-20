using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.VISÃO
{
    public partial class AlterarUsuario : Form
    {
        public AlterarUsuario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNomeUsuario.Visible = true;
            lsbNomeUsuario.Visible = true;
            lblSenhaAdm.Visible = true;
            txtSenhaAdm.Visible = true;







        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            lblNomeUsuario.Visible = true;
            lsbNomeUsuario.Visible = true;
            lblSenhaAdm.Visible = true;
            txtSenhaAdm.Visible = true;
            btnEditData.Visible = false;
            btnConfirmarExcluirUser.Visible = true;
            btnVoltar.Visible = true;

            btnExcluirUsuario.Location = new Point (12, 78);
            lblExcluirUsuario.Location = new Point(52, 194);

        }

        private void AlterarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tccDataSet1.logins'. Você pode movê-la ou removê-la conforme necessário.
            // this.loginsTableAdapter.Fill(this.tccDataSet1.logins);
            // TODO: esta linha de código carrega dados na tabela 'tccDataSet.logs'. Você pode movê-la ou removê-la conforme necessário.
            //this.logsTableAdapter.Fill(this.tccDataSet.logs);

        }

        private void btnExcluirUsuario_MouseEnter(object sender, EventArgs e)
        {
            btnExcluirUsuario.Size = new Size(190, 100);
            lblExcluirUsuario.Visible = true;
        }

        private void btnExcluirUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnExcluirUsuario.Size = new Size(187, 95);
            lblExcluirUsuario.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Tem certeza que deseja excluir o Usuário ?","Confirme a ação",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            lblNomeUsuario.Visible = false;
            lsbNomeUsuario.Visible = false;
            lblSenhaAdm.Visible = false;
            txtSenhaAdm.Visible = false;
            btnEditData.Visible = true;
            btnConfirmarExcluirUser.Visible = false;
            btnVoltar.Visible = false;
            lblEditData.Visible = false;
            btnExcluirUsuario.Visible = true;

            lblEditData.Location = new Point(364, 373);
            btnEditData.Location = new Point(330, 263);
            btnExcluirUsuario.Location = new Point(107, 257);
            lblExcluirUsuario.Location = new Point(147, 373);
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            lblNomeUsuario.Visible = false;
            lsbNomeUsuario.Visible = false;
            lblSenhaAdm.Visible = false;
            txtSenhaAdm.Visible = false;
            btnConfirmarExcluirUser.Visible = true;
            btnVoltar.Visible = true;
            btnExcluirUsuario.Visible = false;
            lblExcluirUsuario.Visible = false;


            btnEditData.Location = new Point(12, 78);
            lblEditData.Location = new Point(52, 194);

        }

        private void btnEditData_MouseEnter(object sender, EventArgs e)
        {
            btnEditData.Size = new Size(190, 100);
            lblEditData.Visible = true;

            lblEditData.Visible = true;


        }

        private void btnEditData_MouseLeave(object sender, EventArgs e)
        {
            btnEditData.Size = new Size(187, 95);
            lblEditData.Visible = false;

            lblEditData.Visible = false;

        }
    }
}
