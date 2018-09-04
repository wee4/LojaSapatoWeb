using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSapatoModel.Entity
{
    interface GenericModel<T>
    {
        T Create(T t);

        T Update(T t);

        T Delete(T t);

        T Find(T t);

        List<T> FindAll();
    }
}
