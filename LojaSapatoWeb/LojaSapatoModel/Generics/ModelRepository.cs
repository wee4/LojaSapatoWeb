using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSapatoModel.Generics
{
    class ModelRepository<T> : IModelRepository<T> where T : class
    {

        private DataContext _ctx;
        private IDbSet<T> dbEntity;

        public void add(T model)
        {
            throw new NotImplementedException();
        }

        public void add(IEnumerable<T> models)
        {
            throw new NotImplementedException();
        }

        public void delete(T model)
        {
            throw new NotImplementedException();
        }

        public void delete(IEnumerable<T> models)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> findAll()
        {
            throw new NotImplementedException();
        }

        public T findById(long id)
        {
            throw new NotImplementedException();
        }

        public void update(T model)
        {
            throw new NotImplementedException();
        }

        public void update(IEnumerable<T> models)
        {
            throw new NotImplementedException();
        }
    }
}
