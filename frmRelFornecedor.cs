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
    public partial class frmRelFornecedor : Form
    {
        public frmRelFornecedor()
        {
            InitializeComponent();
        }

        private void FrmRelFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.bdCadastroDataSet.tb_fornecedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
