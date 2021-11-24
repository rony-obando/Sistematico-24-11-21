using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    public interface IService<T>
    {
        List<T> FinAll();
        void Add(T t);
        void Update(T t);
    }
}
