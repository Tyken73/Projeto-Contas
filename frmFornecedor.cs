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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.bdCadastroDataSet.tb_fornecedor);
            Desabilita();
        }

        private void Habilita()
        {
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoComboBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
            cd_cnpjMaskedTextBox.Enabled = true;
            cd_ieMaskedTextBox.Enabled = true;
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
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoComboBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
            cd_cnpjMaskedTextBox.Enabled = false;
            cd_ieMaskedTextBox.Enabled = false;
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
            tb_fornecedorBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.MoveNext();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Habilita();
            tb_fornecedorBindingSource.AddNew();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.RemoveCurrent();
            tb_fornecedorTableAdapter.Update(bdCadastroDataSet.tb_fornecedor);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            double dig1 = 0, dig2 = 0;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(14, 1)) * 2;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(13, 1)) * 3;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(12, 1)) * 4;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(11, 1)) * 5;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(9, 1)) * 6;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(8, 1)) * 7;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(7, 1)) * 8;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(5, 1)) * 9;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(4, 1)) * 2;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(3, 1)) * 3;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(1, 1)) * 4;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(0, 1)) * 5;
            dig1 = dig1 % 11;
            if (dig1 < 2)
            {
                dig1 = 0;
            }
            else
            {
                dig1 = 11 - dig1;
            }

            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(16, 1)) * 2;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(14, 1)) * 3;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(13, 1)) * 4;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(12, 1)) * 5;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(11, 1)) * 6;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(9, 1)) * 7;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(8, 1)) * 8;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(7, 1)) * 9;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(5, 1)) * 2;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(4, 1)) * 3;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(3, 1)) * 4;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(1, 1)) * 5;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(0, 1)) * 6;
            dig2 = dig2 % 11;
            if (dig2 < 2)
            {
                dig2 = 0;
            }
            else
            {
                dig2 = 11 - dig2;
            }

            if (cd_cnpjMaskedTextBox.Text.Substring(16, 1) != dig1.ToString() ||
                cd_cnpjMaskedTextBox.Text.Substring(17, 1) != dig2.ToString())
            {
                MessageBox.Show("CNPJ inválido");
                cd_cnpjMaskedTextBox.Focus();
            }

            else
            {
                Desabilita();
                Validate();
                tb_fornecedorBindingSource.EndEdit();
                tb_fornecedorTableAdapter.Update(bdCadastroDataSet.tb_fornecedor);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            tb_fornecedorBindingSource.CancelEdit();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaFornecedor fpf = new frmPesquisaFornecedor();
            fpf.ShowDialog();
            int cod = fpf.getCodigo();
            if (cod > 0)
            {
                int registro = tb_fornecedorBindingSource.Find("cd_fornecedor", cod);
                tb_fornecedorBindingSource.Position = registro;
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "Ficha de usuário" + (char)10 + (char)10 +
            "Código: " + cd_fornecedorTextBox.Text + (char)10 + (char)10 +
            "Nome: " + nm_fornecedorTextBox.Text + (char)10 + (char)10 +
            "Endereço: " + ds_enderecoTextBox.Text + (char)10 + (char)10 +
            "Bairro: " + nm_bairroTextBox.Text + (char)10 + (char)10 +
            "Cidade: " + nm_cidadeTextBox.Text + (char)10 + (char)10 +
            "Estado: " + sg_estadoComboBox.Text + (char)10 + (char)10 +
            "CEP: " + cd_cepMaskedTextBox.Text + (char)10 + (char)10 +
            "CNPJ: " + cd_cnpjMaskedTextBox.Text + (char)10 + (char)10 +
            "IE: " + cd_ieMaskedTextBox.Text + (char)10 + (char)10;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 100);
            objImpressao.DrawLine(new Pen(Brushes.Black, 1), 100, 125, 725, 125);
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
