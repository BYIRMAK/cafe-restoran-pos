using System;

namespace LicenseManager.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
