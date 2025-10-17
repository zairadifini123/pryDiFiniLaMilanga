namespace pryDiFiniLaMilanga
{
    public partial class frmLaMilanga : Form
    {
        public frmLaMilanga()
        {
            InitializeComponent();
        }

        float[,] matVentas = new float[6, 5];
        float[,] matImportes = new float[4, 3];
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

                        if (float.IsRealNumber(contenidoCelda))
                        {
                            dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value = "si";
                        }
                        else
                        {
                            dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value = "no";

                        }

                    }
                }

            }

        }

        private void frmLaMilanga_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
