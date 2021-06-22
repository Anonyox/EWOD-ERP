using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.MODELS.relatorio_modelo;

namespace TCC.VISÃO
{
    public partial class RelatorioVendas : Form
    {

        #region VARIÁVEIS E INSTÂNCIAS
        Worksheet wsheet;
        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
        int rg = 1;

        string codVenda = "";

        relatorioVendasControle relCtr = new relatorioVendasControle();
        #endregion

        #region CONSTRUTOR
        public RelatorioVendas()
        {
            InitializeComponent();
        }

        #endregion

        #region MÉTODOS DE FUNCIONALIDADES

        public void contarEntradas()
        {

        }

        public void contarOperacoes()
        {

        }

        public void contarTotal()
        {

        }


        public void listarVendas()
        {
            System.Data.DataTable dtr = new System.Data.DataTable();



            dtr = relCtr.listarVendas();

            dtgvendas.Rows.Clear();


            foreach (DataRow item in dtr.Rows)
            {

                int n = dtgvendas.Rows.Add();

                dtgvendas.Rows[n].Cells[1].Value = item["codVendaRealizada"].ToString();
                dtgvendas.Rows[n].Cells[2].Value = item["metodoPagamento"].ToString();
                dtgvendas.Rows[n].Cells[3].Value = item["desconto"].ToString();
                dtgvendas.Rows[n].Cells[4].Value = item["totalFinal"].ToString();
                dtgvendas.Rows[n].Cells[5].Value = item["dataVenda"].ToString();




            }
        }

        public void listarProdutosRelacionadosAVenda()
        {
            System.Data.DataTable dtr = new System.Data.DataTable();

            string cod = this.codVenda;

            dtr = relCtr.listarProdutosRelacionadosAVenda(cod);

            dtgitens.Rows.Clear();


            foreach (DataRow item in dtr.Rows)
            {

                int n = dtgitens.Rows.Add();

                dtgitens.Rows[n].Cells[0].Value = item["nomeProduto"].ToString();
                dtgitens.Rows[n].Cells[1].Value = item["tipoProduto"].ToString();
                dtgitens.Rows[n].Cells[2].Value = item["modelo"].ToString();
                dtgitens.Rows[n].Cells[3].Value = item["quantidade"].ToString();
                dtgitens.Rows[n].Cells[4].Value = item["valorDeVenda"].ToString();
                dtgitens.Rows[n].Cells[5].Value = item["totalUnitario"].ToString();




            }
        }

        public void filtrarSemana()
        {

        }

        public void filtrarMes()
        {

        }

        public void filtrarAno()
        {

        }

        public void totalFiltrado()
        {

        }

        public void totalSemFiltrar()
        {

        }


        public void formataGrid()
        {
            formataGridItens();
            // TODO: esta linha de código carrega dados na tabela 'tccDataSet.logs'. Você pode movê-la ou removê-la conforme necessário.
            //this.logsTableAdapter.Fill(this.tccDataSet.logs);
            dtgvendas.BorderStyle = BorderStyle.None;  //DTEMAIL NOME DA VARIÁVEL
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgvendas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            // dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            /// dataGridView1.BackgroundColor = Color.White;

            dtgvendas.EnableHeadersVisualStyles = false;
            dtgvendas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgvendas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 209, 178);     //FromArgb(20, 25, 72);
            dtgvendas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public void formataGridItens()
        {
            // TODO: esta linha de código carrega dados na tabela 'tccDataSet.logs'. Você pode movê-la ou removê-la conforme necessário.
            //this.logsTableAdapter.Fill(this.tccDataSet.logs);
            dtgitens.BorderStyle = BorderStyle.None;  //DTEMAIL NOME DA VARIÁVEL
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgitens.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            // dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            /// dataGridView1.BackgroundColor = Color.White;

            dtgitens.EnableHeadersVisualStyles = false;
            dtgitens.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgitens.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 209, 178);     //FromArgb(20, 25, 72);
            dtgitens.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }


        #endregion

        #region DESIGN


        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dtgestoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex != this.extornar.Index && e.RowIndex >= 0)
            {
                pnitens.Visible = true;
                pnitens.Location = new System.Drawing.Point(94, 260);
            }




        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pnitens.Visible = false;
        }



        #endregion

        private void btnexportarExcel_Click(object sender, EventArgs e)
        {

            if (dtgvendas.Rows.Count > 0)
            {

                try
                {
                    //rg =  XcelApp.Range[XcelApp.Cells[1, "A"], XcelApp.Cells[1, "B"]];
                    //rg2 = wsheet.Range[wsheet.Cells[1, "C"], wsheet.Cells[1, "D"]]; 
                    //rg3 = wsheet.Range[wsheet.Cells[1, "E"], wsheet.Cells[1, "F"]]; 
                    //rg4 = wsheet.Range[wsheet.Cells[1, "G"], wsheet.Cells[1, "H"]];
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dtgvendas.Columns.Count + 1; i++)
                    {
                      

                        Range columnFornecedor = XcelApp.Cells[1, "E"];
                        Range columnTipo = XcelApp.Cells[1, "F"];
                        Range columnModelo = XcelApp.Cells[1, "G"];
                        Range columnQuantidade = XcelApp.Cells[1, "H"];
                        Range columnValordeCompra = XcelApp.Cells[1, "I"];





                        columnFornecedor.Interior.Color = Color.FromArgb(0, 209, 178);
                        columnTipo.Interior.Color = Color.FromArgb(0, 209, 178);
                        columnModelo.Interior.Color = Color.FromArgb(0, 209, 178);
                        columnQuantidade.Interior.Color = Color.FromArgb(0, 209, 178);
                        columnValordeCompra.Interior.Color = Color.FromArgb(0, 209, 178);



                        XcelApp.Cells[1, i + 3] = dtgvendas.Columns[i - 1].HeaderText;
                        rg = rg + 1;

                    }





                    //
                    for (int i = 0; i < dtgvendas.Rows.Count; i++)
                    {
                        this.codVenda = dtgvendas.CurrentRow.Cells[1].Value.ToString();
                        listarProdutosRelacionadosAVenda();

                        for (int j = 1; j < dtgvendas.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 4] = dtgvendas.Rows[i].Cells[j].Value.ToString();



                        }

                        for (int j2 = 0; j2 < dtgitens.Rows.Count; j2++)
                        {

                            for (int i2 = 1; i2 < dtgitens.Columns.Count; i2++)
                            {
                                XcelApp.Cells[j2 + 3, i2 + 4] = dtgitens.Rows[j2].Cells[i2].Value.ToString();
                            }


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

        private void RelatorioVendas_Load(object sender, EventArgs e)
        {
            formataGrid();
            listarVendas();
        }

        private void dtgvendas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            if (e.ColumnIndex == this.extornar.Index && e.RowIndex >= 0)
            {

            }

            else if (e.ColumnIndex != this.extornar.Index && e.RowIndex >= 0)
            {
                // pega a linha atual...
                //DataGridViewRow currentRow = this.lblteste.Rows[e.RowIndex];
                // mostra o form...
                //MessageBox.Show(Convert.ToString(currentRow.Cells[0].Value));



                this.codVenda = dtgvendas.CurrentRow.Cells[1].Value.ToString();

                listarProdutosRelacionadosAVenda();


            }


        }
    }
}
