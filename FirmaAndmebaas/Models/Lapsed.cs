using System;
using System.ComponentModel.DataAnnotations;

namespace firmaAndmebaas.Models
{
    public class Lapsed
    {
        [Key]
        public int ChildID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public Employee Employee { get; set; }
    }
}