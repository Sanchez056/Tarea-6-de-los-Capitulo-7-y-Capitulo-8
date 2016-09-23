using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerccio4_Capitulo_8
{
    public partial class SumaNumeroNegativo : Form
    {
        public SumaNumeroNegativo()
        {
            InitializeComponent();
        }

        private void Calcularbutton1_Click(object sender, EventArgs e)
        {
            int resultado;
            int digiteNumero1;
            int digiteNumero2;

              digiteNumero1 = Convert.ToInt32(DigiteNumero1textBox1.Text);
              digiteNumero2 = Convert.ToInt32(DigiteNumero2textBox2.Text);
             
             resultado = digiteNumero1 + digiteNumero2;

            if(resultado > 0)
            {
                ResultadotextBox1.Text = Convert.ToString(resultado);
            }
            if(resultado<0)
            {
                ResultadotextBox1.Text = '('+Convert.ToString(resultado)+')';
            }

        }
    }
}
