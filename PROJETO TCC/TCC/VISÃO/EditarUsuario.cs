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
using System.Data.OleDb;

namespace TCC.VISÃO
{
    public partial class EditarUsuario : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source= tcp: 177.125.224.84,9022;Initial Catalog=tcc;User ID=etec;Password=123456;connection timeout = 1");
        SqlDataReader dr;

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
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT usuario FROM logins", con);
            //cmd.CommandText = ;

            dr = cmd.ExecuteReader();

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                collection.Add(dr["usuario"].ToString());
            }

            txtnomeUsuario.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtnomeUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtnomeUsuario.AutoCompleteCustomSource = collection;

            dr.Close();
            con.Close();


        }


        private void EditarUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            if (validamsg == 0)
            {
                MessageBox.Show("Primeiro digite o nome do usuário que pretende alterar !!", "Defina o usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            validamsg = 1;


        }

        private void txtnomeUsuario_MouseClick(object sender, MouseEventArgs e)
        {






        }

        private void txtnomeUsuario_Leave(object sender, EventArgs e)
        {
            Conexao cone = new Conexao();
            string usuario = Convert.ToString(txtnomeUsuario);
            con.Open();
            //Elaborar Select que contenha cada um dos campos da tabela
            SqlCommand cmd = new SqlCommand("SELECT cidade,endereco,complemento,telefone FROM logins WHERE usuario = @usuario ", con);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            dr = cmd.ExecuteReader();
            //criar variáveis para armazenar os campos
            AutoCompleteStringCollection collection2 = new AutoCompleteStringCollection();

            //atribuir as variáveis para os txts
            while (dr.Read())
            {

                collection2.Add(dr["cidade"].ToString());
            }


            //colocar no formato auto-complete

            txtCidade.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCidade.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtCidade.AutoCompleteCustomSource = collection2;


            dr.Close();
            con.Close();
            //SqlCommand cmd = new SqlCommand("SELECT");







        }

    }
}   