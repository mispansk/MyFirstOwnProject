using Microsoft.AspNetCore.Identity;

namespace MyFirstOwnProject.Models.Db
{
    /// <summary>
    /// модель пользователя
    /// </summary>
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
