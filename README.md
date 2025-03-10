Kitap Depo Yönetim Sistemi Dokümantasyonu

1. Proje Hakkında

Kitap Depo Yönetim Sistemi, kitap stoklarının yönetimini sağlayan bir ASP.NET MVC tabanlı uygulamadır. Projede, kitap ekleme, satış yapma ve stok yönetimi gibi işlemler gerçekleştirilir. Kitaplar tamamen silinmez, eğer stokları tükenirse ve pasif hale getirilirse müşteri tarafından görünmez ancak sistemde kayıtlı kalır.

2. Kullanılan Teknolojiler

Backend: ASP.NET MVC

Veritabanı: Microsoft SQL Server

ORM: Entity Framework

Diğer: Repository Pattern, Dependency Injection

3. Mimari

Proje, katmanlı mimari prensibine göre tasarlanmıştır:

Entity Katmanı: Veritabanı tablolarını temsil eden sınıflar.

Data Katmanı: Veritabanı işlemlerini yöneten repository yapısı.

Business Katmanı: İş kurallarını içeren servisler.

UI Katmanı: Kullanıcı arayüzü ve Controller'ları içerir.

4. İşleyiş

Kitap Ekleme:

Kitap eklenirken eğer veritabanında aynı isimde kitap varsa, stok miktarı artırılır.

Eğer kitap veritabanında yoksa yeni kayıt oluşturulur.

Kitap Silme:

Kitap tamamen silinmez, sadece "Aktif" durumu false olarak güncellenir.

Eğer stok miktarı sıfırsa ve aktif değilse müşteri tarafından görünmez.

Kitap Satış:

Satış sırasında stok miktarı kontrol edilir.

Eğer stok yetersizse satış işlemi gerçekleşmez.

Sipariş başarılı olursa stoktan düşülerek yeni bir sipariş kaydı oluşturulur.

5. API Uç Noktaları (Varsa)

Örnek REST API uç noktaları:

GET /api/books → Tüm kitapları listele

POST /api/books → Yeni kitap ekle (varsa stoğu artır)

PUT /api/books/{id} → Kitap bilgilerini güncelle

DELETE /api/books/{id} → Kitabı pasif hale getir

6. Kullanıcı Senaryoları

Senaryo 1: Yeni bir kitap ekleme

Yönetici "Kitap Ekle" butonuna tıklar.

Kitap bilgilerini girer ve kaydeder.

Eğer kitap sistemde varsa stok artırılır, yoksa yeni kayıt eklenir.

Senaryo 2: Kitap satış işlemi

Müşteri sisteme giriş yapar.

Stokta bulunan kitapları seçer ve sipariş oluşturur.

Stok yeterliyse satış başarılı olur, değilse uyarı verilir.

Senaryo 3: Kitap silme işlemi

Yönetici "Kitap Sil" sayfasına gider.

Kitabı seçerek "Pasif Yap" işlemi uygular.

Kitap artık müşteri tarafından görüntülenemez, ancak sistemde kayıtlı kalır.

7. Sonuç

Bu proje, kitap depo yönetimini verimli hale getirmek için tasarlanmış bir sistemdir. Kitapların stok durumu dinamik olarak yönetilir ve silinmeden sistemde tutulur. Kullanıcı dostu arayüzü ve güçlü mimarisi sayesinde kolayca genişletilebilir.
