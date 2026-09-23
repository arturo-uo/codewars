
using System.ComponentModel.DataAnnotations;

public partial class Ejercicios
{
	// 	Complete the solution so that it splits the string into strings of two characters in a list/array (depending on the language you use). If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').
	// Examples:
	// * 'abc' =>  ['ab', 'c_']
	// * 'abcdef' => ['ab', 'cd', 'ef']
	//https://www.codewars.com/kata/515de9ae9dcfc28eb6000001/train/csharp
	public string[] Solution(string str)
	{
		if (str.Length % 2 != 0)
		{
			str = str + "_";
		}
		string[] res = new string[str.Length / 2];
		char[] chars = str.ToCharArray();
		int contador = 0;
		for(var i = 0; i < chars.Length; i++)
		{
			if(i % 2 != 0)
			{				
				res[contador] = chars[i - 1].ToString() + chars[i].ToString();
				contador++;
			}
		}
		return res;
	}
}