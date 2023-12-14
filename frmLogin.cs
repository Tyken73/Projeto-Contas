using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            frmSplashScreen frmSplashScreen = new frmSplashScreen();
            frmSplashScreen.Show();
            Thread.Sleep(3000);
            frmSplashScreen.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.bdCadastroDataSet.tb_usuario);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tb_usuarioTableAdapter.FillLogin(bdCadastroDataSet.tb_usuario, txtLogin.Text, txtSenha.Text);
            if (tb_usuarioBindingSource.Count > 0 || (txtLogin.Text == "adm" && txtSenha.Text == "1234"))
            {
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtLogin.Focus();
                frmPrincipal fp = new frmPrincipal();
                this.Hide();
                fp.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha inválido");
                txtLogin.Focus();
            }
        }
    }
}
