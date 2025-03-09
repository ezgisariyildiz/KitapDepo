using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface IRepository<T>
    {
        void Add(T Entity);

        List<T> Listele();

        T GetById(Expression<Func<T, bool>> filter);

        void Update(T Entity);

        void Delete(T Entity);
    }
}
