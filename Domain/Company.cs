using System;
using System.Collections.Generic;

namespace Domain
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string BUnit { get; set; }
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}