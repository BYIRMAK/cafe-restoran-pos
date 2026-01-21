# Cafe Restaurant POS System - Phase 1

A modern, feature-rich Point of Sale system for cafes and restaurants built with C# WinForms (.NET Framework 4.7.2).

## 🎯 Project Overview

This is Phase 1 of the Cafe Restaurant POS System, implementing the core infrastructure including:
- Modern UI with custom controls
- Offline licensing system with AES-256 encryption
- SQLite database integration
- User authentication
- Device-based license validation

## 📁 Project Structure

```
CafeRestaurantPOS.sln
├── CafeRestaurantPOS/          # Main POS Application
│   ├── Controls/               # Custom UI Controls
│   │   ├── ModernButton.cs
│   │   ├── ModernTextBox.cs
│   │   ├── ModernCard.cs
│   │   └── ModernTitleBar.cs
│   ├── Forms/                  # Application Forms
│   │   ├── SplashForm.cs
│   │   ├── LicenseActivationForm.cs
│   │   ├── LoginForm.cs
│   │   └── MainForm.cs
│   ├── Models/                 # Data Models
│   │   ├── User.cs
│   │   └── License.cs
│   └── Services/               # Business Logic
│       ├── DatabaseService.cs
│       ├── LicenseService.cs
│       ├── DeviceService.cs
│       └── EncryptionService.cs
│
└── LicenseManager/             # License Management Tool
    ├── Forms/
    │   ├── MainForm.cs
    │   ├── CustomerForm.cs
    │   └── LicenseGeneratorForm.cs
    ├── Models/
    │   ├── Customer.cs
    │   └── License.cs
    └── Services/
        ├── DatabaseService.cs
        └── EncryptionService.cs
```

## 🚀 Features Implemented

### Main POS Application
- ✅ **Splash Screen** with fade-in animation
- ✅ **License Activation** with device ID validation
- ✅ **User Login** with shake animation on error
- ✅ **Dashboard** with modern sidebar navigation
- ✅ **Custom Controls** with orange theme (#FF6B6B)
- ✅ **SQLite Database** stored in AppData
- ✅ **Offline Licensing** with AES-256 encryption

### License Manager Application
- ✅ **Customer Management** (Add/View customers)
- ✅ **License Generation** with device ID binding
- ✅ **License Tracking** (View all generated licenses)
- ✅ **Validity Configuration** (Set license expiry days)

## 🔐 Security Features

1. **AES-256 Encryption** for license keys
2. **SHA-256 Hashing** for passwords
3. **Device ID Generation** based on:
   - CPU Serial Number
   - Motherboard Serial Number
   - Hard Disk Serial Number
4. **Signature Validation** to prevent license tampering

## 🎨 UI/UX Features

- **Modern Design** with card-based layout
- **Orange Color Scheme** (#FF6B6B)
- **Rounded Corners** on all controls
- **Smooth Animations**:
  - Fade-in for splash screen
  - Shake animation for validation errors
- **Custom Title Bar** with drag functionality
- **Hover Effects** on buttons
- **Focus Indicators** on text boxes

## 📊 Database Schema

### Users Table
```sql
- Id (INTEGER PRIMARY KEY)
- Username (TEXT)
- Password (TEXT, SHA-256 hashed)
- FullName (TEXT)
- Role (TEXT)
- IsActive (INTEGER)
- CreatedAt (TEXT)
```

### Licenses Table (POS App)
```sql
- Id (INTEGER PRIMARY KEY)
- LicenseKey (TEXT, AES-256 encrypted)
- DeviceId (TEXT)
- ActivatedAt (TEXT)
- ExpiresAt (TEXT)
- IsActive (INTEGER)
```

### Customers Table (License Manager)
```sql
- Id (INTEGER PRIMARY KEY)
- BusinessName (TEXT)
- ContactPerson (TEXT)
- Email (TEXT)
- Phone (TEXT)
- Address (TEXT)
- CreatedAt (TEXT)
```

### Licenses Table (License Manager)
```sql
- Id (INTEGER PRIMARY KEY)
- CustomerId (INTEGER)
- LicenseKey (TEXT)
- DeviceId (TEXT)
- GeneratedAt (TEXT)
- ExpiresAt (TEXT)
- IsActive (INTEGER)
```

## 🔧 Technology Stack

- **Framework**: .NET Framework 4.7.2
- **UI**: Windows Forms
- **Database**: SQLite 3
- **Encryption**: AES-256, SHA-256
- **Language**: C# 7.3

## 📦 Dependencies

- System.Data.SQLite.Core (v1.0.118.0)
- System.Management (for hardware ID)

## 🏃 How to Run

1. Open `CafeRestaurantPOS.sln` in Visual Studio 2019 or later
2. Restore NuGet packages
3. Build the solution
4. Run **LicenseManager** project first to generate licenses
5. Run **CafeRestaurantPOS** project to use the POS system

## 🔑 Default Credentials

**Username**: `admin`  
**Password**: `admin123`

## 📝 License Activation Flow

1. Run the POS application
2. If no valid license, License Activation form appears
3. Copy the Device ID from the form
4. Open License Manager application
5. Add a customer
6. Select the customer and click "Generate License"
7. Paste the Device ID
8. Set validity period (default: 365 days)
9. Click "Generate License"
10. Copy the generated license key
11. Paste it in the POS License Activation form
12. Click "Activate License"

## 🗺️ Future Phases

- **Phase 2**: Core POS functionality (Orders, Menu, Tables)
- **Phase 3**: Inventory Management
- **Phase 4**: Reporting and Analytics
- **Phase 5**: Kitchen Display System
- **Phase 6**: Multi-location Support

## 📄 File Locations

- **POS Database**: `%AppData%\CafeRestaurantPOS\pos_database.db`
- **License DB**: `%AppData%\CafeRestaurantPOS_LicenseManager\license_manager.db`

## 🎯 Key Highlights

- ✨ Modern, clean UI inspired by Dribbble designs
- 🔒 Robust offline licensing system
- 💾 SQLite for zero-configuration database
- 🎨 Consistent orange theme throughout
- 🚀 Smooth animations and transitions
- 📱 Responsive layout design
- 🛡️ Enterprise-grade security

## 👨‍💻 Development Notes

- All custom controls inherit from base WinForms controls
- Graphics use anti-aliasing for smooth rendering
- Database connections use proper disposal patterns
- Passwords are never stored in plain text
- License keys are encrypted before storage

---

**Built with ❤️ using C# WinForms**
