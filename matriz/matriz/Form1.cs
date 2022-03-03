using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void matrizButton_Click(object sender, EventArgs e)
        {
            int[,] matriz1 = new int[2, 3]
            {
              {4,5,30 },
              {9,7,10 }
            };

            int[,] matriz2 = new int[3, 3];
            //llenar la matriz
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    matriz2[fila, columna] = 4 + (fila + 4) * (columna + 3);
                }
            }
           //mostrar la matriz
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    listBox1.Items.Add("la posicion: [" + fila  + " , "  + columna + " ] = " + matriz2[fila,columna]);
                }
            }
        }
    }
}
