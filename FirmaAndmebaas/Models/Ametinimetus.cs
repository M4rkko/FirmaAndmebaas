using System.ComponentModel.DataAnnotations;

namespace firmaAndmebaas.Models
{
    public class Ametinimetus
    {
        [Key]
        public int PositionID { get; set; }
        public string Title { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}