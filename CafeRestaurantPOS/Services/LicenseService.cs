using System;
using CafeRestaurantPOS.Models;

namespace CafeRestaurantPOS.Services
{
    public class LicenseService
    {
        public bool IsLicenseValid()
        {
            var license = DatabaseService.GetActiveLicense();
            if (license == null)
                return false;

            if (!license.IsActive)
                return false;

            if (license.ExpiresAt < DateTime.Now)
                return false;

            string currentDeviceId = DeviceService.GetDeviceId();
            if (license.DeviceId != currentDeviceId)
                return false;

            return true;
        }

        public bool ValidateLicenseKey(string licenseKey)
        {
            try
            {
                string decrypted = EncryptionService.Decrypt(licenseKey);
                if (string.IsNullOrEmpty(decrypted))
                    return false;

                string[] parts = decrypted.Split('|');
                if (parts.Length != 3)
                    return false;

                string deviceId = parts[0];
                DateTime expiryDate = DateTime.Parse(parts[1]);
                string signature = parts[2];

                string currentDeviceId = DeviceService.GetDeviceId();
                if (deviceId != currentDeviceId)
                    return false;

                if (expiryDate < DateTime.Now)
                    return false;

                string expectedSignature = EncryptionService.HashPassword($"{deviceId}{expiryDate:yyyy-MM-dd}");
                if (signature != expectedSignature)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void ActivateLicense(string licenseKey)
        {
            string decrypted = EncryptionService.Decrypt(licenseKey);
            string[] parts = decrypted.Split('|');

            var license = new License
            {
                LicenseKey = licenseKey,
                DeviceId = parts[0],
                ActivatedAt = DateTime.Now,
                ExpiresAt = DateTime.Parse(parts[1]),
                IsActive = true
            };

            DatabaseService.SaveLicense(license);
        }
    }
}
