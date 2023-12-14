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
    public partial class frmRelPagar : Form
    {
        public frmRelPagar()
        {
            InitializeComponent();
        }

        private void FrmRelPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tb_contas_pagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contas_pagarTableAdapter.Fill(this.bdCadastroDataSet.tb_contas_pagar);

            this.reportViewer1.RefreshReport();
        }
    }
}
