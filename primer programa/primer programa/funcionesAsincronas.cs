using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primer_programa
{
    public partial class funcionesAsincronas : Form
    {
        public funcionesAsincronas()
        {
            InitializeComponent();
        }

        private async void HornearButton_Click(object sender, EventArgs e)  //escribir la palabra async cuando se usa asincrono
        {
            //  hornearPizza();
           await hornearPizzaAsync();  //escribir await
            label1.Text = "la pizza esta lista";
        }
        private void hornearPizza ()  //metodo sincrono
        {
            Thread.Sleep(12000);
        }
        private Task hornearPizzaAsync ()     //metodo asincrono 
        {
            return Task.Delay(12000);  //el delay nos permite hacer varias tareas al mismo tiempo
        }
        private void OtrasTraeasButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizando otras tareas" , " Atencion!" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            decimal valor1 = Convert.ToDecimal(textBox1.Text);
            decimal valor2 = Convert.ToDecimal(textBox2.Text);

            MessageBox.Show("la suma es: " + await sumarAsync(valor1, valor2)) ;
        }
        private decimal sumar (decimal valor1, decimal valor2)
        {
            return valor1 + valor2;
        }
        private async Task<decimal> sumarAsync (decimal valor1, decimal valor2)
        {
            var resutado = await Task.Run(() =>  // la palabra var detecta que tipo de variable es
            {
                return valor1 + valor2;
            });
            return resutado;   
        }
    }
}
