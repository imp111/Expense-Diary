using Expense_Diary.Data;
using Expense_Diary.Models;
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
            IEnumerable<Expense> objList = _db.Expense;
            return View(objList); // returns a view with all the items in the database
        }

        // GET-Create Item
        public IActionResult CreateExpense()
        {
            return View();
        }

        //POST-Create Item
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateExpense(Expense obj)
        {
            if (ModelState.IsValid)
            {
                _db.Expense.Add(obj); // adds the obj to the database
                _db.SaveChanges(); // saves the changes

                return RedirectToAction("Index"); // starts the index action
            }

            return View(obj);
        }
    }
}
