using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models.Entites;

namespace StudentPortal.Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { 

        }

        public DbSet<Student> Students { get; set; }
    }
}
