using Business.Concreate;
using Data.Abstract;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public class KategoriManager : IKategoriService
    {
        IKategoriDal _kategoriDal;

        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public void KategoriAdd(Kategori kategori)
        {
            _kategoriDal.Add(kategori);
        }

        public void KategoriDelete(Kategori kategori)
        {
            _kategoriDal.Delete(kategori);
        }

        public List<Kategori> KategoriList()
        {
            return _kategoriDal.Listele();
        }

        public Kategori GetByIdKategori(int id)
        {
            return _kategoriDal.GetById(x => x.KategoriId == id);
        }

        public void KategoriUpdate(Kategori kategori)
        {
            _kategoriDal.Update(kategori);
        }
    }
}
