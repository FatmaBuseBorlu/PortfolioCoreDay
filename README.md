#  Dinamik Kişisel Web Paneli ve Admin Arayüzü – ASP.NET Core MVC

Bu proje, hem **kullanıcı** hem de **yönetici** arayüzünü kapsayan, veritabanı temelli tam dinamik bir kişisel portfolyo sistemidir. ASP.NET Core 8.0 altyapısıyla geliştirilen bu sistemde, içeriklerin tamamı dinamik olarak yönetilebilir şekilde tasarlanmıştır.

## Proje Özeti

Bu proje kapsamında kullanıcı arayüzü ve admin paneline ait birçok özellik başarıyla geliştirilmiştir:

### 👤 Kullanıcı Paneli Özellikleri

- `Hakkımda`, `Yetenekler`, `Deneyimler`, `Eğitim` gibi bölümler veritabanı ile tam entegre.
- `İstatistikler` kısmı dinamik hale getirildi (örnek: toplam proje, yetenek sayısı, gelen mesaj sayısı, rastgele istatistikler).
- `Çalışmalarım` kısmında **kategori filtreleme** özelliği ile UX geliştirildi.
- `Hizmetlerim` bölümünde **son 6 hizmet** dinamik olarak listelendi.
- **SweetAlert2** ile kullanıcıya görsel ve işlevsel bildirimler entegre edildi.

###  Admin Paneli Özellikleri

- Tüm bölümler için **tam dinamik içerik yönetimi** sağlandı.
- Admin panelinde içerik yönetimini kolaylaştıran **Card-Title** yapısı oluşturuldu.
- Projeye özel bir **404 hata sayfası** eklendi.
- Dashboard kısmı **10 farklı istatistik** ile zenginleştirildi.

---

##  Kullanılan Teknolojiler

- **ASP.NET Core 8.0**
- **Entity Framework Core** (Code First + Migration)
- **SQL Server**
- **Razor View + ViewComponent**
- **HTML / CSS / Bootstrap 5**
- **JavaScript / SweetAlert2**
- **Katmanlı mimari:** `Entity`, `DAL`, `UI`
- **Prensipler:** SOLID, DRY

---

##  Proje Yapısı

```plaintext
PortfolioCoreProject/
├── PortfolioCoreDay.Entities        # Entity sınıfları (About, Skill, Experience vb.)
├── PortfolioCoreDay.DataAccess      # Entity Framework veri erişim katmanı
├── PortfolioCoreDay.WebUI           # Razor View, ViewComponent, Controller'lar
├── Views/
│   ├── Default/                     # Ana sayfa bölümleri
│   ├── Shared/Components/          # ViewComponent parçaları
│   ├── Admin/                      # Admin paneli
│   └── Error/                      # Özel hata sayfaları
