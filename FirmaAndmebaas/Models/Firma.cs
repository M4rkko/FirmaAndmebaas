using System.ComponentModel.DataAnnotations;

namespace firmaAndmebaas.Models
{
    public class Firma
    {
        [Key]
        public int FirmaID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Industry { get; set; }
        public string Size { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}