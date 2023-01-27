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
        public IActionResult Create()
        {
            return View();
        }

        //POST-Create Item
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense obj)
        {
            if (ModelState.IsValid)
            {
                _db.Expense.Add(obj); // adds the obj to the database
                _db.SaveChanges(); // saves the changes

                return RedirectToAction("Index"); // starts the index action
            }

            return View(obj);
        }

        // GET-Delete Expense, works with the view
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Expense.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST-Delete Expense, works with the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteExpense(int? id)
        {
            var obj = _db.Expense.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.Expense.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET-Update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Expense.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST-Delete Expense, works with the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Expense obj)
        {
            if (ModelState.IsValid)
            {
                _db.Expense.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(obj);
        }
    }
}
