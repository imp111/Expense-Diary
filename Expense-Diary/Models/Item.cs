using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Expense_Diary.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public string? Borrower { get; set; }
        
        public string? Lander { get; set; }

        [DisplayName("Item Name")]
        public string? ItemName { get; set; }
    }
}
