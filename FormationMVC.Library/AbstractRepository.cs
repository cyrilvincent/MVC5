using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FormationMVC.Library
{
    public abstract class AbstractRepository<T> : IRepository<T> where T : class, IProduct
    {
        public ProductContext Context { get; set; }

        public void Create(T vr)
        {
            Context.Set<T>().Add(vr);
        }

        public void Delete(T vr)
        {
            Context.Set<T>().Remove(vr);
        }

        public void Delete(int id)
        {

            Context.Set<T>().Remove(GetById(id));
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>();
        }

        public T GetById(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public IEnumerable<T> GetByLambda(Expression<Func<T, bool>> where)
        {
            return Context.Set<T>().Where(where);
        }
    }
}
