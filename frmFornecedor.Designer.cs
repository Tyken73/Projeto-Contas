namespace WindowsFormsApp2
{
    partial class frmFornecedor
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
            System.Windows.Forms.Label cd_fornecedorLabel;
            System.Windows.Forms.Label nm_fornecedorLabel;
            System.Windows.Forms.Label ds_enderecoLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_cnpjLabel;
            System.Windows.Forms.Label cd_ieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedor));
            this.bdCadastroDataSet = new WindowsFormsApp2.bdCadastroDataSet();
            this.tb_fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_fornecedorTableAdapter = new WindowsFormsApp2.bdCadastroDataSetTableAdapters.tb_fornecedorTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.bdCadastroDataSetTableAdapters.TableAdapterManager();
            this.cd_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nm_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.ds_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.sg_estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cd_cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_cnpjMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_ieMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            cd_fornecedorLabel = new System.Windows.Forms.Label();
            nm_fornecedorLabel = new System.Windows.Forms.Label();
            ds_enderecoLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_cnpjLabel = new System.Windows.Forms.Label();
            cd_ieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_fornecedorLabel
            // 
            cd_fornecedorLabel.AutoSize = true;
            cd_fornecedorLabel.Location = new System.Drawing.Point(44, 37);
            cd_fornecedorLabel.Name = "cd_fornecedorLabel";
            cd_fornecedorLabel.Size = new System.Drawing.Size(40, 13);
            cd_fornecedorLabel.TabIndex = 1;
            cd_fornecedorLabel.Text = "Código";
            // 
            // nm_fornecedorLabel
            // 
            nm_fornecedorLabel.AutoSize = true;
            nm_fornecedorLabel.Location = new System.Drawing.Point(44, 63);
            nm_fornecedorLabel.Name = "nm_fornecedorLabel";
            nm_fornecedorLabel.Size = new System.Drawing.Size(35, 13);
            nm_fornecedorLabel.TabIndex = 3;
            nm_fornecedorLabel.Text = "Nome";
            // 
            // ds_enderecoLabel
            // 
            ds_enderecoLabel.AutoSize = true;
            ds_enderecoLabel.Location = new System.Drawing.Point(44, 89);
            ds_enderecoLabel.Name = "ds_enderecoLabel";
            ds_enderecoLabel.Size = new System.Drawing.Size(53, 13);
            ds_enderecoLabel.TabIndex = 5;
            ds_enderecoLabel.Text = "Endereço";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Location = new System.Drawing.Point(44, 115);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(34, 13);
            nm_bairroLabel.TabIndex = 7;
            nm_bairroLabel.Text = "Bairro";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Location = new System.Drawing.Point(44, 141);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(40, 13);
            nm_cidadeLabel.TabIndex = 9;
            nm_cidadeLabel.Text = "Cidade";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Location = new System.Drawing.Point(44, 167);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(40, 13);
            sg_estadoLabel.TabIndex = 11;
            sg_estadoLabel.Text = "Estado";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Location = new System.Drawing.Point(44, 193);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(28, 13);
            cd_cepLabel.TabIndex = 13;
            cd_cepLabel.Text = "CEP";
            // 
            // cd_cnpjLabel
            // 
            cd_cnpjLabel.AutoSize = true;
            cd_cnpjLabel.Location = new System.Drawing.Point(44, 218);
            cd_cnpjLabel.Name = "cd_cnpjLabel";
            cd_cnpjLabel.Size = new System.Drawing.Size(34, 13);
            cd_cnpjLabel.TabIndex = 15;
            cd_cnpjLabel.Text = "CNPJ";
            // 
            // cd_ieLabel
            // 
            cd_ieLabel.AutoSize = true;
            cd_ieLabel.Location = new System.Drawing.Point(44, 243);
            cd_ieLabel.Name = "cd_ieLabel";
            cd_ieLabel.Size = new System.Drawing.Size(17, 13);
            cd_ieLabel.TabIndex = 17;
            cd_ieLabel.Text = "IE";
            // 
            // bdCadastroDataSet
            // 
            this.bdCadastroDataSet.DataSetName = "bdCadastroDataSet";
            this.bdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_fornecedorBindingSource
            // 
            this.tb_fornecedorBindingSource.DataMember = "tb_fornecedor";
            this.tb_fornecedorBindingSource.DataSource = this.bdCadastroDataSet;
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
            // cd_fornecedorTextBox
            // 
            this.cd_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_fornecedor", true));
            this.cd_fornecedorTextBox.Location = new System.Drawing.Point(128, 34);
            this.cd_fornecedorTextBox.Name = "cd_fornecedorTextBox";
            this.cd_fornecedorTextBox.Size = new System.Drawing.Size(30, 20);
            this.cd_fornecedorTextBox.TabIndex = 2;
            // 
            // nm_fornecedorTextBox
            // 
            this.nm_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_fornecedor", true));
            this.nm_fornecedorTextBox.Location = new System.Drawing.Point(128, 60);
            this.nm_fornecedorTextBox.MaxLength = 50;
            this.nm_fornecedorTextBox.Name = "nm_fornecedorTextBox";
            this.nm_fornecedorTextBox.Size = new System.Drawing.Size(200, 20);
            this.nm_fornecedorTextBox.TabIndex = 4;
            // 
            // ds_enderecoTextBox
            // 
            this.ds_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "ds_endereco", true));
            this.ds_enderecoTextBox.Location = new System.Drawing.Point(128, 86);
            this.ds_enderecoTextBox.MaxLength = 50;
            this.ds_enderecoTextBox.Name = "ds_enderecoTextBox";
            this.ds_enderecoTextBox.Size = new System.Drawing.Size(200, 20);
            this.ds_enderecoTextBox.TabIndex = 6;
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Location = new System.Drawing.Point(128, 112);
            this.nm_bairroTextBox.MaxLength = 30;
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(150, 20);
            this.nm_bairroTextBox.TabIndex = 8;
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(128, 138);
            this.nm_cidadeTextBox.MaxLength = 30;
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(150, 20);
            this.nm_cidadeTextBox.TabIndex = 10;
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Location = new System.Drawing.Point(46, 293);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(75, 23);
            this.BtnAnterior.TabIndex = 19;
            this.BtnAnterior.Text = "Anterior";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.Location = new System.Drawing.Point(127, 293);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(75, 23);
            this.BtnProximo.TabIndex = 20;
            this.BtnProximo.Text = "Próximo";
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(289, 293);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 22;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(370, 322);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 28;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(289, 322);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(75, 23);
            this.BtnImprimir.TabIndex = 27;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(208, 322);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 26;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(127, 322);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 25;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(46, 322);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 24;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(370, 293);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 23;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(208, 293);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 21;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // sg_estadoComboBox
            // 
            this.sg_estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "sg_estado", true));
            this.sg_estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sg_estadoComboBox.FormattingEnabled = true;
            this.sg_estadoComboBox.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "AM",
            "PA",
            "PR",
            "SE",
            "MG",
            "AL",
            "RN",
            "RS",
            "RR",
            "SC",
            "TO",
            "RO",
            "PI",
            "PE",
            "PB",
            "MS",
            "MT",
            "MA",
            "GO",
            "ES",
            "DF",
            "CE",
            "DF",
            "BA",
            "AP",
            "AC"});
            this.sg_estadoComboBox.Location = new System.Drawing.Point(128, 163);
            this.sg_estadoComboBox.Name = "sg_estadoComboBox";
            this.sg_estadoComboBox.Size = new System.Drawing.Size(45, 21);
            this.sg_estadoComboBox.TabIndex = 12;
            // 
            // cd_cepMaskedTextBox
            // 
            this.cd_cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_cep", true));
            this.cd_cepMaskedTextBox.Location = new System.Drawing.Point(127, 190);
            this.cd_cepMaskedTextBox.Mask = "00000-000";
            this.cd_cepMaskedTextBox.Name = "cd_cepMaskedTextBox";
            this.cd_cepMaskedTextBox.Size = new System.Drawing.Size(56, 20);
            this.cd_cepMaskedTextBox.TabIndex = 14;
            // 
            // cd_cnpjMaskedTextBox
            // 
            this.cd_cnpjMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_cnpj", true));
            this.cd_cnpjMaskedTextBox.Location = new System.Drawing.Point(127, 215);
            this.cd_cnpjMaskedTextBox.Mask = "00,000,000/0000-00";
            this.cd_cnpjMaskedTextBox.Name = "cd_cnpjMaskedTextBox";
            this.cd_cnpjMaskedTextBox.Size = new System.Drawing.Size(104, 20);
            this.cd_cnpjMaskedTextBox.TabIndex = 16;
            // 
            // cd_ieMaskedTextBox
            // 
            this.cd_ieMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_ie", true));
            this.cd_ieMaskedTextBox.Location = new System.Drawing.Point(127, 240);
            this.cd_ieMaskedTextBox.Mask = "000,000,000,000";
            this.cd_ieMaskedTextBox.Name = "cd_ieMaskedTextBox";
            this.cd_ieMaskedTextBox.Size = new System.Drawing.Size(88, 20);
            this.cd_ieMaskedTextBox.TabIndex = 18;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 376);
            this.ControlBox = false;
            this.Controls.Add(cd_ieLabel);
            this.Controls.Add(this.cd_ieMaskedTextBox);
            this.Controls.Add(cd_cnpjLabel);
            this.Controls.Add(this.cd_cnpjMaskedTextBox);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(this.cd_cepMaskedTextBox);
            this.Controls.Add(sg_estadoLabel);
            this.Controls.Add(this.sg_estadoComboBox);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(cd_fornecedorLabel);
            this.Controls.Add(this.cd_fornecedorTextBox);
            this.Controls.Add(nm_fornecedorLabel);
            this.Controls.Add(this.nm_fornecedorTextBox);
            this.Controls.Add(ds_enderecoLabel);
            this.Controls.Add(this.ds_enderecoTextBox);
            this.Controls.Add(nm_bairroLabel);
            this.Controls.Add(this.nm_bairroTextBox);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(this.nm_cidadeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFornecedor";
            this.Text = "Cadastro de fornecedor";
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tb_fornecedorBindingSource;
        private bdCadastroDataSetTableAdapters.tb_fornecedorTableAdapter tb_fornecedorTableAdapter;
        private bdCadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_fornecedorTextBox;
        private System.Windows.Forms.TextBox nm_fornecedorTextBox;
        private System.Windows.Forms.TextBox ds_enderecoTextBox;
        private System.Windows.Forms.TextBox nm_bairroTextBox;
        private System.Windows.Forms.TextBox nm_cidadeTextBox;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.ComboBox sg_estadoComboBox;
        private System.Windows.Forms.MaskedTextBox cd_cepMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_cnpjMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_ieMaskedTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}