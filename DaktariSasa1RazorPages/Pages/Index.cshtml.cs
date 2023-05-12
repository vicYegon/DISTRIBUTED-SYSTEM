using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace DaktariSasa1RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MySqlConnection _connection;

        public IndexModel(ILogger<IndexModel> logger, MySqlConnection connection)
        {
            _logger = logger;
            _connection = connection;
        }


        public void OnGet()
        {

        }
    }
}