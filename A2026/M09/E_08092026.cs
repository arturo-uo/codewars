public partial class Ejercicios
{
	// 	Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case). The next words should be always capitalized.

	// Examples
	// "the-stealth-warrior" gets converted to "theStealthWarrior"

	// "The_Stealth_Warrior" gets converted to "TheStealthWarrior"

	// "The_Stealth-Warrior" gets converted to "TheStealthWarrior"
	//https://www.codewars.com/kata/517abf86da9663f1d2000003/train/csharp
	public string ToCamelCase(string str)
	{
		char[] chars = str.ToCharArray();
		string resultado = string.Empty;
		bool convertirSiguiente = false;
		for (var i = 0; i < chars.Length; i++)
		{
			if (chars[i] != '_' && chars[i] != '-')
			{
				if (i == 0)
				{
					//if(!Char.IsUpper(chars[i]))
						resultado += chars[i];
				}
				else
				{
					if (!convertirSiguiente)
					{
						resultado += chars[i];
					}
					else
					{
						resultado += Char.ToUpper(chars[i]);
						convertirSiguiente = false;
					}
				}
			}
			else
			{
				convertirSiguiente = true;
			}
		}
		return resultado;
	}
}