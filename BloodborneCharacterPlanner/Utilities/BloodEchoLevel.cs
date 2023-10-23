using System.Collections.Generic;
namespace BloodborneCharacterPlanner.Utilities;
public static class BloodEchoLevel
{
	/// <summary>
	/// The formula to get from blood level to index is: bloodLevel - 5
	/// </summary>
	public static int[] BloodEchoSums = new int[540];

	/// <summary>
	/// Returns the amount of blood echoes needed to go from <paramref name="targetLevel"/> - 1 to <paramref name="targetLevel"/>. 
	/// Minimum input is 5 (since 4 is the minimum level in Bloodborne)
	/// </summary>
	/// <param name="currentLevel"></param>
	/// <returns></returns>
	/// <exception cref="ArgumentException"><paramref name="targetLevel"/> is outside the valid range of [5, 544]</exception>
	public static int GetBloodEchoCostForLevel(int targetLevel)
	{
		if (targetLevel > 544)
		{
			throw new ArgumentException("targetLevel maximum is 544");
		}
		else if (targetLevel > 12)
		{
			return (int)(0.02f * targetLevel * targetLevel * targetLevel + 3.06f * targetLevel * targetLevel + 105.6f * targetLevel - 895);
		}
		else
		{
			switch (targetLevel)
			{
				case 12:
					return 847;

				case 11:
					return 829;

				case 10:
					return 811;

				case 9:
					return 793;

				case 8:
					return 775;

				case 7:
					return 758;

				case 6:
					return 741;

				case 5:
					return 724;
			}
		}

		throw new ArgumentException("targetLevel minimum is 5");
	}

	public static int GetBloodEchoSum(int targetBloodLevel)
	{
		if (targetBloodLevel < 5 || targetBloodLevel > 544)
		{
			throw new ArgumentException("targetLevel must be in range [5, 544]");
		}

		int index = targetBloodLevel - 5;
		if (index == 0)
		{
			BloodEchoSums[0] = GetBloodEchoCostForLevel(5);
			return BloodEchoSums[0];
		}

		if (BloodEchoSums[index] == 0)
		{
			int firstKnownIndex = index - 1;
			while (firstKnownIndex > 0 && BloodEchoSums[firstKnownIndex] == 0)
			{
				firstKnownIndex--;
			}

			int sumTracker = BloodEchoSums[firstKnownIndex];
			for (int i = firstKnownIndex + 1; i <= index; i++)
			{
				sumTracker += GetBloodEchoCostForLevel(i + 5);
				BloodEchoSums[i] = sumTracker;
			}
		}

		return BloodEchoSums[index];
	}
}