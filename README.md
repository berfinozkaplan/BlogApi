# Blog Yönetim Sistemi - Backend API

Bu proje, staj teknik görevi kapsamında geliştirilmiş bir **Blog Yönetim Sistemi Backend** servisidir. Kullanıcıların makale yazabileceği, yorum yapabileceği ve profil yönetimi sağlayabileceği RESTful API servislerini içerir.

## 🚀 Kullanılan Teknolojiler

* **Platform:** .NET 8.0 (ASP.NET Core Web API)
* **Veritabanı:** SQLite
* **ORM:** Entity Framework Core
* **Dokümantasyon:** Swagger / OpenAPI
* **Dil:** C#

## 🛠️ Özellikler

Proje, verilen gereksinimler doğrultusunda şu özellikleri kapsar:

1.  **Makale Yönetimi:**
    * Makale Listeleme, Ekleme, Güncelleme ve Silme (CRUD).
2.  **Yorum Yönetimi:**
    * Makalelere yorum ekleme ve silme işlemleri.
3.  **Kullanıcı ve Profil Yönetimi:**
    * Kullanıcı Kayıt (Register).
    * Kullanıcı Profil Bilgilerini Görüntüleme.
4.  **Güvenlik (Auth):**
    * Kullanıcı giriş işlemi (Login).
    * Giriş başarılı olduğunda Token üretimi.

## ⚙️ Kurulum ve Çalıştırma

Projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

1.  **Projeyi Klonlayın:**
    Projeyi bilgisayarınıza indirin veya klonlayın.

2.  **Veritabanını Hazırlayın:**
    SQLite kullanıldığı için ekstra bir kurulum gerekmez. Ancak veritabanı dosyasının (`blog.db`) oluşması için terminalde (veya Package Manager Console'da) şu komutu çalıştırın:
    ```bash
    Update-Database
    ```

3.  **Projeyi Başlatın:**
    Visual Studio üzerinden `Start` butonuna basın veya terminalden şu komutu kullanın:
    ```bash
    dotnet run
    ```

4.  **API Dokümantasyonu:**
    Proje çalıştığında tarayıcınızda otomatik olarak **Swagger UI** açılacaktır. Tüm endpoint'leri buradan test edebilirsiniz.
    * Adres: `https://localhost:7121/swagger` (Port numarası değişebilir)

## 📡 API Endpoint Örnekleri

* **POST** `/api/Auth/login` -> Kullanıcı girişi ve Token alma.
* **GET** `/api/Articles` -> Tüm makaleleri listeleme.
* **POST** `/api/Articles` -> Yeni makale ekleme.
* **POST** `/api/Comments` -> Yorum yapma.
* **POST** `/api/Users` -> Yeni kullanıcı kaydı.

---
**Geliştirici:** Berfin Özkaplan
