using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyFirstOwnProject.Models.Db
{
    /// <summary>
    /// класс контекста базы данных
    /// </summary>
    public class ApplicationDbContext: IdentityDbContext <User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        { 
            Database.EnsureCreated();
        }
    }
}
