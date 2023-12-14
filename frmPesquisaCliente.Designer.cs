namespace WindowsFormsApp2
{
    partial class frmPesquisaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bdCadastroDataSet = new WindowsFormsApp2.bdCadastroDataSet();
            this.tb_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_clienteTableAdapter = new WindowsFormsApp2.bdCadastroDataSetTableAdapters.tb_clienteTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.bdCadastroDataSetTableAdapters.TableAdapterManager();
            this.tb_clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bdCadastroDataSet
            // 
            this.bdCadastroDataSet.DataSetName = "bdCadastroDataSet";
            this.bdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_clienteBindingSource
            // 
            this.tb_clienteBindingSource.DataMember = "tb_cliente";
            this.tb_clienteBindingSource.DataSource = this.bdCadastroDataSet;
            // 
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = this.tb_clienteTableAdapter;
            this.tableAdapterManager.tb_contas_pagarTableAdapter = null;
            this.tableAdapterManager.tb_contas_receberTableAdapter = null;
            this.tableAdapterManager.tb_fornecedorTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.bdCadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_clienteDataGridView
            // 
            this.tb_clienteDataGridView.AllowUserToAddRows = false;
            this.tb_clienteDataGridView.AllowUserToDeleteRows = false;
            this.tb_clienteDataGridView.AutoGenerateColumns = false;
            this.tb_clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tb_clienteDataGridView.DataSource = this.tb_clienteBindingSource;
            this.tb_clienteDataGridView.Location = new System.Drawing.Point(44, 117);
            this.tb_clienteDataGridView.Name = "tb_clienteDataGridView";
            this.tb_clienteDataGridView.ReadOnly = true;
            this.tb_clienteDataGridView.Size = new System.Drawing.Size(721, 220);
            this.tb_clienteDataGridView.TabIndex = 1;
            this.tb_clienteDataGridView.DoubleClick += new System.EventHandler(this.Tb_clienteDataGridView_DoubleClick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(96, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(669, 20);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(41, 53);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(35, 13);
            this.nome.TabIndex = 6;
            this.nome.Text = "Nome";
            // 
            // BtnSair
            // 
            this.BtnSair.AutoSize = true;
            this.BtnSair.Location = new System.Drawing.Point(367, 384);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_cliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 550;
            // 
            // frmPesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.tb_clienteDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPesquisaCliente";
            this.Text = "Pesquisa de cliente";
            this.Load += new System.EventHandler(this.FrmPesquisaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tb_clienteBindingSource;
        private bdCadastroDataSetTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
        private bdCadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tb_clienteDataGridView;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button BtnSair;
    }
}