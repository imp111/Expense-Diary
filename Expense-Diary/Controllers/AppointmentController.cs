using Microsoft.AspNetCore.Mvc;
using Expense_Diary.Models;
using System.Diagnostics;

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

        public IActionResult TestDb(int id)
        {
            return Ok($"Database id is: {id}");
        }
    }
}
