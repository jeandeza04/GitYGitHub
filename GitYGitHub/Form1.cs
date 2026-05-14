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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Lista_Click(object sender, EventArgs e)
        {
            String clave = (String)sender;
            string usuario = txt_User.Text;
            string contraseña = txt_Pass.Text;

            // VENDEDOR
            if (usuario == "vendedor" && contraseña == "123")
            {
                Vendedor ven = new Vendedor();
                ven.Show();
                this.Hide();
            }

            // ADMINISTRADOR
            else if (usuario == "admin" && contraseña == "123")
            {
                Administrador admin = new Administrador();
                admin.Show();
                this.Hide();
            }

            // ERROR
            else
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos"
                );
            }
        }
    }
}
