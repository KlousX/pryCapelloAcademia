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

        string[,] lista;
        string[] planes;

        public frmListado()
        {
            InitializeComponent();
        }

        public frmListado(string[,] lista, string[] planesRecibidos)
        {
            InitializeComponent();
            this.lista = lista;
            this.planes = planesRecibidos;

            cboPlan.DataSource = null;
            cboPlan.DataSource = planes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvListado.Rows.Clear();
            string buscarNombre = txtNombre.Text.ToLower();
            string buscarCodigo = mskCode.Text;
            string buscarPlan = Convert.ToString(cboPlan.Text);

            if (rdbTodos.Checked)
            {
                for (int i = 0; i < lista.GetLength(0); i++)
                {
                    if (lista[i, 0] != null)
                    {
                        dgvListado.Rows.Add(
                        lista[i, 0],
                        lista[i, 1],
                        lista[i, 2],
                        lista[i, 3]
                        );
                    }
                }
            }

            if (rdbNombre.Checked)
            {
                bool flag = false;

                for (int i = 0; i < lista.GetLength(0); i++)
                {
                    if (lista[i, 1] != null && lista[i, 1].ToLower() == buscarNombre)
                    { 
                        dgvListado.Rows.Add(
                        lista[i, 0],
                        lista[i, 1],
                        lista[i, 2],
                        lista[i, 3]
                        );
                        
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("No se encontró el nombre ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (rdbCode.Checked)
            {
                bool flag = false;

                for (int i = 0; i < lista.GetLength(0); i++)
                {
                    if (lista[i, 0] != null && lista[i, 0] == buscarCodigo)
                    { 
                        dgvListado.Rows.Add(
                        lista[i, 0],
                        lista[i, 1],
                        lista[i, 2],
                        lista[i, 3]
                        );

                        flag = true;
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("No se encontró el código ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (rdbPlan.Checked)
            {
                for (int i = 0; i < lista.GetLength(0); i++)
                {
                    if (lista[i, 2] != null && lista[i, 2] == buscarPlan)
                    {
                        dgvListado.Rows.Add(
                        lista[i, 0],
                        lista[i, 1],
                        lista[i, 2],
                        lista[i, 3]
                        );
                    }
                }
            }

            txtNombre.Focus();
            txtNombre.Clear();
            mskCode.Clear();
            cboPlan.SelectedIndex = -1;
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            cboPlan.SelectedIndex = -1;
        }
    }
}
