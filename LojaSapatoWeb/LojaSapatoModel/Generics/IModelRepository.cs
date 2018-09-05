using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSapatoModel.Generics
{
    interface IModelRepository<T> where T : class
    {
        IEnumerable<T> findAll();

        T findById(Int64 id);

        void add(T model);

        void add(IEnumerable<T> models);

        void update(T model);

        void update(IEnumerable<T> models);

        void delete(T model);

        void delete(IEnumerable<T> models);

    }
}
