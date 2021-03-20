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
    public partial class CadastroVendas : Form
    {
        int codOperacao = 0;
        String recebeCodOperacao = "0";
        int validaMsg = 0;
        public CadastroVendas()
        {
            InitializeComponent();
           
        }

        private void CadastroVendas_Load(object sender, EventArgs e)
        {
            timer1.Start();
            // TODO: esta linha de código carrega dados na tabela 'tccDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.tccDataSet.produtos);

            lblteste.BorderStyle = BorderStyle.None;  //DTEMAIL NOME DA VARIÁVEL
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lblteste.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            // dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            /// dataGridView1.BackgroundColor = Color.White;

            lblteste.EnableHeadersVisualStyles = false;
            lblteste.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lblteste.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 209, 178);     //FromArgb(20, 25, 72);
            lblteste.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            
        }

        public void listaCarrinho()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();


            cmd.CommandText = "select * from itemDePedido where codOperacao = @codOperacao ";
            cmd.Parameters.AddWithValue("@codOperacao", codOperacao);
            cmd.Connection = con.conectar();


            try
            {
                con.conectar();
                cmd.ExecuteNonQuery();


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);






                lblteste.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = lblteste.Rows.Add();
                    lblteste.Rows[n].Cells[1].Value = item["coddeOperacao"].ToString();
                    lblteste.Rows[n].Cells[2].Value = item["produtoPedido"].ToString();
                    lblteste.Rows[n].Cells[3].Value = item["tipoProduto"].ToString();
                    lblteste.Rows[n].Cells[4].Value = item["estiloModelo"].ToString();
                    lblteste.Rows[n].Cells[5].Value = item["valordeCompraPedido"].ToString();
                    lblteste.Rows[n].Cells[6].Value = item["valordeVendaPedido"].ToString();
                    lblteste.Rows[n].Cells[7].Value = item["quantidadePedido"].ToString();












                }
                con.desconectar();
                //dtEmail.DataSource = dt;



            }
            catch (Exception)
            {

                throw;
            }
        }

        public void procuraCodigoOperacao()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = ("SELECT MAX(codUser) FROM logins");
            con.conectar();
            cmd.Connection = con.conectar();




            try
            {

                SqlDataReader reg = cmd.ExecuteReader();
                while (reg.Read())
                {
                    recebeCodOperacao = reg.GetValue(0).ToString();
                    codOperacao = Convert.ToInt32(recebeCodOperacao);
                    codOperacao = codOperacao + 1;
                    txtTotal.Text = codOperacao.ToString();
                }








                con.desconectar();
                //dtEmail.DataSource = dt;



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            procuraCodigoOperacao();

            lsbProduto.Enabled = true;
            txttipo.Enabled = true;
            txtvalordeCompra.Enabled = true;
            txtvalorDeVenda.Enabled = true;
            txtquantidade.Enabled = true;
            txtestiloModelo.Enabled = true;

            lsbProduto.Focus();
            btnCadastrar.Enabled = false;
            btnCancelar.Enabled = true;
            btnAdicionar.Enabled = true;



        }

       

       

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrar.Size = new Size(90, 43);
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrar.Size = new Size(65, 43);
        }

        private void btnExtornar_MouseEnter(object sender, EventArgs e)
        {
            btnExtornar.Size = new Size(90, 43);
        }

        private void btnExtornar_MouseLeave(object sender, EventArgs e)
        {
            btnExtornar.Size = new Size(65, 43);
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.Size = new Size(90, 43);
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.Size = new Size(65, 43);
        }

        private void btnAdicionar_MouseEnter(object sender, EventArgs e)
        {
            btnAdicionar.Size = new Size(90, 43);
        }

        private void btnAdicionar_MouseLeave(object sender, EventArgs e)
        {
            btnAdicionar.Size = new Size(65, 43);
        }

        private void btnFinalizar_MouseEnter(object sender, EventArgs e)
        {
            btnFinalizar.Size = new Size(90, 43);
        }

        private void btnFinalizar_MouseLeave(object sender, EventArgs e)
        {
            btnFinalizar.Size = new Size(65, 43);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 0;
            

            txtTotal.Text = Convert.ToString(i);
            
            timer1.Start();
            

        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if(validaMsg == 0)
            {
                MessageBox.Show("Para realizar uma venda, clique no botão adicionar", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            validaMsg = 1;
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lsbProduto.Enabled = false;
            txttipo.Enabled = false;
            txtvalordeCompra.Enabled = false;
            txtvalorDeVenda.Enabled = false;
            txtquantidade.Enabled = false;
            txtestiloModelo.Enabled = false;

            btnCadastrar.Enabled = true;
            btnAdicionar.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
