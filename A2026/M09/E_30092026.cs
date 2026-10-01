public partial class Ejercicios
{
	//Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
	//https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp
	public int[] MoveZeroes(int[] arr)
	{
		int[] resultado = new int[arr.Length];
		for (int i = 0, j = 0; i < arr.Length; i++)
		{
			resultado[i] = 0;
			if (arr[i] != 0)
			{
				resultado[j] = arr[i];
				j++;
			}
		}
		return resultado;
	}

	//Write a function that takes a string input, and returns the first character that is not repeated anywhere in the string.

	// For example, if given the input "stress", the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.

	// As an added challenge, upper- and lowercase characters are considered the same character, but the function should return the correct case for the initial character. For example, the input "sTreSS" should return "T".

	// If a string contains only repeating characters, return an empty string ("");

	// Note: despite its name in some languages, your function should handle any Unicode codepoint:

	// "@#@@*"    --> "#"
	// "かか何"   --> "何"
	// "🐐🦊🐐" --> "🦊"
	//https://www.codewars.com/kata/52bc74d4ac05d0945d00054e/train/csharp
	public string FirstNonRepeatingLetter(string s)
	{
		char[] chars = s.ToCharArray();
		string resultado = string.Empty;
		for (var i = 0; i < chars.Length; i++)
		{
			var count = chars.Where(c => c.ToString().ToLower() == chars[i].ToString().ToLower()).Count();
			if (count == 1)
			{
				resultado = chars[i].ToString();
				break;
			}
		}
		return resultado;
	}
}