using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Models
{
    public class AnotherTestModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
