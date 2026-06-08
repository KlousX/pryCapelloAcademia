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
    public partial class frmRegistroPlan : Form
    {

        string[] listaPlan = new string[3];
        int currentRow = 0;

        public string[] devolverPlanes()
        {
            string[] resultado = new string[currentRow];

            for (int i = 0; i < currentRow; i++)
            {
                resultado[i] = listaPlan[i];
            }

            return resultado;
        }

        public frmRegistroPlan()
        {
            InitializeComponent();
        }

        private void btnAgregarPlan_Click(object sender, EventArgs e)
        {
            if (currentRow >= listaPlan.Length)
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

            listaPlan[currentRow] = txtPlan.Text;
            currentRow++;
            listPlanes.Items.Add(txtPlan.Text);
            

            txtPlan.Clear();
            txtPlan.Focus();
        }


        private void frmRegistroPlan_Load(object sender, EventArgs e)
        {
            
        }

        private void txtPlan_TextChanged(object sender, EventArgs e)
        {

        }

        private void listPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
