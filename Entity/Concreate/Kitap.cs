using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concreate
{
    public class Kitap
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public int Stok { get; set; }
        public int Fiyat { get; set; }
        public int? KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }

        public bool Aktif { get; set; } = true;
    }
}
