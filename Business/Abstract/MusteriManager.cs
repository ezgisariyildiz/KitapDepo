using Business.Concreate;
using Data.Abstract;
using Data.EntityFramework;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public class MusteriManager : IMusteriService
    {
        IMusteriDal _musteriDal;

        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }

        public void MusteriAdd(Musteri musteri)
        {
            _musteriDal.Add(musteri);
        }

        public void MusteriDelete(Musteri musteri)
        {
            _musteriDal.Delete(musteri);
        }

        public List<Musteri> MusteriList()
        {
            return _musteriDal.Listele();
        }

        public Musteri GetByIdMusteri(int id)
        {
            return _musteriDal.GetById(x => x.MusteriId == id);
        }

        public void MusteriUpdate(Musteri musteri)
        {
            _musteriDal.Update(musteri);
        }
    }
}
