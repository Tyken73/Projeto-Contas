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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        /*private void Tb_usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdCadastroDataSet);
        }*/

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.bdCadastroDataSet.tb_usuario);
            Desabilita();
        }

        private void Habilita()
        {
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            cd_senhaTextBox.Enabled = true;
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
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            cd_senhaTextBox.Enabled = false;
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

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MoveNext();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Habilita();
            tb_usuarioBindingSource.AddNew();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.RemoveCurrent();
            tb_usuarioTableAdapter.Update(bdCadastroDataSet.tb_usuario);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tb_usuarioBindingSource.EndEdit();
            tb_usuarioTableAdapter.Update(bdCadastroDataSet.tb_usuario);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            tb_usuarioBindingSource.CancelEdit();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaUsuario fpu = new frmPesquisaUsuario();
            fpu.ShowDialog();
            int cod = fpu.getCodigo();
            if (cod > 0)
            {
                int registro = tb_usuarioBindingSource.Find("cd_usuario", cod);
                tb_usuarioBindingSource.Position = registro;
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "Ficha de usuário" + (char)10 + (char)10 +
            "Código: "+cd_usuarioTextBox.Text + (char)10 + (char)10 +
            "Nome: "+nm_usuarioTextBox.Text + (char)10 + (char)10 +
            "Nível: "+sg_nivelTextBox.Text + (char)10 + (char)10 +
            "Login: "+nm_loginTextBox.Text + (char)10 + (char)10;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 100);
            objImpressao.DrawLine(new Pen(Brushes.Black, 1), 100, 125, 725, 125);
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}