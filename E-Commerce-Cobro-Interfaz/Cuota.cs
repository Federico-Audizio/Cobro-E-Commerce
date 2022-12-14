using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Cobro_Interfaz
{
    internal class Cuota
    {
        private decimal monto;
        private DateTime fecha;
        private Boolean pagado;
        private Pago pagos;


        public decimal Monto { get => monto; set => monto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Boolean Pagado { get => pagado; set => pagado = value; }
        public Pago Pagos { get => pagos; set => pagos = value; }

        public Cuota(decimal monto, DateTime fecha, bool pagado)
        {
            this.monto = monto;
            this.fecha = fecha;
            this.pagado = pagado;

        }
    }
}
