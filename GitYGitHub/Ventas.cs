using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitYGitHub
{
    public partial class Ventas : Form
    {

        Dictionary<string, double> precios = new Dictionary<string, double>();

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            // Productos en el DomainUpDown
            DUDProducto.Items.Add("Tractor");
            DUDProducto.Items.Add("Motobomba");
            DUDProducto.Items.Add("Fumigadora");
            DUDProducto.Items.Add("Arado");

            DUDProducto.Text = "Tractor";

            // Precios
            precios.Add("Tractor", 25000);
            precios.Add("Motobomba", 1200);
            precios.Add("Fumigadora", 850);
            precios.Add("Arado", 3000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string producto = DUDProducto.Text;
            int cantidad = (int)NUDCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida");
                return;
            }

            double precioTotal = precios[producto] * cantidad;

            dgvCarrito.Rows.Add(producto, cantidad, precioTotal);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            string producto = DUDProducto.Text;
            int nuevaCantidad = (int)NUDCantidad.Value;

            foreach (DataGridViewRow fila in dgvCarrito.Rows)
            {
                if (fila.Cells[0].Value != null &&
                    fila.Cells[0].Value.ToString() == producto)
                {
                    // Si cantidad = 0 elimina producto
                    if (nuevaCantidad == 0)
                    {
                        dgvCarrito.Rows.Remove(fila);
                        return;
                    }

                    // Actualizar cantidad
                    fila.Cells[1].Value = nuevaCantidad;

                    // Actualizar precio
                    double nuevoPrecio = precios[producto] * nuevaCantidad;
                    fila.Cells[2].Value = nuevoPrecio;

                    return;
                }
            }

            MessageBox.Show("Producto no encontrado en el carrito");
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            bool hayProductos = false;

            foreach (DataGridViewRow fila in dgvCarrito.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    hayProductos = true;
                    break;
                }
            }

            // Verificar productos
            if (!hayProductos)
            {
                MessageBox.Show("Debe agregar al menos 1 artículo");
                return;
            }

            Random rnd = new Random();

            VentaInfo venta = new VentaInfo()
            {
                Codigo = rnd.Next(1000, 9999),
                Fecha = DateTime.Now.ToShortDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            string boleta = "";

            boleta += "=========== BOLETA ===========" + Environment.NewLine;
            boleta += "Código: " + venta.Codigo + Environment.NewLine;
            boleta += "Fecha: " + venta.Fecha + Environment.NewLine;
            boleta += "Hora: " + venta.Hora + Environment.NewLine;
            boleta += Environment.NewLine;

            boleta += "Cant.     Producto               Precio" + Environment.NewLine;
            boleta += "----------------------------------------" + Environment.NewLine;

            double total = 0;

            foreach (DataGridViewRow fila in dgvCarrito.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    string producto = fila.Cells[0].Value.ToString();

                    int cantidad = Convert.ToInt32(
                        fila.Cells[1].Value
                    );

                    double precio = Convert.ToDouble(
                        fila.Cells[2].Value
                    );

                    total += precio;

                    // Guardar productos de la venta
                    venta.Productos.Add(new ProductoVenta()
                    {
                        Producto = producto,
                        Cantidad = cantidad,
                        Precio = precio
                    });

                    boleta += cantidad.ToString().PadRight(10) +
                               producto.PadRight(22) +
                               "S/. " + precio +
                               Environment.NewLine;
                }
            }

            venta.Total = total;

            DatosVentas.ventas.Add(venta);

            boleta += Environment.NewLine;
            boleta += "TOTAL: S/. " + total;

            MessageBox.Show(boleta, "Venta Registrada");

            dgvCarrito.Rows.Clear();
        }
    }
}
