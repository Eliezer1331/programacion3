using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliezerPineda
{
    public partial class formulario2 : Form
    {
        public formulario2()
        {
            InitializeComponent();
        }

        private async void EjecutarButton_Click(object sender, EventArgs e)
        {
            int precio = Convert.ToInt32(PrecioTextBox.Text);
            int cantidad = Convert.ToInt32(CantidadTextBox.Text);

            MessageBox.Show("Su total con el 15% de descuento es : " + await totalAsync(precio, cantidad));

        }
        private async Task<int> totalAsync(int precio, int cantidad)
        {
            var resultado = await Task.Run(() =>
            {
                int subtotal = 0;
                int total = 0;
                int desc = 0;
                subtotal = precio * cantidad;
                desc = (int)(subtotal * 0.15);
                total = subtotal - desc;

                return subtotal - desc;
            });
            return resultado;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
