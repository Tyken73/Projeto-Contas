namespace WindowsFormsApp2
{
    partial class frmCliente
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
            System.Windows.Forms.Label cd_clienteLabel;
            System.Windows.Forms.Label nm_clienteLabel;
            System.Windows.Forms.Label ds_enderecoLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_cpfLabel;
            System.Windows.Forms.Label cd_rgLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.bdCadastroDataSet = new WindowsFormsApp2.bdCadastroDataSet();
            this.tb_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_clienteTableAdapter = new WindowsFormsApp2.bdCadastroDataSetTableAdapters.tb_clienteTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.bdCadastroDataSetTableAdapters.TableAdapterManager();
            this.cd_clienteTextBox = new System.Windows.Forms.TextBox();
            this.nm_clienteTextBox = new System.Windows.Forms.TextBox();
            this.ds_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.sg_estadoTextBox = new System.Windows.Forms.TextBox();
            this.cd_rgTextBox = new System.Windows.Forms.TextBox();
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
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.cd_cpfTextBox = new System.Windows.Forms.TextBox();
            this.cd_cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            cd_clienteLabel = new System.Windows.Forms.Label();
            nm_clienteLabel = new System.Windows.Forms.Label();
            ds_enderecoLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_cpfLabel = new System.Windows.Forms.Label();
            cd_rgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_clienteLabel
            // 
            cd_clienteLabel.AutoSize = true;
            cd_clienteLabel.Location = new System.Drawing.Point(41, 39);
            cd_clienteLabel.Name = "cd_clienteLabel";
            cd_clienteLabel.Size = new System.Drawing.Size(40, 13);
            cd_clienteLabel.TabIndex = 1;
            cd_clienteLabel.Text = "Código";
            // 
            // nm_clienteLabel
            // 
            nm_clienteLabel.AutoSize = true;
            nm_clienteLabel.Location = new System.Drawing.Point(41, 65);
            nm_clienteLabel.Name = "nm_clienteLabel";
            nm_clienteLabel.Size = new System.Drawing.Size(35, 13);
            nm_clienteLabel.TabIndex = 3;
            nm_clienteLabel.Text = "Nome";
            // 
            // ds_enderecoLabel
            // 
            ds_enderecoLabel.AutoSize = true;
            ds_enderecoLabel.Location = new System.Drawing.Point(41, 91);
            ds_enderecoLabel.Name = "ds_enderecoLabel";
            ds_enderecoLabel.Size = new System.Drawing.Size(53, 13);
            ds_enderecoLabel.TabIndex = 5;
            ds_enderecoLabel.Text = "Endereço";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Location = new System.Drawing.Point(41, 117);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(34, 13);
            nm_bairroLabel.TabIndex = 7;
            nm_bairroLabel.Text = "Bairro";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Location = new System.Drawing.Point(41, 143);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(40, 13);
            nm_cidadeLabel.TabIndex = 9;
            nm_cidadeLabel.Text = "Cidade";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Location = new System.Drawing.Point(41, 169);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(40, 13);
            sg_estadoLabel.TabIndex = 11;
            sg_estadoLabel.Text = "Estado";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Location = new System.Drawing.Point(41, 195);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(28, 13);
            cd_cepLabel.TabIndex = 13;
            cd_cepLabel.Text = "CEP";
            // 
            // cd_cpfLabel
            // 
            cd_cpfLabel.AutoSize = true;
            cd_cpfLabel.Location = new System.Drawing.Point(41, 221);
            cd_cpfLabel.Name = "cd_cpfLabel";
            cd_cpfLabel.Size = new System.Drawing.Size(27, 13);
            cd_cpfLabel.TabIndex = 15;
            cd_cpfLabel.Text = "CPF";
            // 
            // cd_rgLabel
            // 
            cd_rgLabel.AutoSize = true;
            cd_rgLabel.Location = new System.Drawing.Point(41, 247);
            cd_rgLabel.Name = "cd_rgLabel";
            cd_rgLabel.Size = new System.Drawing.Size(23, 13);
            cd_rgLabel.TabIndex = 17;
            cd_rgLabel.Text = "RG";
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
            // cd_clienteTextBox
            // 
            this.cd_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_cliente", true));
            this.cd_clienteTextBox.Location = new System.Drawing.Point(116, 36);
            this.cd_clienteTextBox.Name = "cd_clienteTextBox";
            this.cd_clienteTextBox.Size = new System.Drawing.Size(30, 20);
            this.cd_clienteTextBox.TabIndex = 2;
            // 
            // nm_clienteTextBox
            // 
            this.nm_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "nm_cliente", true));
            this.nm_clienteTextBox.Location = new System.Drawing.Point(116, 62);
            this.nm_clienteTextBox.Name = "nm_clienteTextBox";
            this.nm_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.nm_clienteTextBox.TabIndex = 4;
            // 
            // ds_enderecoTextBox
            // 
            this.ds_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "ds_endereco", true));
            this.ds_enderecoTextBox.Location = new System.Drawing.Point(116, 88);
            this.ds_enderecoTextBox.MaxLength = 50;
            this.ds_enderecoTextBox.Name = "ds_enderecoTextBox";
            this.ds_enderecoTextBox.Size = new System.Drawing.Size(200, 20);
            this.ds_enderecoTextBox.TabIndex = 6;
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Location = new System.Drawing.Point(116, 114);
            this.nm_bairroTextBox.MaxLength = 30;
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(150, 20);
            this.nm_bairroTextBox.TabIndex = 8;
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(116, 140);
            this.nm_cidadeTextBox.MaxLength = 30;
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(150, 20);
            this.nm_cidadeTextBox.TabIndex = 10;
            // 
            // sg_estadoTextBox
            // 
            this.sg_estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "sg_estado", true));
            this.sg_estadoTextBox.Location = new System.Drawing.Point(116, 166);
            this.sg_estadoTextBox.MaxLength = 2;
            this.sg_estadoTextBox.Name = "sg_estadoTextBox";
            this.sg_estadoTextBox.Size = new System.Drawing.Size(20, 20);
            this.sg_estadoTextBox.TabIndex = 12;
            // 
            // cd_rgTextBox
            // 
            this.cd_rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_rg", true));
            this.cd_rgTextBox.Location = new System.Drawing.Point(116, 244);
            this.cd_rgTextBox.MaxLength = 15;
            this.cd_rgTextBox.Name = "cd_rgTextBox";
            this.cd_rgTextBox.Size = new System.Drawing.Size(85, 20);
            this.cd_rgTextBox.TabIndex = 18;
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Location = new System.Drawing.Point(44, 289);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(75, 23);
            this.BtnAnterior.TabIndex = 19;
            this.BtnAnterior.Text = "Anterior";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.Location = new System.Drawing.Point(124, 289);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(75, 23);
            this.BtnProximo.TabIndex = 20;
            this.BtnProximo.Text = "Próximo";
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(286, 289);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 22;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(368, 318);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 28;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(286, 318);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(75, 23);
            this.BtnImprimir.TabIndex = 27;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(206, 318);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 26;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(124, 318);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 25;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(44, 318);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 24;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(368, 289);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 23;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(206, 289);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 21;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // cd_cpfTextBox
            // 
            this.cd_cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_cpf", true));
            this.cd_cpfTextBox.Location = new System.Drawing.Point(116, 218);
            this.cd_cpfTextBox.MaxLength = 14;
            this.cd_cpfTextBox.Name = "cd_cpfTextBox";
            this.cd_cpfTextBox.Size = new System.Drawing.Size(80, 20);
            this.cd_cpfTextBox.TabIndex = 16;
            // 
            // cd_cepMaskedTextBox
            // 
            this.cd_cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_cep", true));
            this.cd_cepMaskedTextBox.Location = new System.Drawing.Point(116, 192);
            this.cd_cepMaskedTextBox.Mask = "00000-000";
            this.cd_cepMaskedTextBox.Name = "cd_cepMaskedTextBox";
            this.cd_cepMaskedTextBox.Size = new System.Drawing.Size(58, 20);
            this.cd_cepMaskedTextBox.TabIndex = 29;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 376);
            this.ControlBox = false;
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
            this.Controls.Add(cd_clienteLabel);
            this.Controls.Add(this.cd_clienteTextBox);
            this.Controls.Add(nm_clienteLabel);
            this.Controls.Add(this.nm_clienteTextBox);
            this.Controls.Add(ds_enderecoLabel);
            this.Controls.Add(this.ds_enderecoTextBox);
            this.Controls.Add(nm_bairroLabel);
            this.Controls.Add(this.nm_bairroTextBox);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(this.nm_cidadeTextBox);
            this.Controls.Add(sg_estadoLabel);
            this.Controls.Add(this.sg_estadoTextBox);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(cd_cpfLabel);
            this.Controls.Add(this.cd_cpfTextBox);
            this.Controls.Add(cd_rgLabel);
            this.Controls.Add(this.cd_rgTextBox);
            this.Controls.Add(this.cd_cepMaskedTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCliente";
            this.Text = "Cadastro de cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tb_clienteBindingSource;
        private bdCadastroDataSetTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
        private bdCadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_clienteTextBox;
        private System.Windows.Forms.TextBox nm_clienteTextBox;
        private System.Windows.Forms.TextBox ds_enderecoTextBox;
        private System.Windows.Forms.TextBox nm_bairroTextBox;
        private System.Windows.Forms.TextBox nm_cidadeTextBox;
        private System.Windows.Forms.TextBox sg_estadoTextBox;
        private System.Windows.Forms.TextBox cd_rgTextBox;
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
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox cd_cpfTextBox;
        private System.Windows.Forms.MaskedTextBox cd_cepMaskedTextBox;
    }
}