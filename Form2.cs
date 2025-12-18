using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRUPO8_VS1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form1 inicio=new Form1();
            inicio.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         Form3 funcionalidad1=new Form3();
            funcionalidad1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form5 funcionalidad2=new Form5();
            funcionalidad2.Show();  
            this.Hide();   
        }
    }
}
