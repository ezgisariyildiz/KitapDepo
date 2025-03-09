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
    public class KitapManager : IKitapService
    {
        IKitapDal _kitapDal;

        public KitapManager(IKitapDal kitapDal)
        {
            _kitapDal = kitapDal;
        }

        public void KitapAdd(Kitap kitap)
        {
            _kitapDal.Add(kitap);
        }

        public void KitapDelete(Kitap kitap)
        {
            _kitapDal.Delete(kitap);
        }

        public List<Kitap> KitapList()
        {
            return _kitapDal.Listele().Where(k => k.Aktif).ToList();
        }

        public Kitap GetByIdKitap(int id)
        {
            return _kitapDal.GetById(x => x.KitapId == id);
        }

        public void KitapUpdate(Kitap kitap)
        {
            _kitapDal.Update(kitap);
        }
    }
}
