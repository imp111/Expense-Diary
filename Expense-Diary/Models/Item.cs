using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Expense_Diary.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Borrower:")]
        public string? Borrower { get; set; }

        [DisplayName("Lander:")]
        public string? Lander { get; set; }

        [DisplayName("Item Name:")]
        public string? ItemName { get; set; }
    }
}
