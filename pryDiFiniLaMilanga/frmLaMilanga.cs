namespace pryDiFiniLaMilanga
{
    public partial class frmLaMilanga : Form
    {
        public frmLaMilanga()
        {
            InitializeComponent();
        }

        float[,] matVentas = new float[6, 5];
        string[] nombres = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
        int FilaActual = 5; // cantidad de mozos cargados

        private void frmLaMilanga_Load(object sender, EventArgs e)
        {
            dgvVentas.Rows.Add("Julio");
            dgvVentas.Rows.Add("Esteban");
            dgvVentas.Rows.Add("Javier");
            dgvVentas.Rows.Add("Gonzalo");
            dgvVentas.Rows.Add("Alberto");

            dgvVentas.Columns[0].ReadOnly = true;

            dgvVentas.Rows[0].Cells[0].Selected = false;
            dgvVentas.Rows[0].Cells[1].Selected = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnValidarDatos_Click(object sender, EventArgs e)
        {
            for (int indiceFilas = 0; indiceFilas < dgvVentas.Rows.Count; indiceFilas++)
            {
                for (int indiceColumnas = 1; indiceColumnas < dgvVentas.Columns.Count; indiceColumnas++)
                {
                    if (dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value != null)
                    {
                        float contenidoCelda =
                            float.Parse(dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value.ToString());

                        // la validación original no existe, pero ya es float, así que marcamos como "si"
                        dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value = "si";

                        matVentas[indiceFilas, indiceColumnas - 1] = contenidoCelda; // guardamos en la matriz
                    }
                }
            }

            btnMozoDelDia.Enabled = true;
        }

        private void frmLaMilanga_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {
            string valorMayor = "";
            float importeMayor = 0;

            for (int i = 0; i < FilaActual; i++)
            {
                float sumaFila = 0;
                for (int j = 0; j < 4; j++) // sumamos todas las columnas de ventas
                {
                    sumaFila += matVentas[i, j];
                }

                if (sumaFila > importeMayor)
                {
                    importeMayor = sumaFila;
                    valorMayor = nombres[i];
                }
            }

            lblResultadoMozoDelDia.Text = valorMayor + " - " + importeMayor.ToString("C");
            btnTotales.Enabled = true;
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            float totalGeneral = 0;
            float totalCategoria1 = 0;
            float totalCategoria2 = 0;
            float totalCategoria3 = 0;
            float totalCategoria4 = 0;

            for (int fila = 0; fila < FilaActual; fila++)
            {
                totalCategoria1 += matVentas[fila, 0];
                totalCategoria2 += matVentas[fila, 1];
                totalCategoria3 += matVentas[fila, 2];
                totalCategoria4 += matVentas[fila, 3];

                totalGeneral += matVentas[fila, 0] + matVentas[fila, 1] + matVentas[fila, 2] + matVentas[fila, 3];
            }

            lblResultadoTotales.Text =
                "Total General: " + totalGeneral.ToString("C") + "\n" +
                "Comidas: " + totalCategoria1.ToString("C") + "\n" +
                "Bebidas sin alcohol: " + totalCategoria2.ToString("C") + "\n" +
                "Bebidas con alcohol: " + totalCategoria3.ToString("C") + "\n" +
                "Postres: " + totalCategoria4.ToString("C");

        }
    }
}

