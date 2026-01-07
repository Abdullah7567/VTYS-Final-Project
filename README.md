# Kütüphane Yönetim Sistemi (VTYS Final Projesi)

Bu proje, Veritabanı Yönetim Sistemleri (VTYS) dersi final projesi kapsamında geliştirilmiş bir Kütüphane Yönetim Sistemi uygulamasıdır.  
Uygulama Windows Forms (C#) ile geliştirilmiş olup veritabanı olarak MySQL kullanır.

## Özellikler
- Login (Kullanıcı Girişi)
- Üye Yönetimi (ekle / güncelle / sil / listele)
- Kitap & Kategori Yönetimi
- Ödünç Verme (Stored Procedure: sp_YeniOduncVer)
- Teslim Alma (Stored Procedure: sp_KitapTeslimAl)
- Ceza ve Borç Takibi (Trigger ile otomatik borç güncelleme)
- Raporlar (en çok ödünç alınanlar, borçlu üyeler, geciken ödünçler)
- Dinamik Sorgu (güvenlik için sadece SELECT sorgularına izin verilir)
- Loglama (LOG_ISLEM tablosu)

## Kullanılan Teknolojiler
- C# / Windows Forms
- MySQL
- phpMyAdmin (DB yönetimi)

## Kurulum
1. MySQL’de veritabanını oluşturmak için KutuphaneVTYS.sql dosyasını içe aktarın.
2. Visual Studio ile projeyi açın.
3. Veritabanı bağlantı bilgilerini (host, user, password, db) proje içindeki bağlantı ayarlarından kendinize göre güncelleyin.
4. Uygulamayı çalıştırın.

## Veritabanı Bileşenleri
- Tablolar: ROL, KULLANICI, UYE, KATEGORI, KITAP, ODUNC, CEZA, LOG_ISLEM
- Stored Procedures:
  - sp_YeniOduncVer
  - sp_KitapTeslimAl
  - sp_UyeOzetRapor
- Trigger’lar:
  - Ödünç verildiğinde stok azaltma + log
  - Teslim alındığında stok artırma + log
  - Ceza eklendiğinde üye borcunu artırma + log
  - Aktif ödünç/borç varken üye silmeyi engelleme
- İndeksler: ODUNC / CEZA / KITAP tablolarında performans için indeksler bulunmaktadır.

## Proje Dosyaları
- KutuphaneVTYS.sql : Veritabanı şeması + prosedürler + triggerlar
- KütüphaneVTYS/ : Windows Forms kaynak kodları

## Video ve Rapor
- YouTube Video Linki: [(Buraya Tıklayınız)](https://www.youtube.com/watch?v=ylYjqGjzeew)
- Rapor PDF: grup22_rapor.pdf

## Geliştirenler
- Abdullah Alrayyis
- Tarik Hilal
