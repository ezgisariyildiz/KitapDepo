using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public interface IKitapService
    {
        void KitapAdd(Kitap kitap);
        List<Kitap> KitapList();
        Kitap GetByIdKitap(int id);
        void KitapUpdate(Kitap kitap);
        void KitapDelete(Kitap kitap);
    }
}
