using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace AppCore.Services
{
    public class CalendarioService : ICalendarioService
    {
        private ICalendarioModel calendarioService;
        public CalendarioService(ICalendarioModel cld)
        {
            calendarioService = cld;
        }
        public void Add(CalenPrestamo t)
        {
            calendarioService.Add(t);
        }

        public List<CalenPrestamo> FinAll()
        {
            return calendarioService.FinAll();
        }

        public int GetId()
        {
            return calendarioService.GetId();
        }

        public void Update(CalenPrestamo t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CalenPrestamo> ViewFiltrados(int estado)
        {
            return calendarioService.ViewFiltrados(estado);
        }
    }
}
