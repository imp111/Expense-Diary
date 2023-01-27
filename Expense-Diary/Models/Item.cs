using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Expense_Diary.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Borrower:")]
        [Required]
        public string? Borrower { get; set; }

        [DisplayName("Lander:")]
        [Required]
        public string? Lander { get; set; }

        [DisplayName("Item Name:")]
        [Required]
        public string? ItemName { get; set; }
    }
}
