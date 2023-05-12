namespace DaktariSasa1RazorPages.Models
{
    public class Appointment
    {
        public int Id { get; set; } 

        public string Full_Name { get; set; }

        public string email { get; set; }

        public int PhoneNumber { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string message { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }  

        public int DepartmentId { get; set; }   
        public Department Department { get; set; }

    }
}
