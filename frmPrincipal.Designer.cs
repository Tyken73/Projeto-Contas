namespace WindowsFormsApp2
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuàriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatòriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuàriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatòriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuàriosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.contasAPagarToolStripMenuItem,
            this.contasAReceberToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuàriosToolStripMenuItem
            // 
            this.usuàriosToolStripMenuItem.Name = "usuàriosToolStripMenuItem";
            this.usuàriosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.usuàriosToolStripMenuItem.Text = "Usuários";
            this.usuàriosToolStripMenuItem.Click += new System.EventHandler(this.UsuàriosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.FornecedoresToolStripMenuItem_Click);
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.contasAPagarToolStripMenuItem.Text = "Contas a pagar";
            this.contasAPagarToolStripMenuItem.Click += new System.EventHandler(this.contasAPagarToolStripMenuItem_Click);
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.contasAReceberToolStripMenuItem.Text = "Contas a receber";
            this.contasAReceberToolStripMenuItem.Click += new System.EventHandler(this.contasAReceberToolStripMenuItem_Click);
            // 
            // relatòriosToolStripMenuItem
            // 
            this.relatòriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuàriosToolStripMenuItem1,
            this.clientesToolStripMenuItem1,
            this.fornecedoresToolStripMenuItem1,
            this.contasAPagarToolStripMenuItem1,
            this.contasAReceberToolStripMenuItem1});
            this.relatòriosToolStripMenuItem.Name = "relatòriosToolStripMenuItem";
            this.relatòriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatòriosToolStripMenuItem.Text = "Relatórios";
            // 
            // usuàriosToolStripMenuItem1
            // 
            this.usuàriosToolStripMenuItem1.Name = "usuàriosToolStripMenuItem1";
            this.usuàriosToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.usuàriosToolStripMenuItem1.Text = "Usuários";
            this.usuàriosToolStripMenuItem1.Click += new System.EventHandler(this.UsuàriosToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.ClientesToolStripMenuItem1_Click);
            // 
            // fornecedoresToolStripMenuItem1
            // 
            this.fornecedoresToolStripMenuItem1.Name = "fornecedoresToolStripMenuItem1";
            this.fornecedoresToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.fornecedoresToolStripMenuItem1.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem1.Click += new System.EventHandler(this.FornecedoresToolStripMenuItem1_Click);
            // 
            // contasAPagarToolStripMenuItem1
            // 
            this.contasAPagarToolStripMenuItem1.Name = "contasAPagarToolStripMenuItem1";
            this.contasAPagarToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.contasAPagarToolStripMenuItem1.Text = "Contas a pagar";
            this.contasAPagarToolStripMenuItem1.Click += new System.EventHandler(this.ContasAPagarToolStripMenuItem1_Click);
            // 
            // contasAReceberToolStripMenuItem1
            // 
            this.contasAReceberToolStripMenuItem1.Name = "contasAReceberToolStripMenuItem1";
            this.contasAReceberToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.contasAReceberToolStripMenuItem1.Text = "Contas a receber";
            this.contasAReceberToolStripMenuItem1.Click += new System.EventHandler(this.ContasAReceberToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuàriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatòriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuàriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

