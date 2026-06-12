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
    public partial class frmListado : Form
    {

        public frmListado()
        {
            InitializeComponent();

            cboPlan.DataSource = null;
            cboPlan.DataSource = frmRegistroPlan.listaPlan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvListado.Rows.Clear();
            string buscarNombre = txtNombre.Text.ToLower();
            string buscarCodigo = mskCode.Text;
            string buscarPlan = Convert.ToString(cboPlan.Text);

            if (rdbTodos.Checked)
            {
                for (int i = 0; i < frmRegistro.lista.GetLength(0); i++)
                {
                    if (frmRegistro.lista[i, 0] != null)
                    {
                        dgvListado.Rows.Add(
                        frmRegistro.lista[i, 0],
                        frmRegistro.lista[i, 1],
                        frmRegistro.lista[i, 2],
                        frmRegistro.lista[i, 3]
                        );
                    }
                }
            }

            if (rdbNombre.Checked)
            {
                bool flag = false;

                for (int i = 0; i < frmRegistro.lista.GetLength(0); i++)
                {
                    if (frmRegistro.lista[i, 1] != null && frmRegistro.lista[i, 1].ToLower() == buscarNombre)
                    {
                        dgvListado.Rows.Add(
                        frmRegistro.lista[i, 0],
                        frmRegistro.lista[i, 1],
                        frmRegistro.lista[i, 2],
                        frmRegistro.lista[i, 3]
                        );

                        flag = true;
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("No se encontró el nombre ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                }
            }

            if (rdbCode.Checked)
            {
                bool flag = false;

                for (int i = 0; i < frmRegistro.lista.GetLength(0); i++)
                {
                    if (frmRegistro.lista[i, 0] != null && frmRegistro.lista[i, 0] == buscarCodigo)
                    {
                        dgvListado.Rows.Add(
                        frmRegistro.lista[i, 0],
                        frmRegistro.lista[i, 1],
                        frmRegistro.lista[i, 2],
                        frmRegistro.lista[i, 3]
                        );

                        flag = true;
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("No se encontró el código ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskCode.Focus();
                }
            }

            if (rdbPlan.Checked)
            {
                bool flag = false;

                for (int i = 0; i < frmRegistro.lista.GetLength(0); i++)
                {
                    if (frmRegistro.lista[i, 2] != null && frmRegistro.lista[i, 2] == buscarPlan)
                    {
                        dgvListado.Rows.Add(
                        frmRegistro.lista[i, 0],
                        frmRegistro.lista[i, 1],
                        frmRegistro.lista[i, 2],
                        frmRegistro.lista[i, 3]
                        );

                        flag = true;
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("Seleccione un plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboPlan.Focus();
                }
            }

            txtNombre.Focus();
            txtNombre.Clear();
            mskCode.Clear();
            cboPlan.SelectedIndex = -1;
        }
            

        private void frmListado_Load(object sender, EventArgs e)
        {
            cboPlan.DataSource = null;
            cboPlan.DataSource = frmRegistroPlan.listaPlan;
            cboPlan.SelectedIndex = -1;
        }

        private void cboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
