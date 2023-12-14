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
    public partial class frmRelUsuario : Form
    {
        public frmRelUsuario()
        {
            InitializeComponent();
        }

        private void FrmRelUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.bdCadastroDataSet.tb_usuario);

            this.reportViewer1.RefreshReport();
        }
    }
}
