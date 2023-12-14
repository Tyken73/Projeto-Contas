namespace WindowsFormsApp2
{
    partial class frmPesquisaUsuario
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
            this.nome = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.bdCadastroDataSet = new WindowsFormsApp2.bdCadastroDataSet();
            this.tb_usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_usuarioTableAdapter = new WindowsFormsApp2.bdCadastroDataSetTableAdapters.tb_usuarioTableAdapter();
            this.tb_usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(41, 53);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(35, 13);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome";
            // 
            // BtnSair
            // 
            this.BtnSair.AutoSize = true;
            this.BtnSair.Location = new System.Drawing.Point(367, 384);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(96, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(669, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // bdCadastroDataSet
            // 
            this.bdCadastroDataSet.DataSetName = "bdCadastroDataSet";
            this.bdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_usuarioBindingSource
            // 
            this.tb_usuarioBindingSource.DataMember = "tb_usuario";
            this.tb_usuarioBindingSource.DataSource = this.bdCadastroDataSet;
            // 
            // tb_usuarioTableAdapter
            // 
            this.tb_usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tb_usuarioDataGridView
            // 
            this.tb_usuarioDataGridView.AllowUserToAddRows = false;
            this.tb_usuarioDataGridView.AllowUserToDeleteRows = false;
            this.tb_usuarioDataGridView.AutoGenerateColumns = false;
            this.tb_usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tb_usuarioDataGridView.DataSource = this.tb_usuarioBindingSource;
            this.tb_usuarioDataGridView.Location = new System.Drawing.Point(44, 117);
            this.tb_usuarioDataGridView.Name = "tb_usuarioDataGridView";
            this.tb_usuarioDataGridView.ReadOnly = true;
            this.tb_usuarioDataGridView.Size = new System.Drawing.Size(721, 220);
            this.tb_usuarioDataGridView.TabIndex = 5;
            this.tb_usuarioDataGridView.DoubleClick += new System.EventHandler(this.Tb_usuarioDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_usuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_usuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 550;
            // 
            // frmPesquisaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tb_usuarioDataGridView);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPesquisaUsuario";
            this.Text = "Pesquisa de usuário";
            this.Load += new System.EventHandler(this.FrmPesquisaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox txtNome;
        private bdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tb_usuarioBindingSource;
        private bdCadastroDataSetTableAdapters.tb_usuarioTableAdapter tb_usuarioTableAdapter;
        private System.Windows.Forms.DataGridView tb_usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}