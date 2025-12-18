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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBox1.Items.Add("Terremotos");
            comboBox1.Items.Add("Erupciones Volcánicas");
            comboBox1.Items.Add("Derrumbes");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.Add("Inundaciones");
            comboBox2.Items.Add("Sequías");
            comboBox2.Items.Add("Tormentas Eléctricas");
            comboBox2.Items.Add("Granizadas");
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Items.Add("Fenómeno El Niño");
            comboBox3.Items.Add("Fenómeno La Niña");
            comboBox3.Items.Add("Olas de calor");
            comboBox3.Items.Add("Heladas");
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          string seleccion=comboBox1.SelectedItem.ToString();
            switch (seleccion)
            {
                case "Terremotos":
                    richTextBox1.Text =
                "TERREMOTOS\n\n" +
                "Se produce por el movimiento de placas tectónicas.\n" +
                "Puede causar daños estructurales graves.";
                    break;

                case "Erupciones Volcánicas":
                    richTextBox1.Text =
                "ERUPCIONES VOLCÁNICAS\n\n" +
                "Salida violenta de magma, gases \n" +
                "y cenizas desde el interior de la Tierra.";
                    break;

                case "Derrumbes":
                    richTextBox1.Text =
                    "DERRUMBES \n\n" +
                    "Caída o deslizamiento repentino de tierra \n" +
                    "o rocas por una pendiente.";
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion2 = comboBox2.SelectedItem.ToString();
            switch (seleccion2)
            {
                case "Inundaciones":
                    richTextBox2.Text =
                "INUNDACIONES\n\n" +
                "Se produce por desbordamiento de ríos.\n" +
                "Cuándo salen de su cauce por lluvias intensas o deshielo.";
                    break;

                case "Sequías":
                    richTextBox2.Text =
                    "SEQUÍA\n\n" +
                    "Falta prolongada de lluvia que reduce agua disponible.";
                    break;

                case "Tormentas Eléctricas":
                    richTextBox2.Text =
                    "TORMENTA ELÉCTRICA\n\n" +
                    "Tormenta con rayos, truenos y lluvia intensa, \n" +
                    "por nubes de desarrollo vertical.";
                    break;


                case "Granizadas":
                    richTextBox2.Text =
                    "GRANIZADA \n\n" +
                    "Precipitación de bolas de hielo (granizo) \n" +
                    " desde nubes de tormenta.";
                    break;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 menu=new Form2();
            menu.Show();
            this.Hide();
        }
        private void btndatos_Click(object sender, EventArgs e)
        {
            Form4 evaluacionf1=new Form4();
            evaluacionf1.Show();
            this.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion3 = comboBox3.SelectedItem.ToString();
            switch (seleccion3)
            {
                case "Fenómeno El Niño":
                    richTextBox3.Text =
                "FENÓMENO EL NIÑO\n\n" +
                "Se produce por desbordamiento de ríos.\n" +
                "Cuándo salen de su cauce por lluvias intensas o deshielo.";
                    break;

                case "Fenómeno La Niña":
                    richTextBox3.Text =
                    "FENÓMENO LA NIÑA \n\n" +
                    "Falta prolongada de lluvia que reduce agua disponible.";
                    break;

                case "Olas de calor":
                    richTextBox3.Text =
                    "OLAS DE CALOR \n\n" +
                    "Tormenta con rayos, truenos y lluvia intensa, \n" +
                    "por nubes de desarrollo vertical.";
                    break;


                case "Heladas":
                    richTextBox3.Text =
                    "HELADAS \n\n" +
                    "Precipitación de bolas de hielo (granizo) \n" +
                    " desde nubes de tormenta.";
                    break;
            }
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }
    }
}
