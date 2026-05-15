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
            string usuario = txt_User.Text;
            string contraseña = txt_Pass.Text;

            Form siguienteForm = null;

            if (usuario == "vendedor" && contraseña == "123")
                siguienteForm = new Vendedor();
            else if (usuario == "admin" && contraseña == "123")
                siguienteForm = new Administrador();

            if (siguienteForm != null)
            {
                siguienteForm.Show();

                // opcional: cerrar login completamente
                this.Hide();

                txt_User.Clear();
                txt_Pass.Clear();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                txt_Pass.Clear();
                txt_User.Focus();
            }
        }


    }
}
