using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuenta_de_banco.clases
{
    public class MovimientoCuenta
    {
        public Cuenta MiCuenta { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string TipoMovimiento { get; set; }

        public MovimientoCuenta()
        {

        }

        public MovimientoCuenta(Cuenta miCuenta, DateTime fecha, decimal monto, string tipoMovimiento)
        {
            MiCuenta = miCuenta;
            Fecha = fecha;
            Monto = monto;
            TipoMovimiento = tipoMovimiento;
        }

    }
}
