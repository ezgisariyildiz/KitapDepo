using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concreate
{
   public class Context : DbContext
    {
        DbSet<Kategori> Kategoriler { get; set; }
        DbSet<Kitap> Kitaplar { get; set; }
        DbSet<Musteri> Musteriler { get; set; }
        DbSet<Siparis> Siparisler { get; set; }
    }
}
