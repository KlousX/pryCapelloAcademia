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
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debes ingresar un nombre");
                txtNombre.Focus();
            }
            if (cboPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Debes elegir un plan");
                cboPlan.Focus();
            }

            mskCode.Clear();
            cboPlan.SelectedIndex = -1;
            txtNombre.Clear();

            MessageBox.Show("Código: " + mskCode.Text + "\nNombre: " + txtNombre.Text + "\nPlan: " + cboPlan.SelectedIndex, "Registro Materia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
