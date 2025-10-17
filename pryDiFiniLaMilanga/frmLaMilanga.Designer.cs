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
            Mozos = new DataGridViewTextBoxColumn();
            Comidas = new DataGridViewTextBoxColumn();
            BebidasSinAlcohol = new DataGridViewTextBoxColumn();
            BebidasConAlcohol = new DataGridViewTextBoxColumn();
            Postres = new DataGridViewTextBoxColumn();
            btnValidarDatos = new Button();
            btnSalir = new Button();
            btnMozoDelDia = new Button();
            btnTotales = new Button();
            lblResultadoMozoDelDia = new Label();
            lblResultadoTotales = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { Mozos, Comidas, BebidasSinAlcohol, BebidasConAlcohol, Postres });
            dgvVentas.Location = new Point(10, 16);
            dgvVentas.Margin = new Padding(3, 2, 3, 2);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(646, 141);
            dgvVentas.TabIndex = 0;
            // 
            // Mozos
            // 
            Mozos.HeaderText = "Mozos";
            Mozos.Name = "Mozos";
            // 
            // Comidas
            // 
            Comidas.HeaderText = "Comidas";
            Comidas.MinimumWidth = 6;
            Comidas.Name = "Comidas";
            Comidas.Width = 125;
            // 
            // BebidasSinAlcohol
            // 
            BebidasSinAlcohol.HeaderText = "Bebidas sin alcohol";
            BebidasSinAlcohol.MinimumWidth = 6;
            BebidasSinAlcohol.Name = "BebidasSinAlcohol";
            BebidasSinAlcohol.Width = 125;
            // 
            // BebidasConAlcohol
            // 
            BebidasConAlcohol.HeaderText = "Bebidas con alcohol";
            BebidasConAlcohol.MinimumWidth = 6;
            BebidasConAlcohol.Name = "BebidasConAlcohol";
            BebidasConAlcohol.Width = 125;
            // 
            // Postres
            // 
            Postres.HeaderText = "Postres";
            Postres.MinimumWidth = 6;
            Postres.Name = "Postres";
            Postres.Width = 125;
            // 
            // btnValidarDatos
            // 
            btnValidarDatos.Location = new Point(662, 128);
            btnValidarDatos.Margin = new Padding(3, 2, 3, 2);
            btnValidarDatos.Name = "btnValidarDatos";
            btnValidarDatos.Size = new Size(123, 29);
            btnValidarDatos.TabIndex = 1;
            btnValidarDatos.Text = "Validar Datos";
            btnValidarDatos.UseVisualStyleBackColor = true;
            btnValidarDatos.Click += btnValidarDatos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(548, 230);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(108, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMozoDelDia
            // 
            btnMozoDelDia.Enabled = false;
            btnMozoDelDia.Location = new Point(12, 161);
            btnMozoDelDia.Margin = new Padding(3, 2, 3, 2);
            btnMozoDelDia.Name = "btnMozoDelDia";
            btnMozoDelDia.Size = new Size(123, 29);
            btnMozoDelDia.TabIndex = 3;
            btnMozoDelDia.Text = "Mozo del dia";
            btnMozoDelDia.UseVisualStyleBackColor = true;
            // 
            // btnTotales
            // 
            btnTotales.Enabled = false;
            btnTotales.Location = new Point(12, 224);
            btnTotales.Margin = new Padding(3, 2, 3, 2);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(123, 29);
            btnTotales.TabIndex = 4;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            // 
            // lblResultadoMozoDelDia
            // 
            lblResultadoMozoDelDia.AutoSize = true;
            lblResultadoMozoDelDia.Location = new Point(152, 168);
            lblResultadoMozoDelDia.Name = "lblResultadoMozoDelDia";
            lblResultadoMozoDelDia.Size = new Size(123, 15);
            lblResultadoMozoDelDia.TabIndex = 5;
            lblResultadoMozoDelDia.Text = "ResultadoMozoDelDia";
            // 
            // lblResultadoTotales
            // 
            lblResultadoTotales.AutoSize = true;
            lblResultadoTotales.Location = new Point(152, 230);
            lblResultadoTotales.Name = "lblResultadoTotales";
            lblResultadoTotales.Size = new Size(95, 15);
            lblResultadoTotales.TabIndex = 6;
            lblResultadoTotales.Text = "ResultadoTotales";
            // 
            // frmLaMilanga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 279);
            Controls.Add(lblResultadoTotales);
            Controls.Add(lblResultadoMozoDelDia);
            Controls.Add(btnTotales);
            Controls.Add(btnMozoDelDia);
            Controls.Add(btnSalir);
            Controls.Add(btnValidarDatos);
            Controls.Add(dgvVentas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLaMilanga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "La Milanga";
            Load += frmLaMilanga_Load;
            KeyPress += frmLaMilanga_KeyPress;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private Button btnValidarDatos;
        private Button btnSalir;
        private Button btnMozoDelDia;
        private Button btnTotales;
        private Label lblResultadoMozoDelDia;
        private Label lblResultadoTotales;
        private DataGridViewTextBoxColumn Mozos;
        private DataGridViewTextBoxColumn Comidas;
        private DataGridViewTextBoxColumn BebidasSinAlcohol;
        private DataGridViewTextBoxColumn BebidasConAlcohol;
        private DataGridViewTextBoxColumn Postres;
    }
}
