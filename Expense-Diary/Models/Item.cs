using System.ComponentModel.DataAnnotations;

namespace Expense_Diary.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public string? Borrower { get; set; }
    }
}
