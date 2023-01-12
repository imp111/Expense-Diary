using Microsoft.AspNetCore.Mvc;

namespace Expense_Diary.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TestId(int id)
        {
            return Ok($"Id is {id}");
        }
    }
}
