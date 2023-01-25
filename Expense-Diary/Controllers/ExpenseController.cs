using Expense_Diary.Data;
using Microsoft.AspNetCore.Mvc;

namespace Expense_Diary.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext? _db;

        // Dependency Injection
        public ExpenseController(ApplicationDbContext? db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
