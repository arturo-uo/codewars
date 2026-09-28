public partial class Ejercicios
{
	//https://www.codewars.com/kata/530e15517bc88ac656000716/train/csharp
	// ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. ROT13 is an example of the Caesar cipher.

	// Create a function that takes a string and returns the string ciphered with Rot13.

	// If there are nonletter characters in the string, they should be left as-is in the output. Only letters from the ASCII alphabet should be shifted, like in the original Rot13 "implementation".
	public string Rot13(string message)
	{
		char[] upperAlphabet = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
		char[] lowerAlphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
		char[] letters = message.ToCharArray();
		char[] result = new char[message.Length];
		int indice = 0;
		int nuevaPosicion = 0;
		for (var i = 0; i < letters.Length; i++)
		{
			if (!Char.IsLetter(letters[i]))
				result[i] = letters[i];
			else
			{
				if (Char.IsUpper(letters[i]))
					indice = Array.IndexOf(upperAlphabet, letters[i]);
				else
					indice = Array.IndexOf(lowerAlphabet, letters[i]);

				nuevaPosicion = (indice + 13) % 26;
				if (Char.IsUpper(letters[i]))
					result[i] = upperAlphabet[nuevaPosicion];
				else
					result[i] = lowerAlphabet[nuevaPosicion];
			}
		}
		return new string(result);
		// your code here
	}
}