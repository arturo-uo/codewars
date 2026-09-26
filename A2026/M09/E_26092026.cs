
using System;
using System.Text.RegularExpressions;
public partial class Ejercicios
{
	public bool Alphanumeric(string str)
	{
		Regex regex = new Regex(@"^[a-zA-Z0-9]+$");
		if (!regex.IsMatch(str))
			return false;
		return true;
		// char[] chars = str.Trim().ToCharArray();
		// if(chars.Length == 0)
		// 	return false;
		// for (var i = 0; i < chars.Length; i++)
		// {
		// 	if (!Char.IsLetterOrDigit(chars[i]) || Char.IsWhiteSpace(chars[i]))
		// 		return false;
		// }
		// return true;
	}
}