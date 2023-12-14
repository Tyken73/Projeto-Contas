using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.bdCadastroDataSetTableAdapters;

namespace WindowsFormsApp2
{
    public partial class frmPagar : Form
    {
        public frmPagar()
        {
            InitializeComponent();
        }

        private void frmPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tb_contas_pagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contas_pagarTableAdapter.Fill(this.bdCadastroDataSet.tb_contas_pagar);
            Desabilita();
        }

        private void Habilita()
        {
            cd_contas_pagarTextBox.Enabled = false;
            ds_contaTextBox.Enabled = true;
            dt_emissaoDateTimePicker.Enabled = true;
            dt_pagamentoDateTimePicker.Enabled = true;
            dt_vencimentoDateTimePicker.Enabled = true;
            vl_contaTextBox.Enabled = true;
            vl_pagoTextBox.Enabled = true;
            cd_fornecedorTextBox.Enabled = false;
            BtnAnterior.Enabled = false;
            BtnProximo.Enabled = false;
            BtnNovo.Enabled = false;
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnSalvar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnPesquisar.Enabled = false;
            BtnImprimir.Enabled = false;
            BtnSair.Enabled = false;
        }

        private void Desabilita()
        {
            cd_contas_pagarTextBox.Enabled = false;
            ds_contaTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = false;
            cd_fornecedorTextBox.Enabled = false;
            dt_pagamentoDateTimePicker.Enabled = false;
            dt_vencimentoDateTimePicker.Enabled = false;
            vl_contaTextBox.Enabled = false;
            vl_pagoTextBox.Enabled = false;
            cd_fornecedorTextBox.Enabled = false;
            BtnAnterior.Enabled = true;
            BtnProximo.Enabled = true;
            BtnNovo.Enabled = true;
            BtnAlterar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnSalvar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnPesquisar.Enabled = true;
            BtnImprimir.Enabled = true;
            BtnSair.Enabled = true;
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tb_contas_pagarBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tb_contas_pagarBindingSource.MoveNext();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Habilita();
            tb_contas_pagarBindingSource.AddNew();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tb_contas_pagarBindingSource.RemoveCurrent();
            tb_contas_pagarTableAdapter.Update(bdCadastroDataSet.tb_contas_pagar);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tb_contas_pagarBindingSource.EndEdit();
            tb_contas_pagarTableAdapter.Update(bdCadastroDataSet.tb_contas_pagar);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            tb_contas_pagarBindingSource.CancelEdit();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "Ficha de usuário" + (char)10 + (char)10 +
            "Código: " + cd_contas_pagarTextBox.Text + (char)10 + (char)10 +
            "Descrição: " + ds_contaTextBox.Text + (char)10 + (char)10 +
            "Emissão: " + dt_emissaoDateTimePicker.Text + (char)10 + (char)10 +
            "Valor: " + vl_contaTextBox.Text + (char)10 + (char)10 +
            "Vencimento: " + dt_vencimentoDateTimePicker.Text + (char)10 + (char)10 +
            "Pagamento: " + dt_pagamentoDateTimePicker.Text + (char)10 + (char)10 +
            "Valor pago: " + vl_pagoTextBox.Text + (char)10 + (char)10 +
            "Código do fornecedor: " + cd_fornecedorTextBox.Text + (char)10 + (char)10;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 100);
            objImpressao.DrawLine(new Pen(Brushes.Black, 1), 100, 125, 725, 125);
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
