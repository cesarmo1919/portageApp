using System;

namespace Domain
{
    public class Mission
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string BUnit { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public Guid IntermediateId { get; set; }
        public Intermediate Intermediate { get; set; }
        public decimal TJM { get; set; }
        public DateTime DateBeginContract { get; set; }
        public decimal MissionDurationMonths { get; set; }
        public bool IsRenewable { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}