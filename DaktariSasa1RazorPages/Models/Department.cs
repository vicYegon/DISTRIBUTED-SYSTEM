using System.ComponentModel.DataAnnotations;

namespace DaktariSasa1RazorPages.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
