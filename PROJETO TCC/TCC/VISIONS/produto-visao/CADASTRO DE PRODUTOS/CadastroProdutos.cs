﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TCC.CONTROLE;

namespace TCC.VISÃO
{
    public partial class CadastroProduto : Form
    {
        menuAdministrador menuz = new menuAdministrador();
        cadastroprodutoDaoComandos cadpro = new cadastroprodutoDaoComandos();
        
        SqlDataReader dr;
        Conexao con = new Conexao();

       
        public CadastroProduto()
        {
            InitializeComponent();
            menuz.valida = 2;
            //listarProdutos();
            


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

        private void CadastroProduto_Load(object sender, EventArgs e)
        {           
            //buscarProduto();                  
            //timer1.Start();           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_MouseEnter(object sender, EventArgs e)
        {
            lblconfirmar.Visible = true;
        }

        private void btnConfirmar_MouseLeave(object sender, EventArgs e)
        {
            lblconfirmar.Visible = false;
        }

        public void buscarProduto()
        {

            SqlCommand cmd = new SqlCommand("SELECT nome FROM produtos", con.conectar());          

            dr = cmd.ExecuteReader();

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                collection.Add(dr["nome"].ToString());
            }

            txtnomeProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtnomeProduto.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtnomeProduto.AutoCompleteCustomSource = collection;


            dr.Close();
            con.desconectar();

        }

        public void preencherCampos()
        {
            SqlCommand command = new SqlCommand("SELECT quantidade, valordeCompra, valordeVenda FROM produtos WHERE nome = @nome", con.conectar());
            command.Parameters.AddWithValue("@nome", txtnomeProduto.Text);
            
            dr = command.ExecuteReader();

            while (dr.Read())
            {
                //txtcodigoProduto.Text = dr["codProduto"].ToString();
                txtquantidadeProduto.Text = dr["quantidade"].ToString();              
                txtvalorCompra.Text = dr["valordeCompra"].ToString();
                txtvalorVenda.Text = dr["valordeVenda"].ToString();
                //cmbtipo.Text = dr["tipo"].ToString();

            }

            dr.Close();
            con.desconectar();
        }

        private void txtnomeProduto_Leave(object sender, EventArgs e)
        {
            preencherCampos();
        }
    }
}
