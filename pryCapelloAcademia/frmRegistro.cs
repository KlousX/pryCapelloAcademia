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
    public partial class frmRegistro : Form
    {
        string estado;
        int indiceFila = 0;
        string[,] lista = new string[2, 4];

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnListado_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(mskCode.Text) == "")
            {
                MessageBox.Show("Debes ingresar el código");
                mskCode.Focus();
                return;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debes ingresar un nombre");
                txtNombre.Focus();
                return;
            }
            if (cboPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Debes elegir un plan");
                cboPlan.Focus();
                return;
            }
            if (chkActivo.Checked == true)
            {
                estado = "Activo";
            }
            else
            {
                estado = "Inactivo";
            }


            lista[indiceFila, 0] = Convert.ToString(mskCode.Text);
            lista[indiceFila, 1] = txtNombre.Text;
            lista[indiceFila, 2] = Convert.ToString(cboPlan.SelectedIndex);
            lista[indiceFila, 3] = estado;

            indiceFila++;

            MessageBox.Show("Código: " + mskCode.Text + "\nNombre: " + txtNombre.Text + "\nPlan: " + ToString(cboPlan.SelectedIndex) + "\nEstado: " + estado, "Registro Materia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            mskCode.Clear();
            cboPlan.SelectedIndex = -1;
            txtNombre.Clear();
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
