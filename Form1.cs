using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GRUPO8_VS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btniniciosesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusuario.Text))
            {
                MessageBox.Show("Ingrese su nombre, por favor.");
                txtusuario.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtcontrasena.Text))
            {
                MessageBox.Show("Ingrese una contraseña, por favor.");
                txtcontrasena.Focus();
                return;
            }

            MessageBox.Show("Bienvenida/o, " + txtusuario.Text);

            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
        }
    }
}
