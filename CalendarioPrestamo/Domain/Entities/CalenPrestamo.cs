using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Enums;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CalenPrestamo
    {
        public int Id { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public Estado Estado { get; set; }
        public decimal PrincipalPagado { get; set; }
        public decimal InteresPagado { get; set; }
        public decimal CuotaPagada { get; set; }
        public decimal MontoPrestamo { get; set; }
        public decimal Terminos { get; set; }
        public decimal Tasa { get; set; }
        public decimal Principal { get; set; }
        public decimal Interes { get; set; }
        public decimal Cuota { get; set; }
        public decimal TotalPrincipal { get; set; }
        public decimal TotalInteres { get; set; }
    }
}
