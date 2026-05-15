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
    public partial class Vendedor : Form
    {
        public Vendedor()
        {
            InitializeComponent();
            this.FormClosed += Vendedor_FormClosed;
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();

            ventas.FormClosed += (s, args) => this.Show();

            ventas.Show();
            this.Hide();
        }
    

        private void btn_Almacen_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();

            inventario.FormClosed += (s, args) => this.Show();

            inventario.Show();
            this.Hide();
        }

        private void btn_Lista_Click(object sender, EventArgs e)
        {
            ListaVentas lista = new ListaVentas();

            lista.FormClosed += (s, args) => this.Show();

            lista.Show();
            this.Hide();
        }

        private void Vendedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
