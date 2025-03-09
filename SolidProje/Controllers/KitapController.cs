using Business.Abstract;
using Data.EntityFramework;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolidProje.Controllers
{
    public class KitapController : Controller
    {
        KitapManager km = new KitapManager(new EFKitapDal());
        KategoriManager kategoriManager = new KategoriManager(new EFKategoriDal());
        SiparisManager sm = new SiparisManager(new EFSiparisDal());
        MusteriManager mm = new MusteriManager(new EFMusteriDal());
        // GET: Kitap
        public ActionResult Index()
        {
            var sonuc = km.KitapList();
            return View(sonuc);

        }
        public ActionResult Create()
        {
            List<SelectListItem> sonuc = (from x in kategoriManager.KategoriList()
                                          select new SelectListItem
                                          {
                                              Text = x.KategoriAdi,
                                              Value = x.KategoriId.ToString()
                                          }).ToList();
            ViewBag.d = sonuc;
            return View();
        }

            [HttpPost]
        public ActionResult Create(Kitap kitap)
        {
            if (ModelState.IsValid)
            {
                var mevcutKitap = km.KitapList().FirstOrDefault(k => k.KitapAdi == kitap.KitapAdi);
                if (mevcutKitap != null)
                {
                    mevcutKitap.Stok += kitap.Stok;
                    km.KitapUpdate(mevcutKitap);
                }
                else
                {
                    km.KitapAdd(kitap);
                }
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete()
        {
            var kitapListesi = km.KitapList().Where(k => k.Aktif).ToList();
            return View(kitapListesi);
        }


        [HttpPost]
        public ActionResult Delete(int id)
        {
            var kitap = km.GetByIdKitap(id);
            if (kitap != null)
            {
                kitap.Aktif = false;  // Kitap pasif hale getirilir.
                km.KitapUpdate(kitap);  // Güncelleme yapılır.
            }
            return RedirectToAction("Index");  // Silme işleminden sonra liste sayfasına yönlendirilir.
        }


        [HttpGet]
        public ActionResult KitapSat()
        {
            // Kitaplar ve müşteriler için ViewBag verisi setlenmeli
            ViewBag.Kitaplar = new SelectList(km.KitapList().Where(k => k.Aktif), "KitapId", "KitapAdi");
            ViewBag.Musteriler = new SelectList(mm.MusteriList(), "MusteriId", "MusteriAdi");

            return View();
        }


        [HttpPost]
        public ActionResult KitapSat(int kitapId, int musteriId, int adet)
        {
            var kitap = km.GetByIdKitap(kitapId);

            if (kitap == null || !kitap.Aktif || kitap.Stok == null)
            {
                TempData["SiparisMesaj"] = "Seçilen kitap mevcut değil veya satışta değil.";
                return RedirectToAction("SiparisSonuc");
            }

            if (kitap.Stok < adet)
            {
                TempData["SiparisMesaj"] = "Stok yetersiz!";
                return RedirectToAction("SiparisSonuc");
            }

            // Stoktan düş
            kitap.Stok -= adet;
            km.KitapUpdate(kitap);

            // Tutarı hesapla
            int tutar = kitap.Fiyat * adet;

            // Sipariş oluştur
            Siparis yeniSiparis = new Siparis
            {
                KitapId = kitapId,
                MusteriId = musteriId,
                Tutar = tutar,
                Adet = adet,
                SiparisTarihi = DateTime.Now
            };

            sm.SiparisAdd(yeniSiparis);
            TempData["SiparisMesaj"] = "Satış başarılı!";
            return RedirectToAction("SiparisSonuc");
        }


        public ActionResult SiparisSonuc()
        {
            ViewBag.Mesaj = TempData["SiparisMesaj"];
            return View();
        }
    }
}