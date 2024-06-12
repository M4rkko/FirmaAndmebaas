using firmaAndmebaas.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace firmaAndmebaas.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PositionID { get; set; }
        public int VacationDays { get; set; }
        public int SickLeave { get; set; }
        public string HealthStatus { get; set; }
        public string AccessRights { get; set; }
        public int FirmaID { get; set; }

        public Ametinimetus Position { get; set; }
        public Firma Firma { get; set; }

        public ICollection<Tervisekontroll> Tervisekontrollid { get; set; }
        public ICollection<Laenutus> Laenutused { get; set; }
        public ICollection<Puhkepäevad> Puhkepäevad { get; set; }
        public ICollection<Haigusleht> Haiguslehed { get; set; }
        public ICollection<Ligipääasuluba> Ligipääasuload { get; set; }
    }
}