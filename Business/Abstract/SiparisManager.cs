using Business.Concreate;
using Data.Abstract;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public class SiparisManager : ISiparisService
    {
        ISiparisDal _siparisDal;

        public SiparisManager(ISiparisDal siparisDal)
        {
            _siparisDal = siparisDal;
        }

        public void SiparisAdd(Siparis siparis)
        {
            _siparisDal.Add(siparis);
        }

        public void SiparisDelete(Siparis siparis)
        {
            _siparisDal.Delete(siparis);
        }

        public List<Siparis> SiparisList()
        {
            return _siparisDal.Listele();
        }

        public Siparis GetByIdSiparis(int id)
        {
            return _siparisDal.GetById(x => x.SiparisId == id);
        }

        public void SiparisUpdate(Siparis siparis)
        {
            _siparisDal.Update(siparis);
        }
    }
}
