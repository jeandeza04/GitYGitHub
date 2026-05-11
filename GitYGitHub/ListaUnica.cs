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
    public partial class ListaUnica : Form
    {

        VentaInfo ventaActual;

        public ListaUnica(VentaInfo venta)
        {
            InitializeComponent();
            ventaActual = venta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaVentas menu = new ListaVentas();
            menu.Show();
            this.Close();
        }

        private void ListaUnica_Load(object sender, EventArgs e)
        {
            dgvBoleta.Rows.Clear();

            foreach (ProductoVenta producto in ventaActual.Productos)
            {
                dgvBoleta.Rows.Add(
                    producto.Cantidad,
                    producto.Producto,
                    producto.Precio
                );
            }

            lbTotal.Text = "TOTAL: S/. " + ventaActual.Total;
        }
    }
}
