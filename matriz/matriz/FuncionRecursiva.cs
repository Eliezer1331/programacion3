using System;
using System.Windows.Forms;

namespace matriz
{
    public partial class FuncionRecursiva : Form
    {
        public FuncionRecursiva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecorrerDeUnoEnUno(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
        }

        private void RecorrerDeUnoEnUno (int valorInicial, int ValorFinal)
        {
            listBox1.Items.Add(valorInicial);

            if(valorInicial< ValorFinal)
            {
                RecorrerDeUnoEnUno(valorInicial + 1, ValorFinal);
            }
        }
    }
}
