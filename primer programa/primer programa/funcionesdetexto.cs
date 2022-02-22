using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primer_programa
{
    public partial class funcionesdetexto : Form
    {
        public funcionesdetexto()
        {
            InitializeComponent();
        }

        private void ProcesarButton_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox.Text;

            LongitudTextBox.Text = cadena.Length.ToString(); //medir la longitud del texto

            PrimerCaracterTextBox.Text = cadena.Substring(0, 1); // aparecera el primer caracter

            UltimoCaracterTextBox.Text = cadena.Substring(cadena.Length -1 , 1); // ultimo caracter de lo escrito

            RangoTextBox.Text = cadena.Substring(4 , 6);   // rango que qeramos de lo ingresado

            MayusculaTextBox.Text = cadena.ToUpper(); //aparecera el texto en mayuscula

            MinusculaTextBox.Text = cadena.ToLower();  // aparecera todo el texto en minuscula

            RemplazarTextBox.Text = cadena.Replace(" ", ""); //remplazara el espacion por nada, asi saldra toda el texto escrito junto por ejemplo, se puede usar por cambiar letras



        }
    }
}
