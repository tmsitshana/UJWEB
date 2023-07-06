using Microsoft.AspNetCore.Mvc;

namespace MVCWebAppTest.Controllers
{
    public class UserController : Controller
    {
        private readonly IConfiguration _config;
        public UserController()
        {
           
        }
        public async Task<IActionResult> UsersDashboard()
        {
         
            return View();
        }
    }
}
