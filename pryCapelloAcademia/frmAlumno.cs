using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCapelloAcademia
{
    public partial class frmAlumno : Form
    {

        int indiceFila = 0;
        int filaSeleccionada = -1;
        string[,] arrAlumno = new string[2, 8];


        public frmAlumno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (indiceFila >= arrAlumno.GetLength(0))
            {
                MessageBox.Show("No se pueden añadir más datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtDni.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtDireccion.Clear();
                txtContacto.Clear();
                return;
            }

            arrAlumno[indiceFila, 7] = "";
            lblActualizacionXX.Text = "";
            dgvAlumnos.Rows.Clear();

            if (txtDni.Text == "")
            {
                MessageBox.Show("Ingrese un DNI", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtDni.Focus();
                return;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtNombre.Focus();
                return;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese un apellido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtApellido.Focus();
                return;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Ingrese una dirección", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtDireccion.Focus();
                return;
            }
            if (txtContacto.Text.ToString() == "")
            {
                MessageBox.Show("Ingrese un teléfono", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtContacto.Focus();
                return;
            }
            if (dtpFechaNacimiento.Value == null)
            {
                MessageBox.Show("Ingrese una fecha de nacimiento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                dtpFechaNacimiento.Focus();
                return;
            }

            arrAlumno[indiceFila, 0] = txtDni.Text;
            arrAlumno[indiceFila, 1] = txtNombre.Text;
            arrAlumno[indiceFila, 2] = txtApellido.Text;
            arrAlumno[indiceFila, 3] = txtDireccion.Text;
            arrAlumno[indiceFila, 4] = txtContacto.Text;
            arrAlumno[indiceFila, 5] = dtpFechaNacimiento.Value.ToString("dd/MM/yyyy");

            for (int i = 0; i < arrAlumno.GetLength(0); i++)
            {
                if (arrAlumno[i, 0] != null)
                {
                    dgvAlumnos.Rows.Add(
                        arrAlumno[i, 0],
                        arrAlumno[i, 1],
                        arrAlumno[i, 2],
                        arrAlumno[i, 3],
                        arrAlumno[i, 4],
                        arrAlumno[i, 5]
                        );
                }

            }

            txtDni.Focus();
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtContacto.Clear();

            arrAlumno[indiceFila, 6] = DateTime.Now.ToString("dd/MM/yy HH:mm");
            lblRegistroXX.Text = arrAlumno[indiceFila, 6];

            indiceFila++;
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            filaSeleccionada = e.RowIndex;

            if (filaSeleccionada >= indiceFila || filaSeleccionada >= arrAlumno.GetLength(0))
            {
                return;
            }

            txtDni.Text = arrAlumno[filaSeleccionada, 0];
            txtNombre.Text = arrAlumno[filaSeleccionada, 1];
            txtApellido.Text = arrAlumno[filaSeleccionada, 2];
            txtDireccion.Text = arrAlumno[filaSeleccionada, 3];
            txtContacto.Text = arrAlumno[filaSeleccionada, 4];
            dtpFechaNacimiento.Value = DateTime.Parse(arrAlumno[filaSeleccionada, 5]);

            arrAlumno[filaSeleccionada, 7] = DateTime.Now.ToString("dd/MM/yy HH:mm");
            lblActualizacionXX.Text = arrAlumno[filaSeleccionada, 7];
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (filaSeleccionada == -1)
            {
                MessageBox.Show("Seleccione un alumno para editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            dgvAlumnos.Rows.Clear();

            arrAlumno[filaSeleccionada, 0] = txtDni.Text;
            arrAlumno[filaSeleccionada, 1] = txtNombre.Text;
            arrAlumno[filaSeleccionada, 2] = txtApellido.Text;
            arrAlumno[filaSeleccionada, 3] = txtDireccion.Text;
            arrAlumno[filaSeleccionada, 4] = txtContacto.Text;
            arrAlumno[filaSeleccionada, 5] = dtpFechaNacimiento.Value.ToString("dd/MM/yyyy");
            arrAlumno[filaSeleccionada, 7] = DateTime.Now.ToString("dd/MM/yy HH:mm");
            lblActualizacionXX.Text = arrAlumno[filaSeleccionada, 7];

            for (int i = 0; i < arrAlumno.GetLength(0); i++)
            {
                if (arrAlumno[i, 0] != null)
                {
                    dgvAlumnos.Rows.Add(
                        arrAlumno[i, 0],
                        arrAlumno[i, 1],
                        arrAlumno[i, 2],
                        arrAlumno[i, 3],
                        arrAlumno[i, 4],
                        arrAlumno[i, 5]
                    );
                }
            }

            txtDni.Focus();
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtContacto.Clear();

            filaSeleccionada = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (filaSeleccionada == -1)
            {
                MessageBox.Show("Seleccione un alumno para eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            for (int i = filaSeleccionada; i < indiceFila - 1; i++)
            {
                arrAlumno[i, 0] = arrAlumno[i + 1, 0];
                arrAlumno[i, 1] = arrAlumno[i + 1, 1];
                arrAlumno[i, 2] = arrAlumno[i + 1, 2];
                arrAlumno[i, 3] = arrAlumno[i + 1, 3];
                arrAlumno[i, 4] = arrAlumno[i + 1, 4];
                arrAlumno[i, 5] = arrAlumno[i + 1, 5];
                arrAlumno[i, 6] = arrAlumno[i + 1, 6];
                arrAlumno[i, 7] = arrAlumno[i + 1, 7];
            }

            indiceFila--;

            arrAlumno[indiceFila, 0] = null;
            arrAlumno[indiceFila, 1] = null;
            arrAlumno[indiceFila, 2] = null;
            arrAlumno[indiceFila, 3] = null;
            arrAlumno[indiceFila, 4] = null;
            arrAlumno[indiceFila, 5] = null;
            arrAlumno[indiceFila, 6] = null;
            arrAlumno[indiceFila, 7] = null;

            dgvAlumnos.Rows.Clear();

            for (int i = 0; i < arrAlumno.GetLength(0); i++)
            {
                if (arrAlumno[i, 0] != null)
                {
                    dgvAlumnos.Rows.Add(
                        arrAlumno[i, 0],
                        arrAlumno[i, 1],
                        arrAlumno[i, 2],
                        arrAlumno[i, 3],
                        arrAlumno[i, 4],
                        arrAlumno[i, 5]
                        );
                }
            }


            txtDni.Focus();
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtContacto.Clear();
            lblActualizacionXX.Text = "";
            lblRegistroXX.Text = "";

            filaSeleccionada = -1;

            MessageBox.Show("Alumno eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
