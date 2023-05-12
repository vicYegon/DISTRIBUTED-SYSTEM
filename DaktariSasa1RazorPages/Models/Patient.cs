using System.ComponentModel.DataAnnotations;

namespace DaktariSasa1RazorPages.Models
{
    public class Patient
    {
        [Key]
       public int Id { get; set; }

        public String fullName { get; set; }

       
        public string address { get; set; }

        public string phoneNumber { get; set; }

        public int  age { get; set; }
        
        public string email { get; set; }    


    }
}
