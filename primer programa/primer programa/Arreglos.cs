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
    public partial class Arreglos : Form
    {
        public Arreglos()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            // vectores
            int[] arreglo1 = new int[5];
            arreglo1[0] = 12;
            arreglo1[1] = 1;
            arreglo1[2] = 13;
            arreglo1[3] = 5;
            arreglo1[4] = 7;

            int[] arreglo2 = new int[6] { 41, 34, 54, 43, 10, 7 };

            int[] arreglo3 = new int[] { 2, 5, 4, 7, 12 };

            int[] arreglo4 = { 2, 6, 4, 7, 8 };

            string[] arreglo5 = { "lnes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };

            //for (int i = 0; i < arreglo5.Length ; i++)  
            //{
            //    listBox1.Items.Add(arreglo5[i]); 
            //}

            foreach (var item in arreglo5)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
