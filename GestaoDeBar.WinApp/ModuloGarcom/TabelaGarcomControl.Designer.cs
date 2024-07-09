namespace GestaoDeBar.WinApp.ModuloGarcom
{
    partial class TabelaGarcomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridViewGarcom = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridViewGarcom).BeginInit();
            SuspendLayout();
            // 
            // gridViewGarcom
            // 
            gridViewGarcom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewGarcom.Dock = DockStyle.Fill;
            gridViewGarcom.Location = new Point(0, 0);
            gridViewGarcom.Name = "gridViewGarcom";
            gridViewGarcom.Size = new Size(525, 430);
            gridViewGarcom.TabIndex = 0;
            // 
            // TabelaGarcomControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridViewGarcom);
            Name = "TabelaGarcomControl";
            Size = new Size(525, 430);
            ((System.ComponentModel.ISupportInitialize)gridViewGarcom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridViewGarcom;
    }
}
