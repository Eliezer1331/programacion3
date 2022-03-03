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
    public partial class Primer_Formulario : Form
    {
        public Primer_Formulario()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            Interes(300000);
            
            
        }
        private void Interes (double capital)
        {
            string[] arregloMes = { "Enero", "febrero", "marzo", "Abril", " mayo", " junio", "julio", "agosto", "septiembre", " octumbre", "Noviembre", "Diciembre" };

            for (int i = 0; i < arregloMes.Length; i++)
            {
                listBox1.Items.Add("Mes de "+ arregloMes[i]+ " el interes ganado es: " + (capital * 0.025) * (i+1));
            }
        }
        
    }
}
