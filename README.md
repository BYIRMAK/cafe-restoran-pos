# 🍽️ Menü Soft - Cafe Restoran POS Sistemi

**Modern, Hızlı ve Güvenilir Cafe & Restoran Satış Sistemleri**

[![Build Status](https://github.com/BYIRMAK/cafe-restoran-pos/workflows/Build%20and%20Release/badge.svg)](https://github.com/BYIRMAK/cafe-restoran-pos/actions)

---

## 📦 HIZLI İNDİRME

### ⬇️ [Son Sürümü İndir](https://github.com/BYIRMAK/cafe-restoran-pos/actions)

1. Yukarıdaki linke tıklayın
2. En üstteki **yeşil ✓** işaretli workflow'a tıklayın
3. Aşağı kaydırın → **Artifacts** bölümünden indirin:
   - **MenuSoft-Complete-Package.zip** (Tam Paket - Önerilen)
   - **MenuSoft-POS.zip** (Sadece POS Uygulaması)
   - **MenuSoft-LicenseManager.zip** (Sadece Lisans Yönetimi)

---

## 🚀 Kurulum (3 Adım)

### 1️⃣ İndirin ve Çıkartın
```
MenuSoft-Complete-Package.zip dosyasını indirin
Sağ tık → "Tümünü Ayıkla" (Extract All)
```

### 2️⃣ Çalıştırın
```
MenuSoft-POS klasörüne girin
CafeRestaurantPOS.exe'ye çift tıklayın
```

### 3️⃣ Lisans Alın
```
Cihaz ID'nizi kopyalayın
📞 0 552 165 04 35 numaralı telefonu arayın
Aldığınız lisansı girin
```

---

## 📞 Destek ve Lisans

**📱 Telefon:** 0 552 165 04 35  
**⏰ Çalışma Saatleri:** Hafta içi 09:00 - 18:00

### Lisans Alma Süreci:
1. Programı çalıştırın
2. **Cihaz ID**'yi kopyalayın (otomatik gösterilir)
3. Yukarıdaki numarayı arayın
4. Cihaz ID'nizi iletin
5. **Ürün Kodu** ve **Lisans Numarası** alın
6. Programa girin → Aktive edin ✅

---

## ✨ Özellikler

### Faz 1 (Tamamlandı ✅)
- ✅ Modern card-based UI tasarımı
- ✅ Offline cihaz bazlı lisans sistemi (AES-256)
- ✅ Kullanıcı yönetimi
- ✅ SQLite veritabanı
- ✅ Custom kontroller
- ✅ Splash screen
- ✅ Otomatik build sistemi
- ✅ Hazır EXE dosyaları
- ✅ Hakkında penceresi

### Faz 2 (Planlanan)
- ⏳ Sipariş yönetimi
- ⏳ Menü yönetimi
- ⏳ Masa yönetimi
- ⏳ Raporlama

---

## 🎨 Ekran Görüntüleri

```
┌─────────────────────────────────────────┐
│         🍽️ Menü Soft                    │
│  Cafe Restoran Satış Sistemleri         │
│                                         │
│  [████████████░░░] Yükleniyor...        │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│  🔐 Lisans Aktivasyonu                  │
├─────────────────────────────────────────┤
│  Cihaz ID: E4A2-B1C3-D5F6...   [Kopyala]│
│                                         │
│  Ürün Kodu: [________________]          │
│  Lisans No:  [________________]          │
│                                         │
│  📞 0 552 165 04 35                     │
│                 [Aktive Et]             │
└─────────────────────────────────────────┘
```

---

## 💻 Geliştiriciler İçin

### Build

```bash
git clone https://github.com/BYIRMAK/cafe-restoran-pos.git
cd cafe-restoran-pos
nuget restore
msbuild CafeRestaurantPOS.sln /p:Configuration=Release
```

### Otomatik Build (GitHub Actions)

Her `main` branch'e push'ta:
- ✅ Otomatik derleme
- ✅ EXE dosyaları oluşturulur
- ✅ Artifacts'a yüklenir

---

## 📂 Proje Yapısı

```
cafe-restoran-pos/
├── .github/workflows/
│   └── build-and-release.yml     # Otomatik build
├── CafeRestaurantPOS/            # Ana uygulama
│   ├── Forms/
│   │   ├── SplashForm.cs
│   │   ├── LicenseActivationForm.cs
│   │   ├── LoginForm.cs
│   │   ├── MainForm.cs
│   │   └── AboutForm.cs          # Hakkında
│   ├── Controls/
│   ├── Services/
│   └── Models/
├── LicenseManager/               # Lisans yönetimi
└── README.md
```

---

## 🔐 Güvenlik

- AES-256 şifreleme
- SHA-256 hash
- Cihaz bazlı doğrulama
- Offline çalışma

---

## 🔑 Varsayılan Giriş Bilgileri

**Kullanıcı Adı:** `admin`  
**Şifre:** `admin123`

---

## 📜 Lisans

© 2026 Menü Soft - Tüm hakları saklıdır.

Bu yazılım ticari bir üründür.

---

## 🛠️ Destek

📞 **0 552 165 04 35**

Lisans, kurulum, teknik destek için arayın!

---

## 📊 Teknik Detaylar

### Technology Stack
- **Framework**: .NET Framework 4.7.2
- **UI**: Windows Forms
- **Database**: SQLite 3
- **Encryption**: AES-256, SHA-256
- **Language**: C# 7.3

### Dependencies
- System.Data.SQLite.Core (v1.0.118.0)
- System.Management (for hardware ID)

### Database Locations
- **POS Database**: `%AppData%\CafeRestaurantPOS\pos_database.db`
- **License DB**: `%AppData%\CafeRestaurantPOS_LicenseManager\license_manager.db`

---

**Built with ❤️ using C# WinForms**
