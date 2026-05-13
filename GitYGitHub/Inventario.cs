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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            dgvInventario.Rows.Add("Tractor", 5, "S/. 25000");
            dgvInventario.Rows.Add("Motobomba", 10, "S/. 1200");
            dgvInventario.Rows.Add("Fumigadora", 15, "S/. 850");
            dgvInventario.Rows.Add("Arado", 7, "S/. 3000");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendedor menu = new Vendedor();
            menu.Show();
            this.Close();
        }
    }
}
