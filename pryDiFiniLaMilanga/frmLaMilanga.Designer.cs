namespace pryDiFiniLaMilanga
{
    partial class frmLaMilanga
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
            dgvVentas = new DataGridView();
            Comidas = new DataGridViewTextBoxColumn();
            BebidasSinAlcohol = new DataGridViewTextBoxColumn();
            BebidasConAlcohol = new DataGridViewTextBoxColumn();
            Postres = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { Comidas, BebidasSinAlcohol, BebidasConAlcohol, Postres });
            dgvVentas.Location = new Point(12, 21);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(827, 188);
            dgvVentas.TabIndex = 0;
            // 
            // Comidas
            // 
            Comidas.HeaderText = "Comidas";
            Comidas.MinimumWidth = 6;
            Comidas.Name = "Comidas";
            Comidas.Width = 200;
            // 
            // BebidasSinAlcohol
            // 
            BebidasSinAlcohol.HeaderText = "Bebidas sin alcohol";
            BebidasSinAlcohol.MinimumWidth = 6;
            BebidasSinAlcohol.Name = "BebidasSinAlcohol";
            BebidasSinAlcohol.Width = 200;
            // 
            // BebidasConAlcohol
            // 
            BebidasConAlcohol.HeaderText = "Bebidas con alcohol";
            BebidasConAlcohol.MinimumWidth = 6;
            BebidasConAlcohol.Name = "BebidasConAlcohol";
            BebidasConAlcohol.Width = 200;
            // 
            // Postres
            // 
            Postres.HeaderText = "Postres";
            Postres.MinimumWidth = 6;
            Postres.Name = "Postres";
            Postres.Width = 200;
            // 
            // frmLaMilanga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 381);
            Controls.Add(dgvVentas);
            Name = "frmLaMilanga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "La Milanga";
            Load += this.frmLaMilanga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVentas;
        private DataGridViewTextBoxColumn Comidas;
        private DataGridViewTextBoxColumn BebidasSinAlcohol;
        private DataGridViewTextBoxColumn BebidasConAlcohol;
        private DataGridViewTextBoxColumn Postres;
    }
}
