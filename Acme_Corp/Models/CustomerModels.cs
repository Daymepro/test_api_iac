using System;
namespace Acme_Corp.Models
{
    // Customer.cs
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        
        public List<ContactInfo>? ContactInfos { get; set; }
        public List<Order>? Orders { get; set; }
    }

    
    public class ContactInfo
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        
    }

    
    public class Order
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
    }

}

