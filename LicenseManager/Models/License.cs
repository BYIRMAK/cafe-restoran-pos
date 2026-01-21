using System;

namespace LicenseManager.Models
{
    public class License
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string LicenseKey { get; set; }
        public string DeviceId { get; set; }
        public DateTime GeneratedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
        public bool IsActive { get; set; }
        public string CustomerName { get; set; }
    }
}
