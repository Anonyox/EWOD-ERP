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
            
        }

        private void EditarUsuario_MouseMove(object sender, MouseEventArgs e)
        {   
            if(validamsg == 0)
            {
                MessageBox.Show("Primeiro digite o nome do usuário que pretende alterar !!", "Defina o usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            validamsg = 1;
           
            
        }

        private void txtnomeUsuario_TextChanged(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            string usuario = "";
            string departamento = "";
            string perfil = "";
            string endereco = "";
            string cidade = "";
            string bairro = "";
            string estado = "";
            string cep = "";
            string complemento = "";
            string telefone = "";

            cmd.CommandText = "select @usuario,@departamento,@perfil,@endereco,@cidade,@bairro,@estado,@cep,@complemento,@telefone from logins";

            cmd.Parameters.AddWithValue("@usuario",usuario);
            cmd.Parameters.AddWithValue("@departamento", departamento);
           /* cmd.Parameters.AddWithValue("@perfil", perfil);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            

        }
    }
}
