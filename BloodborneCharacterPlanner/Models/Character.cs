using BloodborneCharacterPlanner.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodborneCharacterPlanner.Models
{
    public class Character
    {
        public string? Name { get; set; }
        
        public int Id { get; set; }

        [Required]
        public AppUser? Creator { get; set; }
        public string? CreatorId { get; set; }
    }
}
