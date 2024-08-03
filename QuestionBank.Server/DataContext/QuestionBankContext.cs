using Microsoft.EntityFrameworkCore;
using QuestionBank.Server.Model;

namespace QuestionBank.Server.DataContext
{
    public class QuestionBankContext: DbContext
    {
        public QuestionBankContext(DbContextOptions<QuestionBankContext> options) : base(options) { 

        }
        public DbSet<User> Users => Set<User>();

    }
}
