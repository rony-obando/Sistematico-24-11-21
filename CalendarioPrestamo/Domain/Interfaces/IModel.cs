using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IModel<T>
    {
        List<T> FinAll();
        void Add(T t);
        void Update(T t);
    }
}
