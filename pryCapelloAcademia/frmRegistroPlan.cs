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
    public partial class frmRegistroPlan : Form
    {

        string[,] listaPlan = new string[3, 1];
        int currentRow = 0;

        public string[,] devolverPlanes()
        {
            return listaPlan;
        }

        public frmRegistroPlan()
        {
            InitializeComponent();
        }

        private void btnAgregarPlan_Click(object sender, EventArgs e)
        {
            if (currentRow >= 3)
            {
                MessageBox.Show("No hay más espacio");
                return;
            }

            if (txtPlan.Text == "")
            {
                MessageBox.Show("Debes poner un nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtPlan.Focus();
                return;
            }
            
            listaPlan[currentRow, 0] = txtPlan.Text;
            currentRow++;
            
            txtPlan.Clear();
            txtPlan.Focus();
        }

        private void bntListado_Click(object sender, EventArgs e)
        {
            string datos = "";

            for (int i = 0; i < listaPlan.GetLength(0); i++)
            {
                datos = datos + listaPlan[i, 0] + "\n";
            }
            
            MessageBox.Show(datos, "Listado");
        }

        private void frmRegistroPlan_Load(object sender, EventArgs e)
        {

        }

        private void txtPlan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
