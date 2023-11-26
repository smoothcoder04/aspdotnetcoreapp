using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using People;

namespace Data
{
    internal class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        // Connect to database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=localhost;database=Mydb;trusted_connection=false;User Id=sa;Password=HelloWorld@123;Persist Security Info=False;Encrypt=False");
        }
    }
}