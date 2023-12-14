using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clienteTableAdapter.Fill(this.bdCadastroDataSet.tb_cliente);
            Desabilita();
        }

        private void Habilita()
        {
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
            cd_cpfTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
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
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
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
            tb_clienteBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.MoveNext();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Habilita();
            tb_clienteBindingSource.AddNew();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.RemoveCurrent();
            tb_clienteTableAdapter.Update(bdCadastroDataSet.tb_cliente);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tb_clienteBindingSource.EndEdit();
            tb_clienteTableAdapter.Update(bdCadastroDataSet.tb_cliente);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            tb_clienteBindingSource.CancelEdit();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaCliente fpc = new frmPesquisaCliente();
            fpc.ShowDialog();
            int cod = fpc.getCodigo();
            if (cod > 0)
            {
                int registro = tb_clienteBindingSource.Find("cd_cliente", cod);
                tb_clienteBindingSource.Position = registro;
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "Ficha de cliente" + (char)10 + (char)10 +
            "Código: " + cd_clienteTextBox.Text + (char)10 + (char)10 +
            "Nome: " + nm_clienteTextBox.Text + (char)10 + (char)10 +
            "Endereço: " + ds_enderecoTextBox.Text + (char)10 + (char)10 +
            "Bairro: " + nm_bairroTextBox.Text + (char)10 + (char)10 +
            "Cidade: " + nm_cidadeTextBox.Text + (char)10 + (char)10 +
            "Estado: " + sg_estadoTextBox.Text + (char)10 + (char)10 +
            "CEP: " + cd_cepMaskedTextBox.Text + (char)10 + (char)10 +
            "CPF: " + cd_cpfTextBox.Text + (char)10 + (char)10 +
            "RG: " + cd_rgTextBox.Text + (char)10 + (char)10;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 100);
            objImpressao.DrawLine(new Pen(Brushes.Black, 1), 100, 125, 725, 125);
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
