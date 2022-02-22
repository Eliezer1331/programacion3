using System;
using System.Windows.Forms;

namespace primer_programa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Numero1TextBox.Text);
            int num2 = Convert.ToInt32(Numero2TextBox.Text);

            ResultadoTextBox.Text = Sumar(num1, num2).ToString();
        }
         
        private int Sumar(int num1, int num2)
        {
            int resultado = num1 + num2;

            return resultado;
        }


        private void MostrarMensaje()
        {
            MessageBox.Show("Este es un mensaje");
        }

        private void MensajeButton_Click(object sender, EventArgs e)
        {
            MostrarMensaje();
        }
    }
}
