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
            float ImporteMayor = 0;

            for (int i = 0; i < dgvVentas.Rows.Count; i++)
            {
                // Ignorar fila de nueva entrada
                if (dgvVentas.Rows[i].IsNewRow) continue;

                float Acumulador = 0;

                // Recorro columnas
                for (int j = 0; j < dgvVentas.Columns.Count; j++)
                {
                    float valor = 0;

                    // Convertir de forma segura usando float
                    if (dgvVentas.Rows[i].Cells[j].Value != null &&
                        float.TryParse(dgvVentas.Rows[i].Cells[j].Value.ToString(), out float temp))
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

            // Nombres de los mozos
            string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };

            // Mostrar resultado en un solo Label
            lblResultadoMozoDelDia.Text = "Mozo del día: " + mozos[MozoMayor] +
                                          "\nImporte $: " + ImporteMayor.ToString("0.00");
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            float totalComidas = 0;
            float totalBebidasSin = 0;
            float totalBebidasCon = 0;
            float totalPostres = 0;
            float totalGeneral = 0;

            for (int i = 0; i < dgvVentas.Rows.Count; i++)
            {
                // Ignorar fila de nueva entrada
                if (dgvVentas.Rows[i].IsNewRow) continue;

                // Comidas
                if (dgvVentas.Rows[i].Cells[0].Value != null &&
                    float.TryParse(dgvVentas.Rows[i].Cells[0].Value.ToString(), out float tempCom))
                {
                    totalComidas += tempCom;
                }

                // Bebidas sin alcohol
                if (dgvVentas.Rows[i].Cells[1].Value != null &&
                    float.TryParse(dgvVentas.Rows[i].Cells[1].Value.ToString(), out float tempBS))
                {
                    totalBebidasSin += tempBS;
                }

                // Bebidas con alcohol
                if (dgvVentas.Rows[i].Cells[2].Value != null &&
                    float.TryParse(dgvVentas.Rows[i].Cells[2].Value.ToString(), out float tempBC))
                {
                    totalBebidasCon += tempBC;
                }

                // Postres
                if (dgvVentas.Rows[i].Cells[3].Value != null &&
                    float.TryParse(dgvVentas.Rows[i].Cells[3].Value.ToString(), out float tempP))
                {
                    totalPostres += tempP;
                }
            }

            // Total general
            totalGeneral = totalComidas + totalBebidasSin + totalBebidasCon + totalPostres;

            // Mostrar en un solo Label, uno debajo del otro
            lblResultadoTotales.Text = "Total Comidas: " + totalComidas.ToString("0.00") + "\n" +
                                       "Total Bebidas sin alcohol: " + totalBebidasSin.ToString("0.00") + "\n" +
                                       "Total Bebidas con alcohol: " + totalBebidasCon.ToString("0.00") + "\n" +
                                       "Total Postres: " + totalPostres.ToString("0.00") + "\n" +
                                       "Total General: " + totalGeneral.ToString("0.00");

        }
    }
}
