using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace AppCore.Interfaces
{
    public interface ICalendarioService:IService<CalenPrestamo>
    {
        int GetId();
        IEnumerable<CalenPrestamo> ViewFiltrados(int estado);
    }
}
