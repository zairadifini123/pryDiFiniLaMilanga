namespace pryDiFiniLaMilanga
{
    public partial class frmLaMilanga : Form
    {
        public frmLaMilanga()
        {
            InitializeComponent();
        }

        private void frmLaMilanga_Load(object sender, EventArgs e)
        {
            string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };

            // Agregar filas vacías
            foreach (string mozo in mozos)
            {
                dgvVentas.Rows.Add(0, 0, 0, 0); // 4 columnas inicializadas en 0
            }

            // Poner los nombres de los mozos en los encabezados de fila
            for (int i = 0; i < mozos.Length; i++)
            {
                dgvVentas.Rows[i].HeaderCell.Value = mozos[i];
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidarDatos_Click(object sender, EventArgs e)
        {
            bool DatosValidos = true;

            // Recorro filas
            for (int i = 0; i < dgvVentas.Rows.Count; i++)
            {
                // Recorro columnas
                for (int j = 0; j < dgvVentas.Columns.Count; j++)
                {
                    string valor = dgvVentas.Rows[i].Cells[j].Value?.ToString() ?? "0";

                    // Intento convertir a número
                    try
                    {
                        float num = Convert.ToSingle(valor);
                    }
                    catch
                    {
                        // Si da error, hay algo mal
                        DatosValidos = false;
                    }
                }
            }

            if (DatosValidos)
            {
                MessageBox.Show("Todos los datos están correctos");
                btnMozoDelDia.Enabled = true;
                btnTotales.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error: hay celdas que no son números");
                btnMozoDelDia.Enabled = false;
                btnTotales.Enabled = false;
            }
        }

        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {
            int MozoMayor = 0;
            int ImporteMayor = 0;

            for (int i = 0; i < dgvVentas.Rows.Count; i++)
            {
                // Ignorar fila de nueva entrada
                if (dgvVentas.Rows[i].IsNewRow) continue;

                int Acumulador = 0;

                // Recorro columnas
                for (int j = 0; j < dgvVentas.Columns.Count; j++)
                {
                    int valor = 0;

                    // Convertir de forma segura
                    if (dgvVentas.Rows[i].Cells[j].Value != null &&
                        int.TryParse(dgvVentas.Rows[i].Cells[j].Value.ToString(), out int temp))
                    {
                        valor = temp;
                    }

                    Acumulador += valor;
                }

                // Ver cuál mozo tiene el mayor total
                if (Acumulador > ImporteMayor)
                {
                    ImporteMayor = Acumulador;
                    MozoMayor = i;
                }
            }
            string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };

            lblResultadoMozoDelDia.Text = "Mozo del día: " + mozos[MozoMayor] +
                              " - Importe $: " + ImporteMayor.ToString();
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            int totalComidas = 0;
            int totalBebidasSin = 0;
            int totalBebidasCon = 0;
            int totalPostres = 0;
            int totalGeneral = 0;

            for (int i = 0; i < dgvVentas.Rows.Count; i++)
            {
                totalComidas += int.Parse(dgvVentas.Rows[i].Cells[0].Value?.ToString() ?? "0");
                totalBebidasSin += int.Parse(dgvVentas.Rows[i].Cells[1].Value?.ToString() ?? "0");
                totalBebidasCon += int.Parse(dgvVentas.Rows[i].Cells[2].Value?.ToString() ?? "0");
                totalPostres += int.Parse(dgvVentas.Rows[i].Cells[3].Value?.ToString() ?? "0");
            }

            totalGeneral = totalComidas + totalBebidasSin + totalBebidasCon + totalPostres;

            lblResultadoTotales.Text = "Total Comidas: " + totalComidas + "\n" +
                                       "Total Bebidas sin alcohol: " + totalBebidasSin + "\n" +
                                       "Total Bebidas con alcohol: " + totalBebidasCon + "\n" +
                                       "Total Postres: " + totalPostres + "\n" +
                                       "Total General: " + totalGeneral;
        }
    }
}
