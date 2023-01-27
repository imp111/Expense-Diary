using Microsoft.AspNetCore.Mvc;
using Expense_Diary.Data;
using Expense_Diary.Models;

namespace Expense_Diary.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext? _db;

        // Dependency Injection
        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Index Page - return all items in the database
        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
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
        public IActionResult Create(Item obj)
        {
            if (ModelState.IsValid)
            {
                _db.Items.Add(obj); // adds the obj to the database
                _db.SaveChanges(); // saves the changes

                return RedirectToAction("Index"); // starts the index action
            }

            return View(obj);
        }

        // GET Delete action
        public IActionResult Delete(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            var obj = _db.Items.Find(id);

            if (obj== null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST Delete action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteItem(int? id)
        {
            var obj = _db.Items.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.Items.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET Delete action
        public IActionResult Update(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            var obj = _db.Items.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST-Update Item
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Item obj)
        {
            if (ModelState.IsValid)
            {
                _db.Items.Update(obj); // adds the obj to the database
                _db.SaveChanges(); // saves the changes

                return RedirectToAction("Index"); // starts the index action
            }

            return View(obj);
        }
    }
}
