﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TCC.MODELS.relatorio_modelo;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Collections.Generic;
using TCC.VISIONS.relatorio_visao;
using Application = System.Windows.Forms.Application;
using System.Linq;
using static TCC.VISIONS.relatorio_visao.FiltroRelatorioEstoque;

namespace TCC.VISÃO
{
    public partial class RelatorioEstoque : Form
    {
        #region VARIÁVEIS E INSTÂNCIAS


        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
        String contaEntrada;
        relatorioEstoqueControle relCtr = new relatorioEstoqueControle();
        String quantidadeProduto;
        String dispesas;
        int op1 = 0;
        int op2 = 0;
        int op3 = 0;
        int tot = 0;

        #endregion






        #region CONSTRUTOR
        public RelatorioEstoque()
        {
            InitializeComponent();
        }
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES



       



        public void contarEntradas()
        {
            contaEntrada = relCtr.contarEntradas();
            lbl1.Text = contaEntrada;
        }

        public void contarProdutos()
        {
            quantidadeProduto = relCtr.contarProdutos();
            lbl3.Text = quantidadeProduto;
        }


        public void listarProduto()
        {
            DataTable dtr = new DataTable();



            dtr = relCtr.listarProdutos();

            dtgestoque.Rows.Clear();


            foreach (DataRow item in dtr.Rows)
            {

                int n = dtgestoque.Rows.Add();

                dtgestoque.Rows[n].Cells[0].Value = item["nome"].ToString();
                dtgestoque.Rows[n].Cells[1].Value = item["fornecedor"].ToString();
                dtgestoque.Rows[n].Cells[2].Value = item["tipo"].ToString();
                dtgestoque.Rows[n].Cells[3].Value = item["modelo"].ToString();
                dtgestoque.Rows[n].Cells[4].Value = item["quantidade"].ToString();
                dtgestoque.Rows[n].Cells[5].Value = item["valordecompra"].ToString();
                dtgestoque.Rows[n].Cells[6].Value = item["valordevenda"].ToString();
                dtgestoque.Rows[n].Cells[7].Value = item["dataDeCadastro"].ToString();



            }

        }

        public void formataGrid()
        {
            // TODO: esta linha de código carrega dados na tabela 'tccDataSet.logs'. Você pode movê-la ou removê-la conforme necessário.
            //this.logsTableAdapter.Fill(this.tccDataSet.logs);
            dtgestoque.BorderStyle = BorderStyle.None;  //DTEMAIL NOME DA VARIÁVEL
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgestoque.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            // dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            /// dataGridView1.BackgroundColor = Color.White;

            dtgestoque.EnableHeadersVisualStyles = false;
            dtgestoque.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgestoque.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 209, 178);     //FromArgb(20, 25, 72);
            dtgestoque.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public void dispesasGrid()
        {
            String valorCompraTexto;
            String quantidadeTexto;

            float valorCompra;
            float quantidade;

            float total = 0;
            String totalExibir;
            char[] MyChar = { 'R', '$' };

            List<ProdutoCompra> Produtos = new List<ProdutoCompra>();


            foreach (DataGridViewRow dataGridViewRow in dtgestoque.Rows) // FOREACH PARA PERCORRER O SEU DATAGRID
            {
                Produtos.Add(
                    new ProdutoCompra(dataGridViewRow.Cells["valordeCompra"].Value.ToString(),
                                dataGridViewRow.Cells["quantidade"].Value.ToString()
                                  )
                             );

            }

            foreach (var p in Produtos) // FOREACH PARA PERCORRE A ESTRUTURA DE ARRAY PRODUTOCOMPRA AONDE ESTÁ ARMAZENADOS OS DADOS DO GRID PREENCHIDOS PELO FOREACH DE CIMA
            {
                valorCompraTexto = p.valorDCompra;
                quantidadeTexto = p.quantidade;

                string vtext = valorCompraTexto.TrimStart(MyChar);

                valorCompra = float.Parse(vtext);
                quantidade = float.Parse(quantidadeTexto);

                total = total + (quantidade * valorCompra);


            }


            totalExibir = string.Format("{0:C}", total);
            lbl4.Text = totalExibir.ToString();


        }

        public struct ProdutoCompra
        {
            public String valorDCompra, quantidade;


            public ProdutoCompra(String _valorCompra, String _quantidade)
            {
                valorDCompra = _valorCompra;
                quantidade = _quantidade;
            }
        }

        public void contarOperacao()
        {
            String opera = relCtr.contarOperacao();
            String opera2 = relCtr.contarOperacao2();
            String opera3 = relCtr.contarOperacao3();

            if (relCtr.tem)
            {
                this.op1 = Convert.ToInt32(opera);
                this.op2 = Convert.ToInt32(opera2);
                this.op3 = Convert.ToInt32(opera3);

                this.tot = (op1 + op2) + op3 ;

            }

            lbl5.Text = tot.ToString();

        }
        

        public void filtrarSemana()
        {
            DataTable dtd = new DataTable();

            dtd = relCtr.filtrarSemana();

            dtgestoque.Rows.Clear();

            foreach (DataRow item in dtd.Rows)
            {
                int n = dtgestoque.Rows.Add();

                dtgestoque.Rows[n].Cells[0].Value = item["nome"].ToString();
                dtgestoque.Rows[n].Cells[1].Value = item["fornecedor"].ToString();
                dtgestoque.Rows[n].Cells[2].Value = item["tipo"].ToString();
                dtgestoque.Rows[n].Cells[3].Value = item["modelo"].ToString();
                dtgestoque.Rows[n].Cells[4].Value = item["quantidade"].ToString();
                dtgestoque.Rows[n].Cells[5].Value = item["valordecompra"].ToString();
                dtgestoque.Rows[n].Cells[6].Value = item["valordevenda"].ToString();
                dtgestoque.Rows[n].Cells[7].Value = item["dataDeCadastro"].ToString();

            }


        }

        public void filtrarMes()
        {
            DataTable dtdm = new DataTable();

            dtdm = relCtr.filtrarMes();

            dtgestoque.Rows.Clear();

            foreach (DataRow item in dtdm. Rows)
            {
                int n = dtgestoque.Rows.Add();

                dtgestoque.Rows[n].Cells[0].Value = item["nome"].ToString();
                dtgestoque.Rows[n].Cells[1].Value = item["fornecedor"].ToString();
                dtgestoque.Rows[n].Cells[2].Value = item["tipo"].ToString();
                dtgestoque.Rows[n].Cells[3].Value = item["modelo"].ToString();
                dtgestoque.Rows[n].Cells[4].Value = item["quantidade"].ToString();
                dtgestoque.Rows[n].Cells[5].Value = item["valordecompra"].ToString();
                dtgestoque.Rows[n].Cells[6].Value = item["valordevenda"].ToString();
                dtgestoque.Rows[n].Cells[7].Value = item["dataDeCadastro"].ToString();

            }



        }


        public void filtrarAno()
        {
            DataTable dtaa = new DataTable();

            dtaa = relCtr.filtrarAno();

            dtgestoque.Rows.Clear();

            foreach (DataRow item in dtaa.Rows)
            {
                int n = dtgestoque.Rows.Add();

                dtgestoque.Rows[n].Cells[0].Value = item["nome"].ToString();
                dtgestoque.Rows[n].Cells[1].Value = item["fornecedor"].ToString();
                dtgestoque.Rows[n].Cells[2].Value = item["tipo"].ToString();
                dtgestoque.Rows[n].Cells[3].Value = item["modelo"].ToString();
                dtgestoque.Rows[n].Cells[4].Value = item["quantidade"].ToString();
                dtgestoque.Rows[n].Cells[5].Value = item["valordecompra"].ToString();
                dtgestoque.Rows[n].Cells[6].Value = item["valordevenda"].ToString();
                dtgestoque.Rows[n].Cells[7].Value = item["dataDeCadastro"].ToString();

            }
        }


        #endregion






        #region DESIGN 

        private void RelatorioEstoque_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            formataGrid();
            listarProduto();
            dispesasGrid();
            contarEntradas();
            contarProdutos();
            contarOperacao();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listarProduto();
            dispesasGrid();
            contarEntradas();
            contarProdutos();
            contarOperacao();
            timer1.Start();
        }




        private void btnSair_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.OwnedForms) //FORMULÁRIOS FILHOS
            {
                child.Close();//FECHA FILHOS
            }
            this.Close(); ;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnfiltroSemana_Click(object sender, EventArgs e)
        {

            filtrarSemana();
            dispesasGrid();
        }

        private void btnfiltroSemana_MouseEnter(object sender, EventArgs e)
        {
            btnfiltroSemana.Size = new Size(68, 40);
        }

        private void btnfiltroSemana_MouseLeave_1(object sender, EventArgs e)
        {
            btnfiltroSemana.Size = new Size(62, 35);
        }

        private void btnfiltroMes_Click(object sender, EventArgs e)
        {
            filtrarMes();
            dispesasGrid();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            filtrarAno();
            dispesasGrid();
        }

        private void btnfiltroMes_MouseEnter(object sender, EventArgs e)
        {
            btnfiltroMes.Size = new Size(68, 40);
        }

        private void btnfiltroMes_MouseLeave(object sender, EventArgs e)
        {
            btnfiltroMes.Size = new Size(62, 35);
        }

        private void btn3_MouseEnter(object sender, EventArgs e)
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

        private void btnfiltrarPersonalizado_Click(object sender, EventArgs e)
        {
            FiltroRelatorioEstoque filEstoque = new FiltroRelatorioEstoque();

            if (Application.OpenForms.OfType<CadastroProduto>().Count() > 0)
            {
                Application.OpenForms.OfType<CadastroProduto>().First().Focus();
            }
            else
            {

                filEstoque.Owner = this;
                filEstoque.Show();
            }
        }

        private void btnexportarExcel_MouseLeave(object sender, EventArgs e)
        {
            btnexportarExcel.Size = new Size(74, 40);
        }

        private void btnexportarExcel_MouseEnter(object sender, EventArgs e)
        {
            btnexportarExcel.Size = new Size(77, 47);
        }

        private void btnexportarPdf_MouseLeave(object sender, EventArgs e)
        {
            btnexportarPdf.Size = new Size(74, 40);
        }

        private void btnexportarPdf_MouseEnter(object sender, EventArgs e)
        {
            btnexportarPdf.Size = new Size(77, 47);
        }

        #endregion



        private void btnexportarExcel_Click(object sender, EventArgs e)
        {
            if (dtgestoque.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dtgestoque.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dtgestoque.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dtgestoque.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dtgestoque.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dtgestoque.Rows[i].Cells[j].Value.ToString();
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
}
