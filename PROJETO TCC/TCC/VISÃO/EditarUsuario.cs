using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.CONTROLE;

namespace TCC.VISÃO
{
    public partial class EditarUsuario : Form
    {
        //SqlConnection con = new SqlConnection();
        int validamsg = 0;
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tccDataSet.logins'. Você pode movê-la ou removê-la conforme necessário.
            this.loginsTableAdapter.Fill(this.tccDataSet.logins);

           // SqlCommand cmd = new SqlCommand("SELECT usuario FROM logins", con);

            
           
        }

        private void EditarUsuario_MouseMove(object sender, MouseEventArgs e)
        {   
            if(validamsg == 0)
            {
                MessageBox.Show("Primeiro digite o nome do usuário que pretende alterar !!", "Defina o usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            validamsg = 1;
           
            
        }

        
    }
}
