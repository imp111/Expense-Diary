using Expense_Diary.Models;
using Microsoft.EntityFrameworkCore;

namespace Expense_Diary.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Item>? Items { get; set; } // Items Database
        public DbSet<Expense>? Expense { get; set; } // Expenses Database
    }
}
