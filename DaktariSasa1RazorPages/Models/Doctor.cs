using System.ComponentModel.DataAnnotations;

namespace DaktariSasa1RazorPages.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string  Email { get; set; }

        public string Specialty { get; set; }
    }
}
