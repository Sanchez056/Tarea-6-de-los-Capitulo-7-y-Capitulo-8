using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerccio2Capitulo_8
{
    public partial class JustificarCadena : Form
    {
        public JustificarCadena()
        {
            InitializeComponent();
        }

        private void JutificarCadenabutton1_Click(object sender, EventArgs e)
        {
            int contador;
            contador = Convert.ToInt32(DigiteCantidadJutificarCadenatextBox3.Text);
       
            String digiteCadena;
            String resultado;
         
            int x = 0;
           
            digiteCadena = DigiteCadenatextBox1.Text;
            for (x = 0; x < digiteCadena.Length; x++)
            {
                contador += 1;
                // Iquierda
                resultado = DigiteCadenatextBox1.Text.PadLeft(contador);
                JustificarCadenaIquierdadtextBox1.Text = resultado;
                // Derecha
                resultado = DigiteCadenatextBox1.Text.PadRight(contador);
                JustificarCadenaDerechatextBox2.Text = resultado;
            }
            
        }
    }
}
