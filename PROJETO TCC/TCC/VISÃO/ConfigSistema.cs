using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TCC.MODELO;

namespace TCC.VISÃO
{
    public partial class ConfigSistema : Form
    {

        //CLASSE PRINCIPAL CONFIGURAÇOES DO SISTEMA






        #region VARIÁVEIS E INSTÂNCIAS
        ControleConfigSistema controleConfigSistema = new ControleConfigSistema();

        SqlDataReader regCad;

        SqlDataReader regExc;

        SqlDataReader regAlt;

        SqlDataReader regTot;
        #endregion






        #region CONSTRUTOR

        public ConfigSistema()
        {
            InitializeComponent();
        }

        #endregion






        #region MÉTODOS DE FUNCIONALIDADES

        public void listarLogs()
        {
            DataTable dt = controleConfigSistema.listarLogs();

            dtgLogs.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dtgLogs.Rows.Add();

                dtgLogs.Rows[n].Cells[0].Value = item["Tipo"].ToString();
                dtgLogs.Rows[n].Cells[1].Value = item["dataLog"].ToString();
                dtgLogs.Rows[n].Cells[2].Value = item["usuario"].ToString();
                dtgLogs.Rows[n].Cells[3].Value = item["perfil"].ToString();

            }
        } //LISTAGEM DE LOGS

        public void selLogsCad()
        {
            regCad = controleConfigSistema.selLogsCad();
            lblLogCadastro.Text = regCad.GetValue(0).ToString();
        } //LISTAGEM DE LOGS TOTAL DE CADASTROS

        public void selLogsExclu()
        {
            regExc = controleConfigSistema.selLogsCad();
            lblExcluUsuario.Text = regExc.GetValue(0).ToString();
        } //LISTAGENS DE LOGS TOTAL DE EXCLUSÃO 

        public void selLogsAlt()
        {
            regAlt = controleConfigSistema.selLogsAlt();
            lblEditUsuario.Text = regAlt.GetValue(0).ToString();
        } //LISTAGENS DE LOGS TOTAL DE ALTERAÇÃO

        public void selTotLogs()
        {
            regTot = controleConfigSistema.selLogsTot();
            lblTotLogs.Text = regTot.GetValue(0).ToString();
        } //LISTAGENS DE LOGS TOTAL

        #endregion






        #region DESIGN
        private void ConfigSistema_Load(object sender, EventArgs e)
        {
            //timer1.Start();

            listarLogs();

            selLogsCad();

            selLogsExclu();

            selLogsAlt();

            selTotLogs();
            
            

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
            btnpreferenciaSistema.Size = new Size(200, 100);
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

        #endregion






    }
}