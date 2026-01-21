using System;

namespace CafeRestaurantPOS.Models
{
    public class License
    {
        public int Id { get; set; }
        public string LicenseKey { get; set; }
        public string DeviceId { get; set; }
        public DateTime ActivatedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
        public bool IsActive { get; set; }
    }
}
