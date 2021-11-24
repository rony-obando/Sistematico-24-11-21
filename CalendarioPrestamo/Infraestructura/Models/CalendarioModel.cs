using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;

namespace Infraestructura.Models
{
    public class CalendarioModel : ICalendarioModel
    {
        List<CalenPrestamo> prestamos;
        IEnumerable<CalenPrestamo> Filtrados;
        public CalendarioModel()
        {
            prestamos = new List<CalenPrestamo>();
        }
        //Aqui estan las expresiones Lambda
        Func<decimal, decimal, decimal, decimal> CPrincipal = (monto, tasa, terminos) => (monto * (1 + tasa)) / terminos;
        Func<decimal, decimal, decimal, decimal> CInteres = (monto, tasa, terminos) => (monto * tasa) / terminos;
        public void Add(CalenPrestamo t)
        {
            if (t == null)
            {
                return;
            }
            t.Id = GetId() + 1;
            t.Principal = CPrincipal(t.MontoPrestamo, t.Tasa, t.Terminos);
            t.Interes = CInteres(t.MontoPrestamo, t.Tasa, t.Terminos);
            t.Cuota = t.Principal + t.Interes;
            if (prestamos.Count == 0)
            {
                t.TotalInteres = t.Interes;
                t.TotalPrincipal = t.Principal;
            }
            else
            {
                t.TotalPrincipal = prestamos.Sum(c=>c.Principal)+t.Principal;
                t.TotalInteres = prestamos.Sum(c=>c.Interes)+t.Interes;
            }
            prestamos.Add(t);
        }

        public List<CalenPrestamo> FinAll()
        {
            return prestamos;
        }

        public int GetId()
        {
            return prestamos.Count;
        }
        public IEnumerable<CalenPrestamo> ViewFiltrados(int estado)
        {
            //Aqui utilizo LinQ
            Filtrados = (from c in prestamos where c.Estado==(Estado)estado select c).ToList();
            return Filtrados;
        }
        public void Update(CalenPrestamo t)
        {
            throw new NotImplementedException();
        }

    }
}
