using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitYGitHub
{
    public partial class ListaVentas : Form
    {
        public ListaVentas()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void ListaVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.Rows.Clear();

            foreach (VentaInfo venta in DatosVentas.ventas)
            {
                dgvVentas.Rows.Add(
                    venta.Codigo,
                    venta.Fecha,
                    venta.Hora
                );
            }
        }

        private void btn_Ver_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una venta");
                return;
            }

            int codigo = Convert.ToInt32(
                dgvVentas.SelectedRows[0].Cells[0].Value
            );

            foreach (VentaInfo venta in DatosVentas.ventas)
            {
                if (venta.Codigo == codigo)
                {
                    ListaUnica unica = new ListaUnica(venta);
                    unica.Show();
                    this.Hide();
                    return;
                }
            }
        }
    }
}
