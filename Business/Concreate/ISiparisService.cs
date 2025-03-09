using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public interface ISiparisService
    {
        void SiparisAdd(Siparis siparis);
        List<Siparis> SiparisList();

        Siparis GetByIdSiparis(int id);

        void SiparisUpdate(Siparis siparis);

        void SiparisDelete(Siparis siparis);
    }
}
