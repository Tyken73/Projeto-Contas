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
    public partial class frmRelReceber : Form
    {
        public frmRelReceber()
        {
            InitializeComponent();
        }

        private void FrmRelReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tb_contas_receber'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contas_receberTableAdapter.Fill(this.bdCadastroDataSet.tb_contas_receber);

            this.reportViewer1.RefreshReport();
        }
    }
}
