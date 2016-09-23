using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerccio5_Capitulo_8
{
    public partial class OrdenAlfabeticoCadena : Form
    {
        public OrdenAlfabeticoCadena()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OrdenarAlfabeticamentebutton1_Click(object sender, EventArgs e)
        {
            String digiteCadena1;
            digiteCadena1 = DigiteCadena1textBox1.Text;
                     
            Char[] Ordena = digiteCadena1.ToCharArray();
            Array.Sort(Ordena);
            digiteCadena1 = new string(Ordena);

            ResultadoCadenasOrdenadastextBox3.Text = digiteCadena1.ToString();

        }
    }
}
