using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concreate
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }

        public int? SiparisId { get; set; }
        public virtual Siparis Siparis { get; set; }
    }
}
