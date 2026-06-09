using System;
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
        string[,] arrAlumno = new string[2, 6];

        public frmAlumno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrAlumno.GetLength(0); i++)
            {
                if (txtDni.Text == "")
                {
                    MessageBox.Show("Ingrese un DNI");
                    txtDni.Focus();
                    return;
                }
                if (txtNombre.Text != "")
                {
                    MessageBox.Show("Ingrese un nombre");
                    txtNombre.Focus();
                    return;
                }
                if (txtApellido.Text == "")
                {
                    MessageBox.Show("Ingrese un apellido");
                    txtApellido.Focus();
                    return;
                }
                if (txtDireccion.Text == "")
                {
                    MessageBox.Show("Ingrese una dirección");
                    txtDireccion.Focus();
                    return;
                }
                if (txtContacto.Text.ToString() == "")
                {
                    MessageBox.Show("Ingrese un teléfono");
                    txtContacto.Focus();
                    return;
                }
                if (dtpFechaNacimiento.Value == null)
                {
                    MessageBox.Show("Ingrese una fecha de nacimiento");
                    dtpFechaNacimiento.Focus();
                    return;
                }

                arrAlumno[indiceFila, 0] = txtDni.Text;
                arrAlumno[indiceFila, 1] = txtNombre.Text;
                arrAlumno[indiceFila, 2] = txtApellido.Text;
                arrAlumno[indiceFila, 3] = txtDireccion.Text;
                arrAlumno[indiceFila, 4] = txtContacto.Text;
                arrAlumno[indiceFila, 5] = dtpFechaNacimiento.Value.ToString("dd/MM/yyyy");

                indiceFila++;
            }
        }
    }
}
