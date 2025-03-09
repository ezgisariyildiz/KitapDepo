using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public interface IKategoriService
    {
        void KategoriAdd(Kategori kategori);
        List<Kategori> KategoriList();

        Kategori GetByIdKategori(int id);

        void KategoriUpdate(Kategori kategori);

        void KategoriDelete(Kategori kategori);
    }
}
