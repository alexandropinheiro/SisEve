namespace Siseve.UI
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContrato = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUtilitarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTipoEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTipoContato = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormaPagto = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro,
            this.menuContrato,
            this.menuUtilitarios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.toolStripMenuItem1});
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(66, 20);
            this.menuCadastro.Text = "Cadastro";
            // 
            // menuCliente
            // 
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(152, 22);
            this.menuCliente.Text = "Cliente";
            this.menuCliente.Click += new System.EventHandler(this.menuCliente_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Serviço";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuContrato
            // 
            this.menuContrato.Name = "menuContrato";
            this.menuContrato.Size = new System.Drawing.Size(66, 20);
            this.menuContrato.Text = "Contrato";
            // 
            // menuUtilitarios
            // 
            this.menuUtilitarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTipoEvento,
            this.menuTipoContato,
            this.mnuFormaPagto,
            this.tipoDeServiçoToolStripMenuItem});
            this.menuUtilitarios.Name = "menuUtilitarios";
            this.menuUtilitarios.Size = new System.Drawing.Size(69, 20);
            this.menuUtilitarios.Text = "Utilitários";
            // 
            // menuTipoEvento
            // 
            this.menuTipoEvento.Name = "menuTipoEvento";
            this.menuTipoEvento.Size = new System.Drawing.Size(188, 22);
            this.menuTipoEvento.Text = "Tipo de Evento";
            this.menuTipoEvento.Click += new System.EventHandler(this.tipoDeEventoToolStripMenuItem_Click);
            // 
            // menuTipoContato
            // 
            this.menuTipoContato.Name = "menuTipoContato";
            this.menuTipoContato.Size = new System.Drawing.Size(188, 22);
            this.menuTipoContato.Text = "Tipo de Contato";
            this.menuTipoContato.Click += new System.EventHandler(this.tipoDeContatoToolStripMenuItem_Click);
            // 
            // mnuFormaPagto
            // 
            this.mnuFormaPagto.Name = "mnuFormaPagto";
            this.mnuFormaPagto.Size = new System.Drawing.Size(188, 22);
            this.mnuFormaPagto.Text = "Forma de Pagamento";
            this.mnuFormaPagto.Click += new System.EventHandler(this.mnuFormaPagto_Click);
            // 
            // tipoDeServiçoToolStripMenuItem
            // 
            this.tipoDeServiçoToolStripMenuItem.Name = "tipoDeServiçoToolStripMenuItem";
            this.tipoDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.tipoDeServiçoToolStripMenuItem.Text = "Tipo de Serviço";
            this.tipoDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeServiçoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuContrato;
        private System.Windows.Forms.ToolStripMenuItem menuUtilitarios;
        private System.Windows.Forms.ToolStripMenuItem menuTipoEvento;
        private System.Windows.Forms.ToolStripMenuItem menuTipoContato;
        private System.Windows.Forms.ToolStripMenuItem mnuFormaPagto;
        private System.Windows.Forms.ToolStripMenuItem tipoDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

