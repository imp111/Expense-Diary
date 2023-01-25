using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Expense_Diary.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Expense Name")]
        public string? Name { get; set; }

        [DisplayName("Amount")]
        public double? Amount { get; set; }
    }
}
