using cuenta_de_banco.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuenta_de_banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cliente cliente;
        Cuenta cuenta;
        MovimientoCuenta movimientoCuenta;
        List<MovimientoCuenta> listaMovimientosCuenta;

        private void CrearCuentaButton_Click(object sender, EventArgs e)
        {
            // 1. Crear el cliente
            cliente = new Cliente(IdentidadClienteTextBox.Text, NombreClienteTextBox.Text);

            // 2. Crear Cuenta
            cuenta = new Cuenta(NumCuentaTextBox.Text, cliente, DateTime.Now);

            SaldoTextBox.Text = cuenta.Saldo.ToString("N");
            
        }

        private void CrearMovimientoButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MontoMvimientoTextBox.Text)) //se utiliza para q el textbox no vaya vacio
            {
                errorProvider1.SetError(MontoMvimientoTextBox, " Ingrese un monto ");
                MontoMvimientoTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TipoMovimientoComboBox.Text))
            {
                errorProvider1.SetError(TipoMovimientoComboBox, "Seleccione un tipo de transaccion");
                TipoMovimientoComboBox.Focus();
                return;
            }

            if (TipoMovimientoComboBox.Text == "Deposito")
            {
                // Deposito
                cuenta.Depositar(Convert.ToDecimal(MontoMvimientoTextBox.Text));

                movimientoCuenta = new MovimientoCuenta(cuenta, DateTime.Now, Convert.ToDecimal(MontoMvimientoTextBox.Text),
                                                        TipoMovimientoComboBox.Text);

                listaMovimientosCuenta = new List<MovimientoCuenta>();
                listaMovimientosCuenta.Add(movimientoCuenta);

                MovimientosListBox.Items.Add("Deposito a la cuenta N." + cuenta.NumeroCuenta + " por la cantidad de: L."+
                                             movimientoCuenta.Monto + " con fecha: "+ movimientoCuenta.Fecha) ;

                SaldoTextBox.Text = cuenta.Saldo.ToString("N");


            }
            else if (TipoMovimientoComboBox.Text == "Retiro")
            {
                //Retiro
                bool retiro = cuenta.Retirar(Convert.ToDecimal(MontoMvimientoTextBox.Text));
                
                if (retiro)
                {
                    movimientoCuenta = new MovimientoCuenta(cuenta, DateTime.Now, Convert.ToDecimal(MontoMvimientoTextBox.Text),
                                                        TipoMovimientoComboBox.Text);

                    listaMovimientosCuenta = new List<MovimientoCuenta>();
                    listaMovimientosCuenta.Add(movimientoCuenta);

                    MovimientosListBox.Items.Add("Retiro a la cuenta N." + cuenta.NumeroCuenta + " por la cantidad de: L." +
                                            movimientoCuenta.Monto + " con fecha: " + movimientoCuenta.Fecha);

                    SaldoTextBox.Text = cuenta.Saldo.ToString("N");

                }
                else
                {
                    MessageBox.Show("No tiene sufiente saldo para realizar el retiro. ");
                }
            }
            MontoMvimientoTextBox.Clear();
        }
    }
}
