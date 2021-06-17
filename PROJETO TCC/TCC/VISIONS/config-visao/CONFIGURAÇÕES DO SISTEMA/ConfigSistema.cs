using Microsoft.Office.Interop.Excel;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
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

        public string msglogs;

        DataGridViewTextBoxColumn produtobaixado = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn qtdprodutoBaixado = new DataGridViewTextBoxColumn();

        Worksheet wsheet;
        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
        String prodBaixado;
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
            System.Data.DataTable dt = controleConfigSistema.listarLogs();

            dtgLogs.Rows.Clear();

            if (dtgLogs.Columns.Contains(produtobaixado) && dtgLogs.Columns.Contains(qtdprodutoBaixado))
            {
                dtgLogs.Columns.Remove(produtobaixado);
                dtgLogs.Columns.Remove(qtdprodutoBaixado);

            }

            foreach (DataRow item in dt.Rows)
            {
               
                int n = dtgLogs.Rows.Add();

                dtgLogs.Rows[n].Cells[0].Value = item["Tipo"].ToString();
                dtgLogs.Rows[n].Cells[1].Value = item["dataLog"].ToString();
                dtgLogs.Rows[n].Cells[2].Value = item["usuario"].ToString();
                dtgLogs.Rows[n].Cells[3].Value = item["perfil"].ToString();
               
                






            }
        } //LISTAGEM DE LOGS

        public void listarLogsCad()
        {
            System.Data.DataTable dt = controleConfigSistema.listarLogsCad();

            dtgLogs.Rows.Clear();


            if (dtgLogs.Columns.Contains(produtobaixado) && dtgLogs.Columns.Contains(qtdprodutoBaixado))
            {
                dtgLogs.Columns.Remove(produtobaixado);
                dtgLogs.Columns.Remove(qtdprodutoBaixado);

            }

            foreach (DataRow item in dt.Rows)
            {

                int n = dtgLogs.Rows.Add();

                dtgLogs.Rows[n].Cells[0].Value = item["Tipo"].ToString();
                dtgLogs.Rows[n].Cells[1].Value = item["dataLog"].ToString();
                dtgLogs.Rows[n].Cells[2].Value = item["usuario"].ToString();
                dtgLogs.Rows[n].Cells[3].Value = item["perfil"].ToString();
                







            }
        } //LISTAGEM DE LOGS

        public void listarLogsExclu()
        {
            System.Data.DataTable dt = controleConfigSistema.listarLogsExclu();

            dtgLogs.Rows.Clear();


            if (dtgLogs.Columns.Contains(produtobaixado) && dtgLogs.Columns.Contains(qtdprodutoBaixado))
            {
                dtgLogs.Columns.Remove(produtobaixado);
                dtgLogs.Columns.Remove(qtdprodutoBaixado);

            }

            foreach (DataRow item in dt.Rows)
            {

                int n = dtgLogs.Rows.Add();

                dtgLogs.Rows[n].Cells[0].Value = item["Tipo"].ToString();
                dtgLogs.Rows[n].Cells[1].Value = item["dataLog"].ToString();
                dtgLogs.Rows[n].Cells[2].Value = item["usuario"].ToString();
                dtgLogs.Rows[n].Cells[3].Value = item["perfil"].ToString();
                







            }
        } //LISTAGEM DE LOGS

        public void listarLogsAlt()
        {
            System.Data.DataTable dt = controleConfigSistema.listarLogsAlt();

            dtgLogs.Rows.Clear();


            if (dtgLogs.Columns.Contains(produtobaixado) && dtgLogs.Columns.Contains(qtdprodutoBaixado))
            {
                dtgLogs.Columns.Remove(produtobaixado);
                dtgLogs.Columns.Remove(qtdprodutoBaixado);

            }

            foreach (DataRow item in dt.Rows)
            {

                int n = dtgLogs.Rows.Add();

                dtgLogs.Rows[n].Cells[0].Value = item["Tipo"].ToString();
                dtgLogs.Rows[n].Cells[1].Value = item["dataLog"].ToString();
                dtgLogs.Rows[n].Cells[2].Value = item["usuario"].ToString();
                dtgLogs.Rows[n].Cells[3].Value = item["perfil"].ToString();
                







            }
        } //LISTAGEM DE LOGS

        public void listarLogsBaix()
        {
            System.Data.DataTable dt = controleConfigSistema.listarLogsBaix();

            dtgLogs.Rows.Clear();

           
            produtobaixado.Name = "produtobaixado";
            produtobaixado.HeaderText = "Produto Baixado";

           
            qtdprodutoBaixado.Name = "qtdprodutoBaixado";
            qtdprodutoBaixado.HeaderText = "Quantidade Baixada";


            if (!dtgLogs.Columns.Contains(produtobaixado) && !dtgLogs.Columns.Contains(qtdprodutoBaixado))
            {
                dtgLogs.Columns.Insert(4, produtobaixado);
                dtgLogs.Columns.Insert(5, qtdprodutoBaixado);
            }
          
            foreach (DataRow item in dt.Rows)
            {

                int n = dtgLogs.Rows.Add();

                dtgLogs.Rows[n].Cells[0].Value = item["Tipo"].ToString();
                dtgLogs.Rows[n].Cells[1].Value = item["dataLog"].ToString();
                dtgLogs.Rows[n].Cells[2].Value = item["usuario"].ToString();
                dtgLogs.Rows[n].Cells[3].Value = item["perfil"].ToString();
                dtgLogs.Rows[n].Cells[4].Value = item["produtobaixado"].ToString();
                dtgLogs.Rows[n].Cells[5].Value = item["qtdprodutoBaixado"].ToString();








            }
        } //LISTAGEM DE LOGS

        public void listarLogsAcess()
        {
            System.Data.DataTable dt = controleConfigSistema.listarLogsAcess();

            dtgLogs.Rows.Clear();

            if (dtgLogs.Columns.Contains(produtobaixado) && dtgLogs.Columns.Contains(qtdprodutoBaixado))
            {
                dtgLogs.Columns.Remove(produtobaixado);
                dtgLogs.Columns.Remove(qtdprodutoBaixado);

            }

            foreach (DataRow item in dt.Rows)
            {

                int n = dtgLogs.Rows.Add();

                dtgLogs.Rows[n].Cells[0].Value = item["Tipo"].ToString();
                dtgLogs.Rows[n].Cells[1].Value = item["dataLog"].ToString();
                dtgLogs.Rows[n].Cells[2].Value = item["usuario"].ToString();
                dtgLogs.Rows[n].Cells[3].Value = item["perfil"].ToString();








            }
        } //LISTAGEM DE LOGS

        public void listarLogsPorUser()
        {
            System.Data.DataTable dt = controleConfigSistema.listarLogsPorUser(txtuser.Text);

            dtgLogs.Rows.Clear();

            if (dtgLogs.Columns.Contains(produtobaixado) && dtgLogs.Columns.Contains(qtdprodutoBaixado))
            {
                dtgLogs.Columns.Remove(produtobaixado);
                dtgLogs.Columns.Remove(qtdprodutoBaixado);

            }

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

        public void deletarLogs()
        {
            List<DeletarLogs> Logs = new List<DeletarLogs>();

            foreach (DataGridViewRow dataGridViewRow in dtgLogs.Rows)
            {
                Logs.Add(
                    new DeletarLogs(dataGridViewRow.Cells["Tipo"].Value.ToString()

                                  )
                             );
            }

            foreach (var lg in Logs)
            {
                this.msglogs = controleConfigSistema.deletaLogs(lg.tipo);
                if (controleConfigSistema.tem)
                {
                   
                    listarLogs();

                    selLogsCad();

                    selLogsExclu();

                    selLogsAlt();

                    selTotLogs();



                }
                else
                {
                    MessageBox.Show(msglogs, "OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                

            }

            MessageBox.Show(msglogs, "OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listarLogs();

            selLogsCad();

            selLogsExclu();

            selLogsAlt();

            selTotLogs();


        }

        public struct DeletarLogs
        {
            public String tipo;


            public DeletarLogs(String _tipo)
            {
                tipo = _tipo;
                

            }
        }

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

            selLogsCad();

            selLogsExclu();

            selLogsAlt();

            selTotLogs();
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
            btnexportar.Size = new Size(77, 47);
        }

        private void btnexportar_MouseLeave(object sender, EventArgs e)
        {
            btnexportar.Size = new Size(74, 40);
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

        private void btnbaixas_MouseEnter(object sender, EventArgs e)
        {
            lblbaixas.Visible = true;
            btnbaixas.Size = new Size(70, 40);
        }

        private void btnbaixas_MouseLeave(object sender, EventArgs e)
        {
            lblbaixas.Visible = false;
            btnbaixas.Size = new Size(70, 38);
        }

        private void btnfiltrarCadastros_Click(object sender, EventArgs e)
        {
            listarLogsCad();
        }

        private void btnfiltrarExclusoes_Click(object sender, EventArgs e)
        {
            listarLogsExclu();
        }

        private void btnfiltrarAlteracoes_Click(object sender, EventArgs e)
        {
            listarLogsAlt();
        }

        private void btnbaixas_Click(object sender, EventArgs e)
        {
            listarLogsBaix();
        }

        private void btnexportarExcel_MouseEnter(object sender, EventArgs e)
        {
            btnexportarExcel.Size = new Size(77, 47);
        }

        private void btnexportarExcel_MouseLeave(object sender, EventArgs e)
        {
            btnexportarExcel.Size = new Size(74, 40);
        }

        private void btnexportarExcel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja EXPORTAR os Logs do Sistema e excluir do Sistema?", "OPERAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dtgLogs.Rows.Count > 0)
                {
                    try
                    {
                        //rg =  XcelApp.Range[XcelApp.Cells[1, "A"], XcelApp.Cells[1, "B"]];
                        //rg2 = wsheet.Range[wsheet.Cells[1, "C"], wsheet.Cells[1, "D"]]; 
                        //rg3 = wsheet.Range[wsheet.Cells[1, "E"], wsheet.Cells[1, "F"]]; 
                        //rg4 = wsheet.Range[wsheet.Cells[1, "G"], wsheet.Cells[1, "H"]];
                        XcelApp.Application.Workbooks.Add(Type.Missing);

                        if (dtgLogs.Columns.Contains(produtobaixado) && dtgLogs.Columns.Contains(qtdprodutoBaixado))
                        {
                            for (int i = 1; i < dtgLogs.Columns.Count + 1; i++)
                            {
                                Range columnTipo = XcelApp.Cells[1, "D"];
                                Range columnDataLog = XcelApp.Cells[1, "E"];
                                Range columnUsuario = XcelApp.Cells[1, "F"];
                                Range columnPerfil = XcelApp.Cells[1, "G"];
                                Range columnProdutoBaixado = XcelApp.Cells[1, "H"];
                                Range columnQuantidadeBaixada = XcelApp.Cells[1, "I"];





                                columnTipo.Interior.Color = Color.FromArgb(0, 209, 178);
                                columnDataLog.Interior.Color = Color.FromArgb(0, 209, 178);
                                columnUsuario.Interior.Color = Color.FromArgb(0, 209, 178);
                                columnPerfil.Interior.Color = Color.FromArgb(0, 209, 178);
                                columnProdutoBaixado.Interior.Color = Color.FromArgb(0, 209, 178);
                                columnQuantidadeBaixada.Interior.Color = Color.FromArgb(0, 209, 178);



                                XcelApp.Cells[1, i + 3] = dtgLogs.Columns[i - 1].HeaderText;
                            }

                        }

                        else
                        {
                            for (int i = 1; i < dtgLogs.Columns.Count + 1; i++)
                            {
                                Range columnTipo = XcelApp.Cells[1, "D"];
                                Range columnDataLog = XcelApp.Cells[1, "E"];
                                Range columnUsuario = XcelApp.Cells[1, "F"];
                                Range columnPerfil = XcelApp.Cells[1, "G"];






                                columnTipo.Interior.Color = Color.FromArgb(0, 209, 178);
                                columnDataLog.Interior.Color = Color.FromArgb(0, 209, 178);
                                columnUsuario.Interior.Color = Color.FromArgb(0, 209, 178);
                                columnPerfil.Interior.Color = Color.FromArgb(0, 209, 178);




                                XcelApp.Cells[1, i + 3] = dtgLogs.Columns[i - 1].HeaderText;
                            }
                        }

                        //
                        for (int i = 0; i < dtgLogs.Rows.Count; i++)
                        {
                            for (int j = 0; j < dtgLogs.Columns.Count; j++)
                            {
                                XcelApp.Cells[i + 2, j + 4] = dtgLogs.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        //
                        XcelApp.Columns.AutoFit();
                        //
                        XcelApp.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message);
                        XcelApp.Quit();
                    }
                }


                deletarLogs();

                


            }
            else
            {
                if (dtgLogs.Rows.Count > 0)
            {
                try
                {
                    //rg =  XcelApp.Range[XcelApp.Cells[1, "A"], XcelApp.Cells[1, "B"]];
                    //rg2 = wsheet.Range[wsheet.Cells[1, "C"], wsheet.Cells[1, "D"]]; 
                    //rg3 = wsheet.Range[wsheet.Cells[1, "E"], wsheet.Cells[1, "F"]]; 
                    //rg4 = wsheet.Range[wsheet.Cells[1, "G"], wsheet.Cells[1, "H"]];
                    XcelApp.Application.Workbooks.Add(Type.Missing);

                    if (dtgLogs.Columns.Contains(produtobaixado) && dtgLogs.Columns.Contains(qtdprodutoBaixado))
                    {
                        for (int i = 1; i < dtgLogs.Columns.Count + 1; i++)
                        {
                            Range columnTipo = XcelApp.Cells[1, "D"];
                            Range columnDataLog = XcelApp.Cells[1, "E"];
                            Range columnUsuario = XcelApp.Cells[1, "F"];
                            Range columnPerfil = XcelApp.Cells[1, "G"];
                            Range columnProdutoBaixado = XcelApp.Cells[1, "H"];
                            Range columnQuantidadeBaixada = XcelApp.Cells[1, "I"];





                            columnTipo.Interior.Color = Color.FromArgb(0, 209, 178);
                            columnDataLog.Interior.Color = Color.FromArgb(0, 209, 178);
                            columnUsuario.Interior.Color = Color.FromArgb(0, 209, 178);
                            columnPerfil.Interior.Color = Color.FromArgb(0, 209, 178);
                            columnProdutoBaixado.Interior.Color = Color.FromArgb(0, 209, 178);
                            columnQuantidadeBaixada.Interior.Color = Color.FromArgb(0, 209, 178);



                            XcelApp.Cells[1, i + 3] = dtgLogs.Columns[i - 1].HeaderText;
                        }

                    }

                    else
                    {
                        for (int i = 1; i < dtgLogs.Columns.Count + 1; i++)
                        {
                            Range columnTipo = XcelApp.Cells[1, "D"];
                            Range columnDataLog = XcelApp.Cells[1, "E"];
                            Range columnUsuario = XcelApp.Cells[1, "F"];
                            Range columnPerfil = XcelApp.Cells[1, "G"];






                            columnTipo.Interior.Color = Color.FromArgb(0, 209, 178);
                            columnDataLog.Interior.Color = Color.FromArgb(0, 209, 178);
                            columnUsuario.Interior.Color = Color.FromArgb(0, 209, 178);
                            columnPerfil.Interior.Color = Color.FromArgb(0, 209, 178);




                            XcelApp.Cells[1, i + 3] = dtgLogs.Columns[i - 1].HeaderText;
                        }
                    }

                    //
                    for (int i = 0; i < dtgLogs.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtgLogs.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 4] = dtgLogs.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
            }

        }

        private void btnacessos_MouseEnter(object sender, EventArgs e)
        {

            lblacessos.Visible = true;
            btnacessos.Size = new Size(70, 40);
        }

        private void btnacessos_MouseLeave(object sender, EventArgs e)
        {
            lblacessos.Visible = false;
            btnacessos.Size = new Size(70, 38);
        }

        private void btnacessos_Click(object sender, EventArgs e)
        {
            listarLogsAcess();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            listarLogsPorUser();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            if(txtuser.Text == "")
            {
                listarLogs();
            }
        }

        private void btnbuscar_MouseEnter(object sender, EventArgs e)
        {
            btnbuscar.Size = new Size(37, 30);
        }

        private void btnbuscar_MouseLeave(object sender, EventArgs e)
        {
            btnbuscar.Size = new Size(37, 28);
        }
    }
}