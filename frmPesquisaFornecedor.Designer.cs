namespace WindowsFormsApp2
{
    partial class frmPesquisaFornecedor
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
            this.BtnSair = new System.Windows.Forms.Button();
            this.tb_fornecedorDataGridView = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdCadastroDataSet = new WindowsFormsApp2.bdCadastroDataSet();
            this.tb_fornecedorTableAdapter = new WindowsFormsApp2.bdCadastroDataSetTableAdapters.tb_fornecedorTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.bdCadastroDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.AutoSize = true;
            this.BtnSair.Location = new System.Drawing.Point(367, 384);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 2;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // tb_fornecedorDataGridView
            // 
            this.tb_fornecedorDataGridView.AllowUserToAddRows = false;
            this.tb_fornecedorDataGridView.AllowUserToDeleteRows = false;
            this.tb_fornecedorDataGridView.AutoGenerateColumns = false;
            this.tb_fornecedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_fornecedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tb_fornecedorDataGridView.DataSource = this.tb_fornecedorBindingSource;
            this.tb_fornecedorDataGridView.Location = new System.Drawing.Point(44, 117);
            this.tb_fornecedorDataGridView.Name = "tb_fornecedorDataGridView";
            this.tb_fornecedorDataGridView.ReadOnly = true;
            this.tb_fornecedorDataGridView.Size = new System.Drawing.Size(721, 220);
            this.tb_fornecedorDataGridView.TabIndex = 3;
            this.tb_fornecedorDataGridView.DoubleClick += new System.EventHandler(this.Tb_fornecedorDataGridView_DoubleClick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(96, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(669, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(41, 53);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(35, 13);
            this.nome.TabIndex = 4;
            this.nome.Text = "Nome";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_fornecedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_fornecedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 550;
            // 
            // tb_fornecedorBindingSource
            // 
            this.tb_fornecedorBindingSource.DataMember = "tb_fornecedor";
            this.tb_fornecedorBindingSource.DataSource = this.bdCadastroDataSet;
            // 
            // bdCadastroDataSet
            // 
            this.bdCadastroDataSet.DataSetName = "bdCadastroDataSet";
            this.bdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_fornecedorTableAdapter
            // 
            this.tb_fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = null;
            this.tableAdapterManager.tb_contas_pagarTableAdapter = null;
            this.tableAdapterManager.tb_contas_receberTableAdapter = null;
            this.tableAdapterManager.tb_fornecedorTableAdapter = this.tb_fornecedorTableAdapter;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.bdCadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmPesquisaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.tb_fornecedorDataGridView);
            this.Controls.Add(this.BtnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPesquisaFornecedor";
            this.Text = "Pesquisa de fornecedor";
            this.Load += new System.EventHandler(this.FrmPesquisaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private bdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tb_fornecedorBindingSource;
        private bdCadastroDataSetTableAdapters.tb_fornecedorTableAdapter tb_fornecedorTableAdapter;
        private bdCadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tb_fornecedorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label nome;
    }
}