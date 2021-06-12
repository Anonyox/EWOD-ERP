using System;
using System.Data;
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

        String regCad;

        String regExc;

        String regAlt;

        String regTot;
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
            lblLogCadastro.Text = regCad;
        } //LISTAGEM DE LOGS TOTAL DE CADASTROS

        public void selLogsExclu()
        {
            regExc = controleConfigSistema.selLogsExclu();
            lblExcluUsuario.Text = regExc;
        } //LISTAGENS DE LOGS TOTAL DE EXCLUSÃO 

        public void selLogsAlt()
        {
            regAlt = controleConfigSistema.selLogsAlt();
            lblEditUsuario.Text = regAlt;
        } //LISTAGENS DE LOGS TOTAL DE ALTERAÇÃO

        public void selTotLogs()
        {
            regTot = controleConfigSistema.selLogsTot();
            lblTotLogs.Text = regTot;
        } //LISTAGENS DE LOGS TOTAL

        public void formataGrid()
        {
            // TODO: esta linha de código carrega dados na tabela 'tccDataSet.logs'. Você pode movê-la ou removê-la conforme necessário.
            //this.logsTableAdapter.Fill(this.tccDataSet.logs);
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
        } //FORMATA GRID PARA PADRÃO 

        #endregion






        #region DESIGN
        private void ConfigSistema_Load(object sender, EventArgs e)
        {
            //INICIALIZAÇÃO FORMATANDO GRID
            formataGrid();

            //TIMER START
            timer1.Start();


            //LOGS
            listarLogs();

            selLogsCad();

            selLogsExclu();

            selLogsAlt();

            selTotLogs();

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

            selLogsCad();

            selLogsExclu();

            selLogsAlt();

            selTotLogs();


            timer1.Start();
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }




        #endregion

        private void btnfiltrarCadastros_MouseEnter(object sender, EventArgs e)
        {
            lblcadastros.Visible = true;
            btnfiltrarCadastros.Size = new Size(70,40);
        }

        private void btnfiltrarCadastros_MouseLeave(object sender, EventArgs e)
        {
            lblcadastros.Visible = false;
            btnfiltrarCadastros.Size = new Size(70,38);
        }

        private void btntodasAsOperacoes_Click(object sender, EventArgs e)
        {
            listarLogs();
        }

        private void btntodasAsOperacoes_MouseEnter(object sender, EventArgs e)
        {
            lbloperacoes.Visible = true;
            btntodasAsOperacoes.Size = new Size(70, 40);
        }

        private void btntodasAsOperacoes_MouseLeave(object sender, EventArgs e)
        {
            lbloperacoes.Visible = false;
            btntodasAsOperacoes.Size = new Size(70, 38);
        }

        private void btnfiltrarExclusoes_MouseEnter(object sender, EventArgs e)
        {
            lblexclu.Visible = true;
            btnfiltrarExclusoes.Size = new Size(70,48 );
        }

        private void btnfiltrarExclusoes_MouseLeave(object sender, EventArgs e)
        {
            lblexclu.Visible = false;
            btnfiltrarExclusoes.Size = new Size(70,45);
        }

        private void btnexportar_MouseEnter(object sender, EventArgs e)
        {
            lblexportar.Visible = true;
            btnexportar.Size = new Size(70, 45);
        }

        private void btnexportar_MouseLeave(object sender, EventArgs e)
        {
            lblexportar.Visible = true;
            btnexportar.Size = new Size(70, 38);
        }

        private void btnfiltrarAlteracoes_MouseEnter(object sender, EventArgs e)
        {
            lblalteracoes.Visible = true;
            btnfiltrarAlteracoes.Size = new Size(70, 40);
        }

        private void btnfiltrarAlteracoes_MouseLeave(object sender, EventArgs e)
        {
            lblalteracoes.Visible = false;
            btnfiltrarAlteracoes.Size = new Size(70, 38);
        }
    }
}