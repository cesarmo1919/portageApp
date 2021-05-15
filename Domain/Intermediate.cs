using System;
using System.Collections.Generic;

namespace Domain
{
    public class Intermediate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Mission> Missions { get; set; } = new List<Mission>();
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}