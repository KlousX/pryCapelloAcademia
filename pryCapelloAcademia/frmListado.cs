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

        public frmListado()
        {
            InitializeComponent();
        }

        public frmListado(string[,] lista)
        {
            InitializeComponent();
            this.lista = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvListado.Rows.Clear();
            string buscarNombre = txtNombre.Text.ToLower();
            string buscarCodigo = Convert.ToString(mskCode.Text);
            string buscarPlan = Convert.ToString(cboPlan.Text);

            if (rdbTodos.Checked)
            {
                for (int i = 0; i < lista.GetLength(0); i++)
                {
                    dgvListado.Rows.Add(
                        lista[i, 0],
                        lista[i, 1],
                        lista[i, 2],
                        lista[i, 3]
                        );
                }
            }
            if (rdbNombre.Checked)
            {
                for (int i = 0; i < lista.GetLength(0); i++)
                {
                    if (lista[i, 1].ToLower() == buscarNombre)
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
            if (rdbCode.Checked)
            {
                for (int i = 0; i < lista.GetLength(0); i++)
                {
                    if (lista[i, 2] == buscarCodigo)
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
            if (rdbPlan.Checked)
            {
                for (int i = 0; i < lista.GetLength(0); i++)
                {
                    if (lista[i, 3] == buscarPlan)
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
        }
    }
}
