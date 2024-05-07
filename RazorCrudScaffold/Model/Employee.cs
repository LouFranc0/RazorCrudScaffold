using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorCrudScaffold.Model
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [DisplayName("Name")]

        public string? Name { get; set; }

        [Required]
        public string? Surname { get; set; }

        [Required]
        public int Age { get; set; }
    }


}
