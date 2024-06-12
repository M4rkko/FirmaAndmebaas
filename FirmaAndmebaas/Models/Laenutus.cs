using firmaAndmebaas.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace firmaAndmebaas.Models
{
    public class Laenutus
    {
        [Key]
        public int LoanID { get; set; }
        public int ItemID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public LaenutatavadAsjad LaenutatavadAsjad { get; set; }
        public Employee Employee { get; set; }
    }
}
