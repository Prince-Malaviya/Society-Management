using System.ComponentModel.DataAnnotations;

namespace SocietyMangement.Models
{
    public class VisitorModel
    {
        public int VisitorID { get; set; }
        public string VisitorName { get; set; }
        public string PhoneNumber { get; set; }
        public string WhomToMeet { get; set; }
        public string FlatType { get; set; }
        public string FlatNumber { get; set; } 
        public string VisitPurpose { get; set; }
        public DateTime EntryTime { get; set; } = DateTime.Now;
        public DateTime? ExitTime { get; set; }
        public string? Status { get; set; } = "In";
    }
    public class FlatByVisitorModel
    {
        public int FlatID { get; set; }
        public string? FlatNumber { get; set; }

    }
}
