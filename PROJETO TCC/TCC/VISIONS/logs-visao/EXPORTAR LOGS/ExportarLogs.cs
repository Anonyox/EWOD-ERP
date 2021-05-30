using System;
using System.Drawing;
using System.Windows.Forms;
using TCC.VISÃO;
using ClosedXML.Excel;
using TCC.CONTROLE;
using System.Data.SqlClient;

namespace TCC.VISIONS.logs_visao.EXPORTAR_LOGS
{
    public partial class ExportarLogs : Form
    {
        #region VARIÁVEIS E INSTÂNCIAS
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        ConfigSistema config = new ConfigSistema();
        SaveFileDialog salvar = new SaveFileDialog();
        XLWorkbook wb = new XLWorkbook();
        private IXLWorksheet ws;
        private IXLRange range;
        public string codLog;
        public string tipo;
        public string dataLog;
        public string usuario;
        public string perfil;


        #endregion


        #region CONSTRUTOR
        public ExportarLogs()
        {
            InitializeComponent();
        }

        #endregion



        #region MÉTODOS DE FUNCIONALIDADES

        private void exportarExcel()
        {
;           cmd.CommandText = "SELECT codLog,tipo,dataLog,usuario,perfil FROM logs";
            cmd.Parameters.AddWithValue("codLog",codLog);
            cmd.Parameters.AddWithValue("tipo",tipo);
            cmd.Parameters.AddWithValue("dataLog",dataLog);
            cmd.Parameters.AddWithValue("usuario",usuario);
            con.conectar();
            ws = wb.Worksheets.Add("TABELA_LOGS");

            //TÍTULO DA PLANILHA
            ws.Cell("C2").Value = "TABELA DE LOGS";
            range = ws.Range("C2:J2");
            range.Merge().Style.Font.SetBold().Font.FontSize = 20;

            //COLUNAS


        }


        #endregion



        #region DESIGN
        private void btnescolhaDiretorio_Click(object sender, EventArgs e)
        {
            exportarExcel();
        }

        private void ExportarLogs_Load(object sender, EventArgs e)
        {
            txttabela.Text = "logs";
        }


        private void btngerarExcel_MouseEnter(object sender, EventArgs e)
        {
            btnexportarExcel.Size = new Size(87, 67);
            lblexportar.Visible = true;

        }

        private void btnexportarExcel_MouseLeave(object sender, EventArgs e)
        {
            btnexportarExcel.Size = new Size(81, 61);
            lblexportar.Visible = false;
        }

        private void btnabrirExcel_MouseEnter(object sender, EventArgs e)
        {
            btnabrirExcel.Size = new Size(87, 67);
            lblabrir.Visible = true;
        }

        private void btnabrirExcel_MouseLeave(object sender, EventArgs e)
        {
            btnabrirExcel.Size = new Size(81, 61);
            lblabrir.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            /*ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);*/
        }



        #endregion

        
    }
}
