//17/09/2026
//Complete the solution so that the function will break up camel casing, using a space between words.

//Example
//"camelCasing"  =>  "camel Casing"
//"identifier"   =>  "identifier"
//""             =>  ""
public partial class Ejercicios
{
	public string BreakCamelCase(string str)
	{
		string result = string.Empty;
		if (string.IsNullOrEmpty(str))
			return "";
		char[] chars = str.ToCharArray();
		for (var i = 0; i < chars.Length; i++)
		{
			if (chars[i].ToString().ToUpper() == chars[i].ToString())
				result += " " + chars[i].ToString();
			else
				result += chars[i].ToString();
		}
		return result;
	}
}
