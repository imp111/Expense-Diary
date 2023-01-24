using Microsoft.AspNetCore.Mvc;
using Expense_Diary.Data;
using Expense_Diary.Models;

namespace Expense_Diary.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext? _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }
    }
}
