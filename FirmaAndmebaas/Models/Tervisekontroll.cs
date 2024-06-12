using System;
using System.ComponentModel.DataAnnotations;
using firmaAndmebaas.Models;


namespace firmaAndmebaas.Models
{
    public class Tervisekontroll
    {
        [Key]
        public int HealthCheckID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime Status { get; set; }

        public Employee Employee { get; set; }
    }
}