using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concreate
{
    public class Siparis
    {
        public int SiparisId { get; set; }
        public int MusteriId { get; set; }
        public int KitapId { get; set; }
        public int Tutar { get; set; }
        public int Adet { get; set; }
        public DateTime SiparisTarihi { get; set; }

        public ICollection<Musteri> Musteriler { get; set; }

    }
}
