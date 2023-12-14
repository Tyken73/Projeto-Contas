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
    public partial class frmPesquisaFornecedor : Form
    {
        private int codigo;

        public int getCodigo()
        {
            return codigo;
        }

        public frmPesquisaFornecedor()
        {
            InitializeComponent();
        }

        private void FrmPesquisaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.bdCadastroDataSet.tb_fornecedor);

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void Tb_fornecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tb_fornecedorDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_fornecedorTableAdapter.Fill(this.bdCadastroDataSet.tb_fornecedor);
            }
            else
            {
                this.tb_fornecedorTableAdapter.FillByNome(this.bdCadastroDataSet.tb_fornecedor, "%" + txtNome.Text + "%");
            }
        }
    }
}
