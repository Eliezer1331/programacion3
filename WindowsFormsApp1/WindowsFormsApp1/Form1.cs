using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            string[] ArregloNombre = { Convert.ToString(NombreTextBox.Text) };
            int[] ArregloEdad = { Convert.ToInt32(EdadTextBox.Text) };


            foreach (string item in ArregloNombre)
            {
                foreach (int item1 in ArregloEdad)
                {
                    _ = DatosListBox.Items.Add(item + " - " + item1);
                }
            }
        }


        private void LimpiarButton_Click_1(object sender, EventArgs e)
        {
            NombreTextBox.Text = "";
            EdadTextBox.Text = "";
        }
    }
}
