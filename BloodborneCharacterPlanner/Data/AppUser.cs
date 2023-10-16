using BloodborneCharacterPlanner.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections;

namespace BloodborneCharacterPlanner.Data
{
    public class AppUser : IdentityUser
    {
        public ICollection<Character>? Characters { get; set; }

    }
}
