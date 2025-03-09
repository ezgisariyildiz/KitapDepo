using Data.Abstract;
using Entity.Concreate;
using Data.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context db = new Context();
        DbSet<T> _object;


        public GenericRepository()
        {
            _object = db.Set<T>();
        }
        public void Add(T Entity)
        {
            var nesne = db.Entry(Entity);
            nesne.State = EntityState.Added;
            db.SaveChanges();
        }

        public void Delete(T Entity)
        {
            var nesne = db.Entry(Entity);
            nesne.State = EntityState.Deleted;
            db.SaveChanges();
        }

        public T GetById(Expression<Func<T, bool>> filter)
        {
            return _object.FirstOrDefault(filter);
        }

        public List<T> Listele()
        {
            return _object.ToList();
        }

        public void Update(T Entity)
        {
            var nesne = db.Entry(Entity);
            nesne.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
