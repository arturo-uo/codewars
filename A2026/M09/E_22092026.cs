//https://www.codewars.com/kata/52685f7382004e774f0001f7/train/csharp
// Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

// HH = hours, padded to 2 digits, range: 00 - 99
// MM = minutes, padded to 2 digits, range: 00 - 59
// SS = seconds, padded to 2 digits, range: 00 - 59
// The maximum time never exceeds 359999 (99:59:59)
public partial class Ejercicios
{
	public string GetReadableTime(int seconds)
	{
		int hh = 0;
		int mm = 0;
		int ss = 0;
		int resH = 0;
		int resM = 0;

		if (seconds > 359999)
			return "00:00:00";
		if (seconds < 60)
			return $"00:00:{String.Format("{0:00}", seconds)}";

		mm = seconds / 60;
		if(mm > 60)
		{
			hh = mm / 60;
			resH = mm % 60;			
			resM = seconds % 60;
			return $"{String.Format("{0:00}", hh)}:{String.Format("{0:00}", resH)}:{String.Format("{0:00}", resM)}";
		}
		else
		{	
			resM = mm % 60;
			if(mm == 60)
				return $"01:00:00";
			else
			{
				ss = seconds % 60;				
				return $"00:{String.Format("{0:00}", resM)}:{String.Format("{0:00}", ss)}";
			}
		}
	}
}