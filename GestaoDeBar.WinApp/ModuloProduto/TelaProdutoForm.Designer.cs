namespace GestaoDeBar.WinApp.ModuloProduto
{
    partial class TelaProdutoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaProdutoForm));
            lblProduto = new Label();
            lblPreco = new Label();
            txtNome = new TextBox();
            txtPreco = new NumericUpDown();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtId = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtId).BeginInit();
            SuspendLayout();
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduto.Location = new Point(59, 15);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 20);
            lblProduto.TabIndex = 0;
            lblProduto.Text = "Nome";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(63, 59);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(46, 20);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preco";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(115, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(275, 27);
            txtNome.TabIndex = 0;
            // 
            // txtPreco
            // 
            txtPreco.DecimalPlaces = 2;
            txtPreco.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreco.Location = new Point(115, 57);
            txtPreco.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(120, 27);
            txtPreco.TabIndex = 1;
            txtPreco.ThousandsSeparator = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(12, 126);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(245, 29);
            btnGravar.TabIndex = 2;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(277, 126);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(239, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.DecimalPlaces = 2;
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(115, 90);
            txtId.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            txtId.Name = "txtId";
            txtId.Size = new Size(120, 27);
            txtId.TabIndex = 4;
            txtId.ThousandsSeparator = true;
            txtId.Visible = false;
            // 
            // TelaProdutoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 167);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(lblPreco);
            Controls.Add(lblProduto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaProdutoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Produto";
            ((System.ComponentModel.ISupportInitialize)txtPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduto;
        private Label lblPreco;
        private TextBox txtNome;
        private NumericUpDown txtPreco;
        private Button btnGravar;
        private Button btnCancelar;
        private NumericUpDown txtId;
    }
}