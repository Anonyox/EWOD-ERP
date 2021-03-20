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
    public partial class ConfigSistema : Form
    {
        public ConfigSistema()
        {
            InitializeComponent();
        }

        private void ConfigSistema_Load(object sender, EventArgs e)
        {
            timer1.Start();
           


            selTotLogs();
            selLogsEdit();
            listarLogs();
            selLogsCad();
            selLogsExclu();

            // TODO: esta linha de código carrega dados na tabela 'tccDataSet.logs'. Você pode movê-la ou removê-la conforme necessário.
            this.logsTableAdapter.Fill(this.tccDataSet.logs);
            dtgLogs.BorderStyle = BorderStyle.None;  //DTEMAIL NOME DA VARIÁVEL
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgLogs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            // dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            /// dataGridView1.BackgroundColor = Color.White;

            dtgLogs.EnableHeadersVisualStyles = false;
            dtgLogs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgLogs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 209, 178);     //FromArgb(20, 25, 72);
            dtgLogs.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpreferenciaSistema_MouseLeave(object sender, EventArgs e)
        {
            btnpreferenciaSistema.Size = new Size(187, 95);
            lblpreferenciaSistema.Visible = false;
        }

        private void btnpreferenciaSistema_MouseEnter(object sender, EventArgs e)
        {
            btnpreferenciaSistema.Size = new Size(200,100);
            lblpreferenciaSistema.Visible = true;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnalterarUsuario.Size = new Size(190, 100);
            lblalterarUsuario.Visible = true;
        }

        private void btnalterarUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnalterarUsuario.Size = new Size(187, 95);
            lblalterarUsuario.Visible = false;
        }

        private void btnalterarUsuario_Click(object sender, EventArgs e)
        {
            EditarUsuario editUser = new EditarUsuario();
            editUser.Show();
        }

 
        public void listarLogs()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();


            cmd.CommandText = "select  tipo, Convert (varchar(20),dataLog, 113) AS [dataLog] ,  usuario , perfil from logs Order By codLog DESC";
            cmd.Connection = con.conectar();


            try
            {
                con.conectar();
                cmd.ExecuteNonQuery();


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);






                dtgLogs.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dtgLogs.Rows.Add();
                    
                    dtgLogs.Rows[n].Cells[0].Value = item["Tipo"].ToString();
                    dtgLogs.Rows[n].Cells[1].Value = item["dataLog"].ToString();
                    dtgLogs.Rows[n].Cells[2].Value = item["usuario"].ToString();
                    dtgLogs.Rows[n].Cells[3].Value = item["perfil"].ToString();











                }
                con.desconectar();
                //dtEmail.DataSource = dt;



            }
            catch (Exception)
            {

                throw;
            }
        }

        
        public void selLogsCad()
        {
           
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select count (tipo) from logs where tipo like 'Cad%'";

            
            

            con.conectar();
            cmd.Connection = con.conectar();

          


            try
            {

                SqlDataReader reg = cmd.ExecuteReader();
                while (reg.Read())
                {
                    lblLogCadastro.Text = reg.GetValue(0).ToString();
                }






                
                
                con.desconectar();
                //dtEmail.DataSource = dt;



            }
            catch (Exception)
            {

                throw;
            }
        }

        public void selLogsExclu()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select count (tipo) from logs where tipo like 'Exclu%'";

            con.conectar();
            cmd.Connection = con.conectar();

            try
            {
                SqlDataReader reg = cmd.ExecuteReader();
                while(reg.Read())
                {
                    lblExcluUsuario.Text = reg.GetValue(0).ToString();
                }


                con.desconectar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void selLogsEdit()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select count (tipo) from logs where tipo like 'Edit%'";

            con.conectar();

            cmd.Connection = con.conectar();

            try
            {
                SqlDataReader reg = cmd.ExecuteReader();
                while (reg.Read())
                {
                    lblEditUsuario.Text = reg.GetValue(0).ToString();
                }


                con.desconectar();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void selTotLogs()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select count (tipo) from logs";


            con.conectar();
            cmd.Connection = con.conectar();

            try
            {
                SqlDataReader reg = cmd.ExecuteReader();
                while (reg.Read()) 
                {
                    lblTotLogs.Text = reg.GetValue(0).ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }

                    
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogCadastro_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listarLogs();

            timer1.Start();
        }
    }
}
