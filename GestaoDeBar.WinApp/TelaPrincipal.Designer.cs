namespace GestaoDeBar.WinApp
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnEditar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnExcluir = new ToolStripButton();
            lblTipo = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            btnAdiconarMesa = new ToolStripButton();
            painelRegistros = new Panel();
            statusStrip1 = new StatusStrip();
            statusStrip2 = new StatusStrip();
            lblStripStatus = new ToolStripStatusLabel();
            garçomToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            painelRegistros.SuspendLayout();
            statusStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(821, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtoToolStripMenuItem, garçomToolStripMenuItem });
            cadastrarToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(89, 25);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(180, 26);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, toolStripSeparator1, btnEditar, toolStripSeparator2, btnExcluir, lblTipo, toolStripSeparator3, btnAdiconarMesa });
            toolStrip1.Location = new Point(0, 29);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(821, 38);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Margin = new Padding(3);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(28, 32);
            btnAdicionar.Text = "toolStripButton1";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Margin = new Padding(3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(28, 32);
            btnEditar.Text = "toolStripButton2";
            btnEditar.Click += btnEditar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 38);
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Margin = new Padding(3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(28, 32);
            btnExcluir.Text = "toolStripButton3";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lblTipo
            // 
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(0, 35);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 38);
            // 
            // btnAdiconarMesa
            // 
            btnAdiconarMesa.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdiconarMesa.Enabled = false;
            btnAdiconarMesa.Image = (Image)resources.GetObject("btnAdiconarMesa.Image");
            btnAdiconarMesa.ImageScaling = ToolStripItemImageScaling.None;
            btnAdiconarMesa.ImageTransparentColor = Color.Magenta;
            btnAdiconarMesa.Margin = new Padding(5);
            btnAdiconarMesa.Name = "btnAdiconarMesa";
            btnAdiconarMesa.Size = new Size(28, 28);
            btnAdiconarMesa.Text = "toolStripButton1";
            btnAdiconarMesa.Click += btnAdiconarMesa_Click;
            // 
            // painelRegistros
            // 
            painelRegistros.Controls.Add(statusStrip1);
            painelRegistros.Location = new Point(0, 62);
            painelRegistros.Name = "painelRegistros";
            painelRegistros.Size = new Size(821, 369);
            painelRegistros.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Location = new Point(94, 377);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(202, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip2
            // 
            statusStrip2.Items.AddRange(new ToolStripItem[] { lblStripStatus });
            statusStrip2.Location = new Point(0, 434);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(821, 22);
            statusStrip2.TabIndex = 3;
            statusStrip2.Text = "statusStrip2";
            // 
            // lblStripStatus
            // 
            lblStripStatus.Name = "lblStripStatus";
            lblStripStatus.Size = new Size(0, 17);
            // 
            // garçomToolStripMenuItem
            // 
            garçomToolStripMenuItem.Name = "garçomToolStripMenuItem";
            garçomToolStripMenuItem.Size = new Size(180, 26);
            garçomToolStripMenuItem.Text = "Garçom";
            garçomToolStripMenuItem.Click += garçomToolStripMenuItem_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 456);
            Controls.Add(statusStrip2);
            Controls.Add(painelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestao de Bar";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            painelRegistros.ResumeLayout(false);
            painelRegistros.PerformLayout();
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripLabel lblTipo;
        private Panel painelRegistros;
        private StatusStrip statusStrip1;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel lblStripStatus;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnAdiconarMesa;
        private ToolStripMenuItem garçomToolStripMenuItem;
    }
}
