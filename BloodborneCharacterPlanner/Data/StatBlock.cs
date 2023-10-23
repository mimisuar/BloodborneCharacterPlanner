using BloodborneCharacterPlanner.Models;
using System.Runtime.InteropServices;

namespace BloodborneCharacterPlanner.Data;


public struct StatBlock
{
	public int Vit;
	public int End;
	public int Str;
	public int Skl;
	public int Blt;
	public int Arc;

	private static StatBlock MilquetoastBlock = new()
	{
		Vit = 11,
		End = 10,
		Str = 12,
		Skl = 10,
		Blt = 9,
		Arc = 8
	};

	private static StatBlock SurvivorBlock = new()
	{
		Vit = 14,
		End = 11,
		Str = 11,
		Skl = 10,
		Blt = 7,
		Arc = 7
	};

	private static StatBlock TroubleBlock = new()
	{
		Vit = 9,
		End = 14,
		Str = 9,
		Skl = 13,
		Blt = 6,
		Arc = 9
	};

	private static StatBlock ViolentBlock = new()
	{
		Vit = 12,
		End = 11,
		Str = 15,
		Skl = 9,
		Blt = 6,
		Arc = 7
	};

	private static StatBlock ProfessionalBlock = new()
	{
		Vit = 9,
		End = 12,
		Str = 9,
		Skl = 15,
		Blt = 7,
		Arc = 8
	};

	private static StatBlock MilitaryBlock = new()
	{
		Vit = 10,
		End = 10,
		Str = 14,
		Skl = 13,
		Blt = 7,
		Arc = 6
	};

	private static StatBlock NobleBlock = new()
	{
		Vit = 7,
		End = 8,
		Str = 9,
		Skl = 13,
		Blt = 14,
		Arc = 9
	};

	private static StatBlock CruelBlock = new()
	{
		Vit = 10,
		End = 12,
		Str = 10,
		Skl = 9,
		Blt = 5,
		Arc = 14
	};

	private static StatBlock WasteBlock = new()
	{
		Vit = 10,
		End = 9,
		Str = 10,
		Skl = 9,
		Blt = 7,
		Arc = 9
	};

	public static readonly Dictionary<BBCharacterOrigin, StatBlock> Blocks = new()
	{
		{ BBCharacterOrigin.Milquetoast, MilquetoastBlock },
		{ BBCharacterOrigin.LoneSurvivor, SurvivorBlock },
		{ BBCharacterOrigin.TroubledChildhood, TroubleBlock },
		{ BBCharacterOrigin.ViolentPast, ViolentBlock },
		{ BBCharacterOrigin.Professional, ProfessionalBlock },
		{ BBCharacterOrigin.MilitaryVeteran, MilitaryBlock },
		{ BBCharacterOrigin.NobleScion, NobleBlock },
		{ BBCharacterOrigin.CruelFate, CruelBlock },
		{ BBCharacterOrigin.WasteOfSkin, WasteBlock },
	};
}