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
    public partial class TercerFormulario : Form
    {
        public TercerFormulario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = 1;
            int n2 = 101;

            for (int i = n1; i < n2; i++)
            {
               listBox1.Items.Add(i);
                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox1.Items.Add(" Eliezer Pineda");
                }
                else if (i % 3 == 0)
                {
                    listBox1.Items.Add(" Eliezer");
                }
                else if (i % 5 == 0)
                {
                    listBox1.Items.Add(" Pineda");
                }

            }
        }
    }
}
