using BloodborneCharacterPlanner.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BloodborneCharacterPlanner.Models
{
    public enum BBCharacterOrigin
    {
        Milquetoast,
        LoneSurvivor,
        TroubledChildhood,
        ViolentPast,
        Professional,
        MilitaryVeteran,
        NobleScion,
        CruelFate,
        WasteOfSkin
    }

    public class BBCharacter
    {
		[Required]
        [StringLength(16)]
        public string? Name { get; set; }
        
        public int Id { get; set; }

        [Required]
        public AppUser? Creator { get; set; }
        [Required]
        public string? CreatorId { get; set; }

        [Range(0, 99)]
        public int Vitality { get; set; }
        [Range(0, 99)]
        public int Endurance { get; set; }
        [Range(0, 99)]
        public int Strength { get; set; }
		[Range(0, 99)]
		public int Skill { get; set; }
		[Range(0, 99)]
		public int Bloodtinge { get; set; }
		[Range(0, 99)]
		public int Arcane { get; set; }

        public BBCharacterOrigin Origin { get; set; }

        public int GetLevel()
        {
            return Vitality + Endurance + Strength + Skill + Bloodtinge + Arcane - 50;
        }
    }
}
