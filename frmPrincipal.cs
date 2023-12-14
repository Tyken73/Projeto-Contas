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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void UsuàriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fc = new frmCliente();
            fc.ShowDialog();
        }

        private void FornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor ff = new frmFornecedor();
            ff.ShowDialog();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagar fp = new frmPagar();
            fp.ShowDialog();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceber fr = new frmReceber();
            fr.ShowDialog();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UsuàriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelUsuario fru = new frmRelUsuario();
            fru.ShowDialog();
        }

        private void ClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelCliente frc = new frmRelCliente();
            frc.ShowDialog();
        }

        private void ContasAPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelPagar frp = new frmRelPagar();
            frp.ShowDialog();
        }

        private void FornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelFornecedor frf = new frmRelFornecedor();
            frf.ShowDialog();
        }

        private void ContasAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelFornecedor frf = new frmRelFornecedor();
            frf.ShowDialog();
        }
    }
}
