VTYS Final Projesi – Kurulum ve Çalıştırma

1) Gereksinimler
- Windows
- XAMPP (Apache + MySQL) veya herhangi bir MySQL Server (Port: 3306)
- phpMyAdmin (XAMPP ile gelir)
- Visual Studio (WinForms projesi)
- .NET 10.0

2) Veritabanı Kurulumu (MySQL)
A) XAMPP’ı açın
- Apache: Start
- MySQL: Start

B) phpMyAdmin’e girin
- Tarayıcı: http://localhost/phpmyadmin

C) Veritabanını oluşturun
- Yeni (New) > Veritabanı adı: kutuphanevtys
- Karakter seti: utf8mb4_general_ci

D) Script’i içe aktarın
- Import sekmesi > 01_DB klasöründeki KutuphaneVTYS.sql dosyasını seçip çalıştırın.
- İşlem bitince tablolar, stored procedure’ler ve trigger’lar oluşmuş olmalıdır.

3) Uygulamayı Çalıştırma (Visual Studio)
- 02_App klasöründeki .sln dosyasını açın.
- NuGet paketlerini Restore edin (gerekirse otomatik olur).
- Projeyi çalıştırın.

4) Veritabanı Bağlantı Ayarı (App.config)
Uygulama bağlantısı App.config içindeki connectionStrings bölümündedir.

Örnek:
Server=127.0.0.1;Port=3306;Database=kutuphanevtys;User ID=root;Password=;SslMode=None;

Eğer MySQL kullanıcı adı / şifre / port farklıysa App.config içindeki KutuphaneDb connectionString değerini güncelleyin.

5) Örnek Giriş Bilgileri
- admin / admin123
- gorevli / 1234

6) Notlar
- Ödünç verme işlemi: sp_YeniOduncVer stored procedure ile yapılır.
- Teslim alma işlemi: sp_KitapTeslimAl stored procedure ile yapılır.
- Ceza ve toplam borç hesapları trigger’lar ile otomatik güncellenir.
- Dinamik sorgu ekranında güvenlik amaçlı sadece SELECT sorgularına izin verilir.
