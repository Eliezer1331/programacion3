using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuenta_de_banco.clases
{
    public class Cuenta
    {
        public string NumeroCuenta { get; set; }
        public Cliente MiCliente { get; set; }
        public DateTime FechaApertura { get; set; }
        public decimal Saldo { get; set; }

        public Cuenta(string numerocuenta, Cliente micliente, DateTime fechaapertura)
        {
            NumeroCuenta = numerocuenta;
            MiCliente = micliente;
            FechaApertura = fechaapertura;
        }
        public void Depositar (decimal monto)
        {
            Saldo = Saldo + monto;
        }
        public bool Retirar (decimal monto)
        {
            bool puedeRetirar = false;

            if (Saldo == 0 || Saldo < monto )
            {
                puedeRetirar = false;
            }
            else
            {
                puedeRetirar = true;

                Saldo = Saldo - monto;
            }
            return puedeRetirar;
        }

    }
}
