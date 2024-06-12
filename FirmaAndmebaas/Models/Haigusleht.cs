using firmaAndmebaas.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace firmaAndmebaas.Models
{
    public class Haigusleht
    {
        [Key]
        public int SickLeaveID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
    }
}