using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Ejercccio_1
{
    public partial class CalificacionesSalonClases : Form
    {

        ArrayList lista = new ArrayList();
        public CalificacionesSalonClases()
        {
            InitializeComponent();
        }


        private void CalcularButton_Click(object sender, EventArgs e)
        {
            if (InserteCalificacionTextBox.Text == "")
            {
                MessageBox.Show("Campo Vacio");

            }
            else
            {
                lista.Add(int.Parse(InserteCalificacionTextBox.Text));
                InserteCalificacionTextBox.Text = string.Empty;

                int i;
                for (i = 0; i < lista.Count; i++)
                {
                    CalificacioneslistBox1.Items.Add(lista[i]);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalificacioneslistBox1.Items.Clear();
            int i;
            int valor = 0, promedio=0;

            for (i = 0; i < lista.Count; i++)
            {
                lista.Sort();
                CalificacioneslistBox1.Items.Add(lista[i]);
                valor += (int)lista[i];
                MayorCalificaciontextBox3.Text = lista[i].ToString();
                MenorCalificacionestextBox4.Text = lista[0].ToString();


            }
            promedio = valor / i;

            PromedioCalificacionestextBox5.Text = promedio.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int posicion;
            if (int.Parse(DigitePosiciontextBox1.Text) >= 30)
            {
                MessageBox.Show("No exitre el numero de la posicion");
            }
            else
            {
                posicion = int.Parse(DigitePosiciontextBox1.Text);
                CalificacionesPosiciontextBox2.Text = lista[posicion].ToString();
            }

        }
    }
}






