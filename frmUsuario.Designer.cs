namespace WindowsFormsApp2
{
    partial class frmUsuario
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
            System.Windows.Forms.Label cd_usuarioLabel;
            System.Windows.Forms.Label nm_usuarioLabel;
            System.Windows.Forms.Label sg_nivelLabel;
            System.Windows.Forms.Label nm_loginLabel;
            System.Windows.Forms.Label cd_senhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.cd_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.tb_usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdCadastroDataSet = new WindowsFormsApp2.bdCadastroDataSet();
            this.nm_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.sg_nivelTextBox = new System.Windows.Forms.TextBox();
            this.nm_loginTextBox = new System.Windows.Forms.TextBox();
            this.cd_senhaTextBox = new System.Windows.Forms.TextBox();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.tb_usuarioTableAdapter = new WindowsFormsApp2.bdCadastroDataSetTableAdapters.tb_usuarioTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.bdCadastroDataSetTableAdapters.TableAdapterManager();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            cd_usuarioLabel = new System.Windows.Forms.Label();
            nm_usuarioLabel = new System.Windows.Forms.Label();
            sg_nivelLabel = new System.Windows.Forms.Label();
            nm_loginLabel = new System.Windows.Forms.Label();
            cd_senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_usuarioLabel
            // 
            cd_usuarioLabel.AutoSize = true;
            cd_usuarioLabel.Location = new System.Drawing.Point(49, 30);
            cd_usuarioLabel.Name = "cd_usuarioLabel";
            cd_usuarioLabel.Size = new System.Drawing.Size(40, 13);
            cd_usuarioLabel.TabIndex = 1;
            cd_usuarioLabel.Text = "Código";
            // 
            // nm_usuarioLabel
            // 
            nm_usuarioLabel.AutoSize = true;
            nm_usuarioLabel.Location = new System.Drawing.Point(49, 56);
            nm_usuarioLabel.Name = "nm_usuarioLabel";
            nm_usuarioLabel.Size = new System.Drawing.Size(35, 13);
            nm_usuarioLabel.TabIndex = 3;
            nm_usuarioLabel.Text = "Nome";
            // 
            // sg_nivelLabel
            // 
            sg_nivelLabel.AutoSize = true;
            sg_nivelLabel.Location = new System.Drawing.Point(49, 82);
            sg_nivelLabel.Name = "sg_nivelLabel";
            sg_nivelLabel.Size = new System.Drawing.Size(33, 13);
            sg_nivelLabel.TabIndex = 5;
            sg_nivelLabel.Text = "Nível";
            // 
            // nm_loginLabel
            // 
            nm_loginLabel.AutoSize = true;
            nm_loginLabel.Location = new System.Drawing.Point(49, 108);
            nm_loginLabel.Name = "nm_loginLabel";
            nm_loginLabel.Size = new System.Drawing.Size(33, 13);
            nm_loginLabel.TabIndex = 7;
            nm_loginLabel.Text = "Login";
            // 
            // cd_senhaLabel
            // 
            cd_senhaLabel.AutoSize = true;
            cd_senhaLabel.Location = new System.Drawing.Point(49, 134);
            cd_senhaLabel.Name = "cd_senhaLabel";
            cd_senhaLabel.Size = new System.Drawing.Size(38, 13);
            cd_senhaLabel.TabIndex = 9;
            cd_senhaLabel.Text = "Senha";
            // 
            // cd_usuarioTextBox
            // 
            this.cd_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "cd_usuario", true));
            this.cd_usuarioTextBox.Location = new System.Drawing.Point(116, 27);
            this.cd_usuarioTextBox.Name = "cd_usuarioTextBox";
            this.cd_usuarioTextBox.Size = new System.Drawing.Size(30, 20);
            this.cd_usuarioTextBox.TabIndex = 2;
            // 
            // tb_usuarioBindingSource
            // 
            this.tb_usuarioBindingSource.DataMember = "tb_usuario";
            this.tb_usuarioBindingSource.DataSource = this.bdCadastroDataSet;
            // 
            // bdCadastroDataSet
            // 
            this.bdCadastroDataSet.DataSetName = "bdCadastroDataSet";
            this.bdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nm_usuarioTextBox
            // 
            this.nm_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "nm_usuario", true));
            this.nm_usuarioTextBox.Location = new System.Drawing.Point(116, 53);
            this.nm_usuarioTextBox.MaxLength = 50;
            this.nm_usuarioTextBox.Name = "nm_usuarioTextBox";
            this.nm_usuarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.nm_usuarioTextBox.TabIndex = 4;
            this.nm_usuarioTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.nm_usuarioTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // sg_nivelTextBox
            // 
            this.sg_nivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "sg_nivel", true));
            this.sg_nivelTextBox.Location = new System.Drawing.Point(116, 79);
            this.sg_nivelTextBox.MaxLength = 1;
            this.sg_nivelTextBox.Name = "sg_nivelTextBox";
            this.sg_nivelTextBox.Size = new System.Drawing.Size(15, 20);
            this.sg_nivelTextBox.TabIndex = 6;
            this.sg_nivelTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.sg_nivelTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // nm_loginTextBox
            // 
            this.nm_loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "nm_login", true));
            this.nm_loginTextBox.Location = new System.Drawing.Point(116, 105);
            this.nm_loginTextBox.MaxLength = 15;
            this.nm_loginTextBox.Name = "nm_loginTextBox";
            this.nm_loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.nm_loginTextBox.TabIndex = 8;
            this.nm_loginTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.nm_loginTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // cd_senhaTextBox
            // 
            this.cd_senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "cd_senha", true));
            this.cd_senhaTextBox.Location = new System.Drawing.Point(116, 131);
            this.cd_senhaTextBox.MaxLength = 15;
            this.cd_senhaTextBox.Name = "cd_senhaTextBox";
            this.cd_senhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cd_senhaTextBox.TabIndex = 10;
            this.cd_senhaTextBox.UseSystemPasswordChar = true;
            this.cd_senhaTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.cd_senhaTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(204, 174);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 13;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(366, 174);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 15;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(42, 203);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 16;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(123, 203);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(204, 203);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 18;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(285, 203);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(75, 23);
            this.BtnImprimir.TabIndex = 19;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(366, 203);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 20;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(285, 174);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 14;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.Location = new System.Drawing.Point(123, 174);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(75, 23);
            this.BtnProximo.TabIndex = 12;
            this.BtnProximo.Text = "Próximo";
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Location = new System.Drawing.Point(42, 174);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(75, 23);
            this.BtnAnterior.TabIndex = 11;
            this.BtnAnterior.Text = "Anterior";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // tb_usuarioTableAdapter
            // 
            this.tb_usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = null;
            this.tableAdapterManager.tb_contas_pagarTableAdapter = null;
            this.tableAdapterManager.tb_contas_receberTableAdapter = null;
            this.tableAdapterManager.tb_fornecedorTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = this.tb_usuarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.bdCadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
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
            this.Controls.Add(cd_usuarioLabel);
            this.Controls.Add(this.cd_usuarioTextBox);
            this.Controls.Add(nm_usuarioLabel);
            this.Controls.Add(this.nm_usuarioTextBox);
            this.Controls.Add(sg_nivelLabel);
            this.Controls.Add(this.sg_nivelTextBox);
            this.Controls.Add(nm_loginLabel);
            this.Controls.Add(this.nm_loginTextBox);
            this.Controls.Add(cd_senhaLabel);
            this.Controls.Add(this.cd_senhaTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUsuario";
            this.Text = "Cadastro de usuário";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.Enter += new System.EventHandler(this.TextBox_Enter);
            this.Leave += new System.EventHandler(this.TextBox_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tb_usuarioBindingSource;
        private bdCadastroDataSetTableAdapters.tb_usuarioTableAdapter tb_usuarioTableAdapter;
        private bdCadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_usuarioTextBox;
        private System.Windows.Forms.TextBox nm_usuarioTextBox;
        private System.Windows.Forms.TextBox sg_nivelTextBox;
        private System.Windows.Forms.TextBox nm_loginTextBox;
        private System.Windows.Forms.TextBox cd_senhaTextBox;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}