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
    public partial class funcionesfecha : Form
    {
        public funcionesfecha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

            DiaTextBox.Text = fecha.Day.ToString();  //mostrar el dia ingresado
            MesTextBox.Text = fecha.Month.ToString(); //mostrar el mes ingresado
            AnioTextBox.Text = fecha.Year.ToString(); //mostrar  el año ingresado
            DiaLetrasTextBox.Text = fecha.ToString("dddd"); //mostrar el dia de la semana en letras completo
            MesLetrasTextBox.Text = fecha.ToString("MMMM"); //mostrar el mes en letras
            SumaDiasTextBox.Text = fecha.AddDays(25).ToShortDateString(); // mostrara la fecha ingresada mas los 25 dias agregados
            RestarDiasTextBox.Text = fecha.AddDays(-25).ToShortDateString(); //restar los dias 

            EdadTextBox.Text = DevolverEdad(fecha).ToString();
        }

        private int DevolverEdad(DateTime _fechaNacimiento)
        {
            DateTime fechaNacimiento = _fechaNacimiento;
            DateTime fechaActual = DateTime.Now;

            int edad = 0;
            if (fechaNacimiento > fechaActual)
            {
                MessageBox.Show("la fecha ingresada no es valida");

                return 0; 
            }
            {
                edad = fechaActual.Year - fechaNacimiento.Year;
                if(fechaNacimiento.Month > fechaActual.Month)
                {
                   
                  --edad;
                     
                }

            }
            return edad;
        }
    }
}
