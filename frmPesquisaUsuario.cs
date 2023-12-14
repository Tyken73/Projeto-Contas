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
    public partial class frmPesquisaUsuario : Form
    {
        private int codigo;

        public int getCodigo()
        {
            return codigo;
        }

        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void FrmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.bdCadastroDataSet.tb_usuario);

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void Tb_usuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tb_usuarioDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_usuarioTableAdapter.Fill(this.bdCadastroDataSet.tb_usuario);
            }
            else
            {
                this.tb_usuarioTableAdapter.FillByNome(this.bdCadastroDataSet.tb_usuario, "%"+txtNome.Text+"%");
            }
        }
    }
}
