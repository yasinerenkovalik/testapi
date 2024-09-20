Proje Adı

.NET Tabanlı Uygulama

Proje Açıklaması

Bu proje, Onion Architecture prensibiyle tasarlanmış ve CQRS (Command Query Responsibility Segregation) mimarisi ile geliştirilmiştir. Projede veri transferleri için AutoMapper, iş kuralları ve veri doğrulaması için Fluent Validation, event-driven yapılar için MediatR, kimlik doğrulama için JWT Token ve önbellekleme için Redis kullanılmıştır.

Kullanılan Teknolojiler

.NET 6: Backend geliştirme platformu
AutoMapper: Nesneler arası dönüşüm
Onion Architecture: Katmanlı mimari ile bağımsızlık
CQRS: Veri yazma ve okuma operasyonlarının ayrımı
Fluent Validation: Veri doğrulama
MediatR: İstekler arası iletişim
JWT (JSON Web Token): Kimlik doğrulama ve yetkilendirme
Redis: Performanslı veri önbellekleme
Kurulum

Projenizi kendi ortamınızda çalıştırmak için aşağıdaki adımları izleyin:

Projeyi Klonlayın:
bash
Copy code
git clone https://github.com/kullanici-adi/proje-adi.git
cd proje-adi
Gerekli Bağımlılıkları Yükleyin:
Projeyi açtıktan sonra, bağımlılıkları yüklemek için terminale şu komutu girin:

bash
Copy code
dotnet restore
AppSettings.json Dosyasını Düzenleyin:
appsettings.json dosyasındaki Redis, JWT ve diğer konfigürasyonları kendi sisteminize göre düzenleyin:

json
Copy code
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=myDb;User Id=myUser;Password=myPass;"
  },
  "JwtSettings": {
    "SecretKey": "SuperSecretKey123"
  },
  "RedisSettings": {
    "ConnectionString": "localhost:6379"
  }
}
Veritabanını Migrate Edin:
Veritabanını oluşturmak ve güncellemek için şu komutu çalıştırın:

bash
Copy code
dotnet ef database update
Projeyi Çalıştırın:
bash
Copy code
dotnet run
Kullanım

Proje, temel CRUD işlemlerini ve CQRS ile komut/sorgu yapılarını kullanarak, çeşitli işlevleri yerine getirmektedir. JWT Token ile güvenlik sağlanır ve kullanıcı istekleri doğrulanır.

Login: Kullanıcı girişini doğrular ve JWT Token üretir.
Redis Cache: Verilerin performanslı bir şekilde önbelleğe alınmasını sağlar.
Fluent Validation: Kullanıcı girişlerini doğrular.
Proje Mimarisi

Bu proje, Onion Architecture ile geliştirilmiş olup, katmanlı yapısıyla bağımsızlık sağlar:

Core: Tüm iş kuralları ve veri modelleri
Application: CQRS, MediatR ve servis sınıfları
Infrastructure: Veri erişim katmanı (EF Core, Redis)
API: Web API katmanı
Katkıda Bulunma

Bu projeye katkıda bulunmak isterseniz, lütfen bir Pull Request gönderin. Hataları bildirmek için Issues bölümünü kullanabilirsiniz.

Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Ayrıntılar için LICENSE dosyasına bakın.
