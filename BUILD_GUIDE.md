# Build and Run Guide

## 📋 Prerequisites

- Visual Studio 2019 or later (with .NET Framework 4.7.2 SDK)
- Windows OS (Windows 10/11 recommended)
- SQLite support (included via NuGet)

## 🔧 Building the Solution

### Option 1: Visual Studio GUI

1. Open Visual Studio
2. File → Open → Project/Solution
3. Navigate to and select `CafeRestaurantPOS.sln`
4. Wait for NuGet packages to restore (may take a few seconds)
5. Build → Build Solution (or press Ctrl+Shift+B)

### Option 2: Command Line (MSBuild)

```bash
# Navigate to solution directory
cd /path/to/cafe-restoran-pos

# Restore NuGet packages
nuget restore CafeRestaurantPOS.sln

# Build the solution
msbuild CafeRestaurantPOS.sln /p:Configuration=Release
```

## 🚀 Running the Applications

### Running License Manager

**Via Visual Studio:**
1. Right-click on `LicenseManager` project in Solution Explorer
2. Select "Set as Startup Project"
3. Press F5 or click "Start"

**Via Command Line:**
```bash
cd LicenseManager/bin/Debug
./LicenseManager.exe
```

### Running Main POS Application

**Via Visual Studio:**
1. Right-click on `CafeRestaurantPOS` project in Solution Explorer
2. Select "Set as Startup Project"
3. Press F5 or click "Start"

**Via Command Line:**
```bash
cd CafeRestaurantPOS/bin/Debug
./CafeRestaurantPOS.exe
```

## 📝 Step-by-Step Usage Guide

### First Time Setup

#### Step 1: Generate Your First License

1. **Start License Manager**
   ```
   Run LicenseManager.exe
   ```

2. **Add a Customer**
   - Click on "Customers" tab
   - Click "Add Customer" button
   - Fill in the form:
     * Business Name: (e.g., "My Cafe")
     * Contact Person: (e.g., "John Doe")
     * Email: (optional)
     * Phone: (optional)
     * Address: (optional)
   - Click "Save"

3. **Run POS App to Get Device ID**
   - Run CafeRestaurantPOS.exe
   - Splash screen appears briefly
   - License Activation form appears
   - **COPY** the Device ID shown in the text box
   - Keep this window open or note down the Device ID

4. **Generate License**
   - Return to License Manager
   - Select the customer you created
   - Click "Licenses" tab
   - Click "Generate License" button
   - **PASTE** the Device ID you copied
   - Set validity days (default: 365)
   - Click "Generate License"
   - **COPY** the generated license key

5. **Activate POS License**
   - Return to POS License Activation form
   - **PASTE** the license key
   - Click "Activate License"
   - Success message appears
   - License Activation form closes

#### Step 2: Login to POS

1. Login form appears automatically
2. Enter default credentials:
   - Username: `admin`
   - Password: `admin123`
3. Click "Login"
4. Main dashboard appears

#### Step 3: Explore the Dashboard

- Navigation sidebar on the left
- Main content area shows welcome card
- Click menu items (Orders, Menu, Tables, Reports, Settings)
- Note: These features show "Coming Soon" messages (Phase 2)

## 🛠️ Troubleshooting

### Build Errors

**Problem**: "System.Data.SQLite not found"
```bash
# Solution: Restore NuGet packages
Tools → NuGet Package Manager → Restore NuGet Packages
```

**Problem**: "Target Framework not installed"
```bash
# Solution: Install .NET Framework 4.7.2 SDK
# Download from: https://dotnet.microsoft.com/download/dotnet-framework/net472
```

### Runtime Errors

**Problem**: "Database file not found"
```bash
# Solution: Check AppData folder
# Database auto-creates on first run
# Location: %AppData%\CafeRestaurantPOS\pos_database.db
```

**Problem**: "Invalid license key"
```bash
# Make sure you:
# 1. Copied the EXACT Device ID (no spaces)
# 2. Generated license for that specific Device ID
# 3. Copied the complete license key
```

**Problem**: "Login failed"
```bash
# Default credentials:
# Username: admin
# Password: admin123
# (case-sensitive)
```

## 📂 File Locations

### Application Files
```
Debug Build:
- CafeRestaurantPOS/bin/Debug/CafeRestaurantPOS.exe
- LicenseManager/bin/Debug/LicenseManager.exe

Release Build:
- CafeRestaurantPOS/bin/Release/CafeRestaurantPOS.exe
- LicenseManager/bin/Release/LicenseManager.exe
```

### Database Files (Auto-created)
```
POS Database:
%AppData%\CafeRestaurantPOS\pos_database.db

License Manager Database:
%AppData%\CafeRestaurantPOS_LicenseManager\license_manager.db
```

On Windows, %AppData% typically resolves to:
```
C:\Users\{YourUsername}\AppData\Roaming\
```

## 🔄 Resetting the Application

### Reset POS Database
```bash
# Delete database file
del "%AppData%\CafeRestaurantPOS\pos_database.db"

# Next run will recreate with default admin account
```

### Reset License Manager Database
```bash
# Delete database file
del "%AppData%\CafeRestaurantPOS_LicenseManager\license_manager.db"

# Next run will recreate empty database
```

## 📊 Testing Checklist

- [ ] Build solution successfully
- [ ] No build warnings or errors
- [ ] LicenseManager starts without errors
- [ ] Can add a customer
- [ ] Can view customers in grid
- [ ] POS app shows splash screen
- [ ] Can see Device ID in activation form
- [ ] Can generate license with Device ID
- [ ] Can copy license key
- [ ] Can activate license in POS
- [ ] Login form appears after activation
- [ ] Can login with admin/admin123
- [ ] Main dashboard loads correctly
- [ ] Can navigate sidebar menu
- [ ] Can close and restart POS (license persists)

## 💡 Tips

1. **Development Mode**: Use Debug configuration for testing
2. **Production Mode**: Use Release configuration for deployment
3. **Multiple Devices**: Each device needs its own license
4. **Backup**: Keep the License Manager database backed up
5. **Device ID**: Changes if hardware changes significantly

## 🎓 Common Workflows

### Workflow 1: New Installation
```
1. Install application on new PC
2. Run POS app → Get Device ID
3. Run License Manager → Add customer
4. Generate license with Device ID
5. Activate license in POS app
6. Login and use
```

### Workflow 2: License Renewal
```
1. Get Device ID from POS app
2. Run License Manager
3. Find customer
4. Generate new license (extended validity)
5. Activate new license in POS app
```

### Workflow 3: Multiple Locations
```
1. Install on Location 1 → Get Device ID 1
2. Install on Location 2 → Get Device ID 2
3. Add Customer (Location 1)
4. Add Customer (Location 2)
5. Generate License 1 with Device ID 1
6. Generate License 2 with Device ID 2
7. Activate each license on respective PCs
```

## 📞 Support

For issues or questions:
1. Check PHASE1_SUMMARY.md for feature list
2. Check README.md for architecture details
3. Review this BUILD_GUIDE.md for common issues

---

**Happy Building! 🚀**
