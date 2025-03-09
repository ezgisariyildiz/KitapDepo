using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public interface IMusteriService
    {
        void MusteriAdd(Musteri musteri);
        List<Musteri> MusteriList();

        Musteri GetByIdMusteri(int id);

        void MusteriUpdate(Musteri musteri);

        void MusteriDelete(Musteri musteri);
    }
}
