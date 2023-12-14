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
    public partial class frmPesquisaCliente : Form
    {
        private int codigo;

        public int getCodigo()
        {
            return codigo;
        }

        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        private void FrmPesquisaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clienteTableAdapter.Fill(this.bdCadastroDataSet.tb_cliente);

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void Tb_clienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tb_clienteDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_clienteTableAdapter.Fill(this.bdCadastroDataSet.tb_cliente);
            }
            else
            {
                this.tb_clienteTableAdapter.FillByNome(this.bdCadastroDataSet.tb_cliente, "%" + txtNome.Text + "%");
            }
        }
    }
}
