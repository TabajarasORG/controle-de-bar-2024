namespace GestaoDeBar.WinApp.ModuloGarcom
{
    partial class TelaGarcomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaGarcomForm));
            txtNome = new TextBox();
            lblNome = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            lblId = new Label();
            txtId = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtId).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(85, 52);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(438, 27);
            txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(29, 55);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(12, 108);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(211, 28);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(312, 108);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(211, 28);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(57, 22);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 4;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(85, 19);
            txtId.Name = "txtId";
            txtId.Size = new Size(120, 27);
            txtId.TabIndex = 5;
            // 
            // TelaGarcomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 148);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaGarcomForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Garcom";
            ((System.ComponentModel.ISupportInitialize)txtId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label lblNome;
        private Button btnGravar;
        private Button btnCancelar;
        private Label lblId;
        private NumericUpDown txtId;
    }
}