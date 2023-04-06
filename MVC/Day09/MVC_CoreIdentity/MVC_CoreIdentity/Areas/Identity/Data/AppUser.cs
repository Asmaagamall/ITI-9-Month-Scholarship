using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MVC_CoreIdentity.Areas.Identity.Data
{
    public class AppUser :IdentityUser
    {
        [MaxLength(50)]
        public string Name { get;set; }
    }
}
