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
        string[] planes;
        

        public string[,] devolverRegistro()
        {
            return lista;
        }

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
            frmRegistro registro = new frmRegistro();
            this.Close();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado listado = new frmListado(lista, planes);
            listado.ShowDialog();
        }

        private void btnRegistrarPlan_Click(object sender, EventArgs e)
        {
            frmRegistroPlan plan = new frmRegistroPlan();
            plan.ShowDialog();
            string[] planesRecibidos = plan.devolverPlanes();

            if (planes == null)
            {
                planes = planesRecibidos;
            }
            else
            {
                planes = planes.Concat(planesRecibidos).ToArray();
            }

            cboPlan.DataSource = null;
            cboPlan.DataSource = planes;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(mskCode.Text) == "")
            {
                MessageBox.Show("Debes ingresar el código", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                mskCode.Focus();
                return;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debes ingresar un nombre", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtNombre.Focus();
                return;
            }
            if (cboPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Debes elegir un plan", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

            if (indiceFila >= lista.GetLength(0))
            {
                MessageBox.Show("No se pueden ingresar más datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            lista[indiceFila, 0] = Convert.ToString(mskCode.Text);
            lista[indiceFila, 1] = txtNombre.Text;
            lista[indiceFila, 2] = cboPlan.Text;
            lista[indiceFila, 3] = estado;

            indiceFila++;

            MessageBox.Show("Código: " + mskCode.Text + "\nNombre: " + txtNombre.Text + "\nPlan: " + cboPlan.Text + "\nEstado: " + estado, "Registro Materia", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mskCode.Clear();
            cboPlan.SelectedIndex = -1;
            txtNombre.Clear();
            mskCode.Focus();
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void mskCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
