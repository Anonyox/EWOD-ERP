using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
        int op1 = 0;
        int tott = 0;

        String total;

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

        public void contarTotal()
        {
            total = relCtr.contarTotal(total);

            if(total == "")
            {
                lbltot.Text = "R$ ";
            }
            else
            {
            lbltot.Text = total;
            }
        }

        public void filtrarSemana()
        {
            System.Data.DataTable dtdd = new System.Data.DataTable();
            System.Data.DataTable dtd2 = new System.Data.DataTable();

            dtdd = relCtr.filtrarSemana();
            dtd2 = relCtr.filtrarSemanaItens();



            dtgvendas.Rows.Clear();

            foreach (DataRow item in dtdd.Rows)
            {
                int n = dtgvendas.Rows.Add();

                dtgvendas.Rows[n].Cells[1].Value = item["codVendaRealizada"].ToString();
                dtgvendas.Rows[n].Cells[2].Value = item["metodoPagamento"].ToString();
                dtgvendas.Rows[n].Cells[3].Value = item["desconto"].ToString();
                dtgvendas.Rows[n].Cells[4].Value = item["totalFinal"].ToString();
                dtgvendas.Rows[n].Cells[5].Value = item["dataVenda"].ToString();


            }

           // foreach (DataRow item in dtd2.Rows)
            //{

              //  int n = dtgitens.Rows.Add();

              //  dtgitens.Rows[n].Cells[0].Value = item["codVendaRealizada"].ToString();
              //  dtgitens.Rows[n].Cells[1].Value = item["nomeProduto"].ToString();
              //  dtgitens.Rows[n].Cells[2].Value = item["tipoProduto"].ToString();
               // dtgitens.Rows[n].Cells[3].Value = item["modelo"].ToString();
               // dtgitens.Rows[n].Cells[4].Value = item["quantidade"].ToString();
               // dtgitens.Rows[n].Cells[5].Value = item["valorDeVenda"].ToString();
               // dtgitens.Rows[n].Cells[6].Value = item["totalUnitario"].ToString();




            //}


        }

        public void filtrarMes()
        {
            System.Data.DataTable dtd = new System.Data.DataTable();
            System.Data.DataTable dtd2 = new System.Data.DataTable();

            dtd = relCtr.filtrarMes();
            dtd2 = relCtr.filtrarMesItens();

            dtgvendas.Rows.Clear();

            foreach (DataRow item in dtd.Rows)
            {
                int n = dtgvendas.Rows.Add();

                dtgvendas.Rows[n].Cells[1].Value = item["codVendaRealizada"].ToString();
                dtgvendas.Rows[n].Cells[2].Value = item["metodoPagamento"].ToString();
                dtgvendas.Rows[n].Cells[3].Value = item["desconto"].ToString();
                dtgvendas.Rows[n].Cells[4].Value = item["totalFinal"].ToString();
                dtgvendas.Rows[n].Cells[5].Value = item["dataVenda"].ToString();


            }

            foreach (DataRow item in dtd2.Rows)
            {

                int n = dtgitens.Rows.Add();

                dtgitens.Rows[n].Cells[0].Value = item["codVendaRealizada"].ToString();
                dtgitens.Rows[n].Cells[1].Value = item["nomeProduto"].ToString();
                dtgitens.Rows[n].Cells[2].Value = item["tipoProduto"].ToString();
                dtgitens.Rows[n].Cells[3].Value = item["modelo"].ToString();
                dtgitens.Rows[n].Cells[4].Value = item["quantidade"].ToString();
                dtgitens.Rows[n].Cells[5].Value = item["valorDeVenda"].ToString();
                dtgitens.Rows[n].Cells[6].Value = item["totalUnitario"].ToString();




            }



        }

        public void filtrarAno()
        {
            System.Data.DataTable dtd = new System.Data.DataTable();
            System.Data.DataTable dtd2 = new System.Data.DataTable();

            dtd = relCtr.filtrarAno();
            dtd2 = relCtr.filtrarAnoItens();

            dtgvendas.Rows.Clear();

            foreach (DataRow item in dtd.Rows)
            {
                int n = dtgvendas.Rows.Add();

                dtgvendas.Rows[n].Cells[1].Value = item["codVendaRealizada"].ToString();
                dtgvendas.Rows[n].Cells[2].Value = item["metodoPagamento"].ToString();
                dtgvendas.Rows[n].Cells[3].Value = item["desconto"].ToString();
                dtgvendas.Rows[n].Cells[4].Value = item["totalFinal"].ToString();
                dtgvendas.Rows[n].Cells[5].Value = item["dataVenda"].ToString();


            }

            foreach (DataRow item in dtd2.Rows)
            {

                int n = dtgitens.Rows.Add();

                dtgitens.Rows[n].Cells[0].Value = item["codVendaRealizada"].ToString();
                dtgitens.Rows[n].Cells[1].Value = item["nomeProduto"].ToString();
                dtgitens.Rows[n].Cells[2].Value = item["tipoProduto"].ToString();
                dtgitens.Rows[n].Cells[3].Value = item["modelo"].ToString();
                dtgitens.Rows[n].Cells[4].Value = item["quantidade"].ToString();
                dtgitens.Rows[n].Cells[5].Value = item["valorDeVenda"].ToString();
                dtgitens.Rows[n].Cells[6].Value = item["totalUnitario"].ToString();




            }
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

                dtgitens.Rows[n].Cells[0].Value = item["codVendaRealizada"].ToString();
                dtgitens.Rows[n].Cells[1].Value = item["nomeProduto"].ToString();
                dtgitens.Rows[n].Cells[2].Value = item["tipoProduto"].ToString();
                dtgitens.Rows[n].Cells[3].Value = item["modelo"].ToString();
                dtgitens.Rows[n].Cells[4].Value = item["quantidade"].ToString();
                dtgitens.Rows[n].Cells[5].Value = item["valorDeVenda"].ToString();
                dtgitens.Rows[n].Cells[6].Value = item["totalUnitario"].ToString();




            }
        }

        public void listarProdutosRelacionadosAVendaTotal()
        {
            System.Data.DataTable dtr = new System.Data.DataTable();


            dtr = relCtr.listarProdutosRelacionadosAVendaTotal();

            dtgitens.Rows.Clear();


            foreach (DataRow item in dtr.Rows)
            {

                int n = dtgitens.Rows.Add();

                dtgitens.Rows[n].Cells[0].Value = item["codVendaRealizada"].ToString();
                dtgitens.Rows[n].Cells[1].Value = item["nomeProduto"].ToString();
                dtgitens.Rows[n].Cells[2].Value = item["tipoProduto"].ToString();
                dtgitens.Rows[n].Cells[3].Value = item["modelo"].ToString();
                dtgitens.Rows[n].Cells[4].Value = item["quantidade"].ToString();
                dtgitens.Rows[n].Cells[5].Value = item["valorDeVenda"].ToString();
                dtgitens.Rows[n].Cells[6].Value = item["totalUnitario"].ToString();




            }
        }

        

        public void totalFiltrado()
        {
            String valorCompraTexto;
           

            float valorCompra;
         

            float total = 0;
            String totalExibir;
            char[] MyChar = { 'R', '$' };

            List<ProdutoCompra> Produtos = new List<ProdutoCompra>();


            foreach (DataGridViewRow dataGridViewRow in dtgvendas.Rows) // FOREACH PARA PERCORRER O SEU DATAGRID
            {
                Produtos.Add(
                    new ProdutoCompra(dataGridViewRow.Cells["totfinal"].Value.ToString()
                                
                                  )
                             );

            }

            foreach (var p in Produtos) // FOREACH PARA PERCORRE A ESTRUTURA DE ARRAY PRODUTOCOMPRA AONDE ESTÁ ARMAZENADOS OS DADOS DO GRID PREENCHIDOS PELO FOREACH DE CIMA
            {
                valorCompraTexto = p.valorDCompra;
                

                string vtext = valorCompraTexto.TrimStart(MyChar);

                valorCompra = float.Parse(vtext);

                total = total + valorCompra;
               

                


            }


            totalExibir = string.Format("{0:C}", total);
            lbllucrofiltro.Text = totalExibir.ToString();

        }

        public struct ProdutoCompra
        {
            public String valorDCompra;


            public ProdutoCompra(String _valorCompra)
            {
                valorDCompra = _valorCompra;
             
            }
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

        public void contarOperacao()
        {
            String opera = relCtr.contarOperacao();
          
          

            if (relCtr.tem)
            {
                this.op1 = Convert.ToInt32(opera);




                this.tott = op1;

            }

           lblopera.Text = tott.ToString();
           

        }

        public void contarVendas()
        {

            String opera = relCtr.contarVendas();



            if (relCtr.tem)
            {
                this.op1 = Convert.ToInt32(opera);




                this.tott = op1;

            }

            lblvendas.Text = tott.ToString();
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
            listarVendas();
            listarProdutosRelacionadosAVendaTotal();
        }



      

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
                      

                        Range columnFornecedor = XcelApp.Cells[1, "D"];
                        Range columnTipo = XcelApp.Cells[1, "E"];
                        Range columnModelo = XcelApp.Cells[1, "F"];
                        Range columnQuantidade = XcelApp.Cells[1, "G"];
                        Range columnValordeCompra = XcelApp.Cells[1, "H"];





                        columnFornecedor.Interior.Color = Color.FromArgb(0, 209, 178);
                        columnTipo.Interior.Color = Color.FromArgb(0, 209, 178);
                        columnModelo.Interior.Color = Color.FromArgb(0, 209, 178);
                        columnQuantidade.Interior.Color = Color.FromArgb(0, 209, 178);
                        columnValordeCompra.Interior.Color = Color.FromArgb(0, 209, 178);



                        XcelApp.Cells[1, i + 2] = dtgvendas.Columns[i - 1].HeaderText;
                        rg = rg + 1;

                    }

                    for (int i = 1; i < dtgitens.Columns.Count + 1; i++)
                    {

                      
                        Range columnTipe = XcelApp.Cells[1, "K"];
                        Range columnTipo = XcelApp.Cells[1, "L"];
                        Range columnModelo = XcelApp.Cells[1, "M"];
                        Range columnQuantidade = XcelApp.Cells[1, "N"];
                        Range columnValordeCompra = XcelApp.Cells[1, "O"];
                        Range columnValordeVenda = XcelApp.Cells[1, "P"];
                        Range columnValordeVenda2 = XcelApp.Cells[1, "Q"];





                       
                        columnTipe.Interior.Color = Color.FromArgb(0, 209, 178);
                        columnTipo.Interior.Color = Color.FromArgb(0, 209, 178);
                        columnModelo.Interior.Color = Color.FromArgb(0, 209, 178);
                        columnQuantidade.Interior.Color = Color.FromArgb(0, 209, 178);
                        columnValordeCompra.Interior.Color = Color.FromArgb(0, 209, 178);
                        columnValordeVenda.Interior.Color = Color.FromArgb(0, 209, 178);
                        columnValordeVenda2.Interior.Color = Color.FromArgb(0, 209, 178);



                        XcelApp.Cells[1, i + 10] = dtgitens.Columns[i - 1].HeaderText;
                        rg = rg + 1;

                    }





                    //
                    for (int i = 0; i < dtgvendas.Rows.Count; i++)
                    {

                       

                        string countlinhas = "";
                        countlinhas = dtgitens.Rows.Count.ToString();
                        int countlinhass = Convert.ToInt32(countlinhas);
                        int ctd = i + 1;



                        for (int j = 1; j < dtgvendas.Columns.Count; j++)
                        {
                              XcelApp.Cells[i + 2, j + 3] = dtgvendas.Rows[i].Cells[j].Value.ToString();  
                        }

                    }

                    for (int j2 = 0; j2 < dtgitens.Rows.Count; j2++)
                    {

                        for (int i2 = 0; i2 < dtgitens.Columns.Count; i2++)
                        {
                            XcelApp.Cells[j2 + 2, i2 + 11] = dtgitens.Rows[j2].Cells[i2].Value.ToString();
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
            timer1.Start();
            formataGrid();
            listarVendas();
            listarProdutosRelacionadosAVendaTotal();
            contarOperacao();
            contarTotal();
            contarVendas();
            totalFiltrado();
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

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            listarVendas();
            listarProdutosRelacionadosAVendaTotal();
            totalFiltrado();
            contarOperacao();
            contarVendas();
            contarTotal();
            timer1.Start();
        }

        private void btnfiltroSemana_MouseEnter(object sender, EventArgs e)
        {
            btnfiltroSemana.Size = new Size(68, 40);
        }

        private void btnfiltroSemana_MouseLeave(object sender, EventArgs e)
        {
            btnfiltroSemana.Size = new Size(62, 35);
        }

        private void btnfiltroMes_MouseEnter(object sender, EventArgs e)
        {
            btnfiltroMes.Size = new Size(68, 40);
        }

        private void btnfiltroMes_MouseLeave(object sender, EventArgs e)
        {
            btnfiltroMes.Size = new Size(62, 35);
        }

        private void btnfiltrarAno_MouseEnter(object sender, EventArgs e)
        {
            btnfiltrarAno.Size = new Size(68, 40);
        }

        private void btnfiltrarAno_MouseLeave(object sender, EventArgs e)
        {
            btnfiltrarAno.Size = new Size(62, 35);
        }

        private void btnfiltrarPersonalizado_MouseEnter(object sender, EventArgs e)
        {
            btnfiltrarPersonalizado.Size = new Size(68, 40);
        }

        private void btnfiltrarPersonalizado_MouseLeave(object sender, EventArgs e)
        {
            btnfiltrarPersonalizado.Size = new Size(62, 35);
        }

        private void btnfiltroSemana_Click(object sender, EventArgs e)
        {
            filtrarSemana();
           
        }

        private void btnfiltroMes_Click(object sender, EventArgs e)
        {
            filtrarMes();
        }

        private void btnfiltrarAno_Click(object sender, EventArgs e)
        {
            filtrarAno();
        }

        private void btnexportarExcel_MouseEnter(object sender, EventArgs e)
        {
            btnexportarExcel.Size = new Size(77, 47);
        }

        private void btnexportarExcel_MouseLeave(object sender, EventArgs e)
        {
            btnexportarExcel.Size = new Size(74, 40);
        }

        private void btnexportarPdf_MouseEnter(object sender, EventArgs e)
        {
            btnexportarPdf.Size = new Size(77, 47);
        }

        private void btnexportarPdf_MouseLeave(object sender, EventArgs e)
        {
            btnexportarPdf.Size = new Size(74, 40);
        }

        private void btnfiltrarPersonalizado_Click(object sender, EventArgs e)
        {

            pnfiltro.Location = new System.Drawing.Point(250, 92);
            pnfiltro.Visible = true;
            txtdataInicial.Visible = true;
            txtdataFinal.Visible = true;
            label9.Visible = true;
            label2.Visible = true;
            pnvar.Visible = true;
            btnfecharPanel.Visible = true;
            btnfiltrar.Visible = true;
        }

        private void btnfecharPanel_Click(object sender, EventArgs e)
        {
            pnfiltro.Visible = false;
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            txtdataInicial.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtdataFinal.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtdataInicial.Text != string.Empty || txtdataFinal.Text != string.Empty || txtdataInicial.Text == "  /  /    " || txtdataFinal.Text == "  /  /    ")
            {
                txtdataInicial.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                txtdataFinal.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                filtrarData();

                txtdataInicial.Text = string.Empty;
                txtdataFinal.Text = string.Empty;
                pnfiltro.Visible = false;
            }
            else
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS", "PREENCHER", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void filtrarData()
        {
            string dataInicial = txtdataInicial.Text;
            string dataFinal = txtdataFinal.Text;
            System.Data.DataTable dtmf = new System.Data.DataTable();

            dtmf = relCtr.filtrarData(dataInicial, dataFinal);

            dtgvendas.Rows.Clear();

            foreach (DataRow item in dtmf.Rows)
            {
                int n = dtgvendas.Rows.Add();

                dtgvendas.Rows[n].Cells[1].Value = item["codVendaRealizada"].ToString();
                dtgvendas.Rows[n].Cells[2].Value = item["metodoPagamento"].ToString();
                dtgvendas.Rows[n].Cells[3].Value = item["desconto"].ToString();
                dtgvendas.Rows[n].Cells[4].Value = item["totalFinal"].ToString();
                dtgvendas.Rows[n].Cells[5].Value = item["dataVenda"].ToString();

            }

        }
    }
}
