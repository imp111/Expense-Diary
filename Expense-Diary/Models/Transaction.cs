using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Diary.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        // Foreign Key CategoryId
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public double Amount { get; set; } // amount of money spent

        [Column(TypeName = "nvarchar(50)")]
        public string? Note { get; set; } // description of what the money was spent on

        public DateTime date { get; set; } = DateTime.Now;
    }
}
