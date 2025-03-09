using Data.Abstract;
using Data.Repository;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EntityFramework
{
    public class EFKategoriDal : GenericRepository<Kategori>, IKategoriDal
    {
    }
}
