using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace DaktariSasa1RazorPages.Pages
{
    public class PatientModel : PageModel
    {
        private readonly MySqlConnection _connection;

        public PatientModel(MySqlConnection connection)
        {
            _connection = connection;
        }

        public void OnGet()
        {
        }
    }
}
