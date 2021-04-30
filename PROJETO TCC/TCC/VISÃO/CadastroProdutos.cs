using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TCC.CONTROLE;

namespace TCC.VISÃO
{
    public partial class txtfornecedor : Form
    {
        menuAdministrador menuz = new menuAdministrador();
        public txtfornecedor()
        {
            InitializeComponent();
            menuz.valida = 2;
            listarProdutos();
            


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CADASTRARPRODUTO_FormClosed(object sender, FormClosedEventArgs e)
        {
            //menuz.Show();
        }

        private void listarProdutos()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from produtos";
            cmd.Connection = con.conectar();


            try
            {
                con.conectar();
                cmd.ExecuteNonQuery();


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                con.desconectar();

                dataGridView1.DataSource = dt;

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            //btnCadastrar.Size = new Size(100, 50);
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
           // btnCadastrar.Size = new Size(79, 35);
        }

        private void btnpesqisar_MouseEnter(object sender, EventArgs e)
        {
            btnpesqisar.Size = new Size(60, 40);
        }

        private void btnpesqisar_MouseLeave(object sender, EventArgs e)
        {
            btnpesqisar.Size = new Size(44, 30);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listarProdutos();
            timer1.Start();

            
        }

        private void txtfornecedor_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
