using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace CafeRestaurantPOS.Services
{
    public class DeviceService
    {
        public static string GetDeviceId()
        {
            string cpuId = GetCpuId();
            string motherboardId = GetMotherboardId();
            string diskId = GetDiskId();

            string combined = $"{cpuId}-{motherboardId}-{diskId}";
            return GenerateHash(combined);
        }

        private static string GetCpuId()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");
                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["ProcessorId"]?.ToString() ?? "UNKNOWN_CPU";
                }
            }
            catch
            {
                return "UNKNOWN_CPU";
            }
            return "UNKNOWN_CPU";
        }

        private static string GetMotherboardId()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["SerialNumber"]?.ToString() ?? "UNKNOWN_MB";
                }
            }
            catch
            {
                return "UNKNOWN_MB";
            }
            return "UNKNOWN_MB";
        }

        private static string GetDiskId()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_DiskDrive");
                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["SerialNumber"]?.ToString()?.Trim() ?? "UNKNOWN_DISK";
                }
            }
            catch
            {
                return "UNKNOWN_DISK";
            }
            return "UNKNOWN_DISK";
        }

        private static string GenerateHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < 16; i++)
                {
                    builder.Append(bytes[i].ToString("X2"));
                }
                return builder.ToString();
            }
        }
    }
}
