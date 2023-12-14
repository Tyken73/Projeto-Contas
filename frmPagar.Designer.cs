namespace WindowsFormsApp2
{
    partial class frmPagar
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
            System.Windows.Forms.Label cd_contas_pagarLabel;
            System.Windows.Forms.Label ds_contaLabel;
            System.Windows.Forms.Label dt_emissaoLabel;
            System.Windows.Forms.Label vl_contaLabel;
            System.Windows.Forms.Label dt_vencimentoLabel;
            System.Windows.Forms.Label dt_pagamentoLabel;
            System.Windows.Forms.Label vl_pagoLabel;
            System.Windows.Forms.Label cd_fornecedorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagar));
            this.bdCadastroDataSet = new WindowsFormsApp2.bdCadastroDataSet();
            this.tb_contas_pagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_contas_pagarTableAdapter = new WindowsFormsApp2.bdCadastroDataSetTableAdapters.tb_contas_pagarTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.bdCadastroDataSetTableAdapters.TableAdapterManager();
            this.cd_contas_pagarTextBox = new System.Windows.Forms.TextBox();
            this.ds_contaTextBox = new System.Windows.Forms.TextBox();
            this.dt_emissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_contaTextBox = new System.Windows.Forms.TextBox();
            this.dt_vencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dt_pagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_pagoTextBox = new System.Windows.Forms.TextBox();
            this.cd_fornecedorTextBox = new System.Windows.Forms.TextBox();
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
            cd_contas_pagarLabel = new System.Windows.Forms.Label();
            ds_contaLabel = new System.Windows.Forms.Label();
            dt_emissaoLabel = new System.Windows.Forms.Label();
            vl_contaLabel = new System.Windows.Forms.Label();
            dt_vencimentoLabel = new System.Windows.Forms.Label();
            dt_pagamentoLabel = new System.Windows.Forms.Label();
            vl_pagoLabel = new System.Windows.Forms.Label();
            cd_fornecedorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contas_pagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_contas_pagarLabel
            // 
            cd_contas_pagarLabel.AutoSize = true;
            cd_contas_pagarLabel.Location = new System.Drawing.Point(40, 43);
            cd_contas_pagarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cd_contas_pagarLabel.Name = "cd_contas_pagarLabel";
            cd_contas_pagarLabel.Size = new System.Drawing.Size(40, 13);
            cd_contas_pagarLabel.TabIndex = 1;
            cd_contas_pagarLabel.Text = "Código";
            // 
            // ds_contaLabel
            // 
            ds_contaLabel.AutoSize = true;
            ds_contaLabel.Location = new System.Drawing.Point(40, 66);
            ds_contaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ds_contaLabel.Name = "ds_contaLabel";
            ds_contaLabel.Size = new System.Drawing.Size(55, 13);
            ds_contaLabel.TabIndex = 3;
            ds_contaLabel.Text = "Descrição";
            // 
            // dt_emissaoLabel
            // 
            dt_emissaoLabel.AutoSize = true;
            dt_emissaoLabel.Location = new System.Drawing.Point(40, 89);
            dt_emissaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dt_emissaoLabel.Name = "dt_emissaoLabel";
            dt_emissaoLabel.Size = new System.Drawing.Size(46, 13);
            dt_emissaoLabel.TabIndex = 5;
            dt_emissaoLabel.Text = "Emissão";
            // 
            // vl_contaLabel
            // 
            vl_contaLabel.AutoSize = true;
            vl_contaLabel.Location = new System.Drawing.Point(40, 111);
            vl_contaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            vl_contaLabel.Name = "vl_contaLabel";
            vl_contaLabel.Size = new System.Drawing.Size(31, 13);
            vl_contaLabel.TabIndex = 7;
            vl_contaLabel.Text = "Valor";
            // 
            // dt_vencimentoLabel
            // 
            dt_vencimentoLabel.AutoSize = true;
            dt_vencimentoLabel.Location = new System.Drawing.Point(40, 135);
            dt_vencimentoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dt_vencimentoLabel.Name = "dt_vencimentoLabel";
            dt_vencimentoLabel.Size = new System.Drawing.Size(63, 13);
            dt_vencimentoLabel.TabIndex = 9;
            dt_vencimentoLabel.Text = "Vencimento";
            // 
            // dt_pagamentoLabel
            // 
            dt_pagamentoLabel.AutoSize = true;
            dt_pagamentoLabel.Location = new System.Drawing.Point(40, 158);
            dt_pagamentoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dt_pagamentoLabel.Name = "dt_pagamentoLabel";
            dt_pagamentoLabel.Size = new System.Drawing.Size(61, 13);
            dt_pagamentoLabel.TabIndex = 11;
            dt_pagamentoLabel.Text = "Pagamento";
            // 
            // vl_pagoLabel
            // 
            vl_pagoLabel.AutoSize = true;
            vl_pagoLabel.Location = new System.Drawing.Point(40, 180);
            vl_pagoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            vl_pagoLabel.Name = "vl_pagoLabel";
            vl_pagoLabel.Size = new System.Drawing.Size(58, 13);
            vl_pagoLabel.TabIndex = 13;
            vl_pagoLabel.Text = "Valor pago";
            // 
            // cd_fornecedorLabel
            // 
            cd_fornecedorLabel.AutoSize = true;
            cd_fornecedorLabel.Location = new System.Drawing.Point(40, 202);
            cd_fornecedorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cd_fornecedorLabel.Name = "cd_fornecedorLabel";
            cd_fornecedorLabel.Size = new System.Drawing.Size(72, 13);
            cd_fornecedorLabel.TabIndex = 15;
            cd_fornecedorLabel.Text = "ID fornecedor";
            // 
            // bdCadastroDataSet
            // 
            this.bdCadastroDataSet.DataSetName = "bdCadastroDataSet";
            this.bdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_contas_pagarBindingSource
            // 
            this.tb_contas_pagarBindingSource.DataMember = "tb_contas_pagar";
            this.tb_contas_pagarBindingSource.DataSource = this.bdCadastroDataSet;
            // 
            // tb_contas_pagarTableAdapter
            // 
            this.tb_contas_pagarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = null;
            this.tableAdapterManager.tb_contas_pagarTableAdapter = this.tb_contas_pagarTableAdapter;
            this.tableAdapterManager.tb_contas_receberTableAdapter = null;
            this.tableAdapterManager.tb_fornecedorTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.bdCadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_contas_pagarTextBox
            // 
            this.cd_contas_pagarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_pagarBindingSource, "cd_contas_pagar", true));
            this.cd_contas_pagarTextBox.Location = new System.Drawing.Point(125, 41);
            this.cd_contas_pagarTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cd_contas_pagarTextBox.Name = "cd_contas_pagarTextBox";
            this.cd_contas_pagarTextBox.Size = new System.Drawing.Size(30, 20);
            this.cd_contas_pagarTextBox.TabIndex = 2;
            // 
            // ds_contaTextBox
            // 
            this.ds_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_pagarBindingSource, "ds_conta", true));
            this.ds_contaTextBox.Location = new System.Drawing.Point(125, 63);
            this.ds_contaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ds_contaTextBox.MaxLength = 50;
            this.ds_contaTextBox.Name = "ds_contaTextBox";
            this.ds_contaTextBox.Size = new System.Drawing.Size(200, 20);
            this.ds_contaTextBox.TabIndex = 4;
            // 
            // dt_emissaoDateTimePicker
            // 
            this.dt_emissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contas_pagarBindingSource, "dt_emissao", true));
            this.dt_emissaoDateTimePicker.Location = new System.Drawing.Point(125, 86);
            this.dt_emissaoDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dt_emissaoDateTimePicker.Name = "dt_emissaoDateTimePicker";
            this.dt_emissaoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dt_emissaoDateTimePicker.TabIndex = 6;
            // 
            // vl_contaTextBox
            // 
            this.vl_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_pagarBindingSource, "vl_conta", true));
            this.vl_contaTextBox.Location = new System.Drawing.Point(125, 109);
            this.vl_contaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.vl_contaTextBox.Name = "vl_contaTextBox";
            this.vl_contaTextBox.Size = new System.Drawing.Size(76, 20);
            this.vl_contaTextBox.TabIndex = 8;
            // 
            // dt_vencimentoDateTimePicker
            // 
            this.dt_vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contas_pagarBindingSource, "dt_vencimento", true));
            this.dt_vencimentoDateTimePicker.Location = new System.Drawing.Point(125, 132);
            this.dt_vencimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dt_vencimentoDateTimePicker.Name = "dt_vencimentoDateTimePicker";
            this.dt_vencimentoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dt_vencimentoDateTimePicker.TabIndex = 10;
            // 
            // dt_pagamentoDateTimePicker
            // 
            this.dt_pagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contas_pagarBindingSource, "dt_pagamento", true));
            this.dt_pagamentoDateTimePicker.Location = new System.Drawing.Point(125, 154);
            this.dt_pagamentoDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dt_pagamentoDateTimePicker.Name = "dt_pagamentoDateTimePicker";
            this.dt_pagamentoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dt_pagamentoDateTimePicker.TabIndex = 12;
            // 
            // vl_pagoTextBox
            // 
            this.vl_pagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_pagarBindingSource, "vl_pago", true));
            this.vl_pagoTextBox.Location = new System.Drawing.Point(125, 177);
            this.vl_pagoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.vl_pagoTextBox.Name = "vl_pagoTextBox";
            this.vl_pagoTextBox.Size = new System.Drawing.Size(76, 20);
            this.vl_pagoTextBox.TabIndex = 14;
            // 
            // cd_fornecedorTextBox
            // 
            this.cd_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_pagarBindingSource, "cd_fornecedor", true));
            this.cd_fornecedorTextBox.Location = new System.Drawing.Point(125, 200);
            this.cd_fornecedorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cd_fornecedorTextBox.Name = "cd_fornecedorTextBox";
            this.cd_fornecedorTextBox.Size = new System.Drawing.Size(30, 20);
            this.cd_fornecedorTextBox.TabIndex = 16;
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Location = new System.Drawing.Point(43, 254);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(75, 23);
            this.BtnAnterior.TabIndex = 18;
            this.BtnAnterior.Text = "Anterior";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.Location = new System.Drawing.Point(124, 254);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(75, 23);
            this.BtnProximo.TabIndex = 19;
            this.BtnProximo.Text = "Próximo";
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(286, 254);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 21;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(367, 282);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 27;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(286, 282);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(75, 23);
            this.BtnImprimir.TabIndex = 26;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(205, 282);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 25;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(124, 282);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 24;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(43, 282);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 23;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(367, 254);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 22;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(205, 254);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 20;
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
            // frmPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 337);
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
            this.Controls.Add(cd_contas_pagarLabel);
            this.Controls.Add(this.cd_contas_pagarTextBox);
            this.Controls.Add(ds_contaLabel);
            this.Controls.Add(this.ds_contaTextBox);
            this.Controls.Add(dt_emissaoLabel);
            this.Controls.Add(this.dt_emissaoDateTimePicker);
            this.Controls.Add(vl_contaLabel);
            this.Controls.Add(this.vl_contaTextBox);
            this.Controls.Add(dt_vencimentoLabel);
            this.Controls.Add(this.dt_vencimentoDateTimePicker);
            this.Controls.Add(dt_pagamentoLabel);
            this.Controls.Add(this.dt_pagamentoDateTimePicker);
            this.Controls.Add(vl_pagoLabel);
            this.Controls.Add(this.vl_pagoTextBox);
            this.Controls.Add(cd_fornecedorLabel);
            this.Controls.Add(this.cd_fornecedorTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPagar";
            this.Text = "Cadastro de conta a pagar";
            this.Load += new System.EventHandler(this.frmPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contas_pagarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tb_contas_pagarBindingSource;
        private bdCadastroDataSetTableAdapters.tb_contas_pagarTableAdapter tb_contas_pagarTableAdapter;
        private bdCadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_contas_pagarTextBox;
        private System.Windows.Forms.TextBox ds_contaTextBox;
        private System.Windows.Forms.DateTimePicker dt_emissaoDateTimePicker;
        private System.Windows.Forms.TextBox vl_contaTextBox;
        private System.Windows.Forms.DateTimePicker dt_vencimentoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dt_pagamentoDateTimePicker;
        private System.Windows.Forms.TextBox vl_pagoTextBox;
        private System.Windows.Forms.TextBox cd_fornecedorTextBox;
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
    }
}