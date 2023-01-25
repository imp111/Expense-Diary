using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Expense_Diary.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Expense Name:")]
        [Required]
        public string? Name { get; set; }

        [DisplayName("Amount:")]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0.01")]
        public double? Amount { get; set; }
    }
}
