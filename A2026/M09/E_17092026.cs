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


// Write a function that takes a string of braces, and determines if the order of the braces is valid. It should return true if the string is valid, and false if it's invalid.

// This Kata is similar to the Valid Parentheses Kata, but introduces new characters: brackets [], and curly braces {}. Thanks to @arnedag for the idea!

// All input strings will be nonempty, and will only consist of parentheses, brackets and curly braces: ()[]{}.

// What is considered Valid?
// A string of braces is considered valid if all braces are matched with the correct brace.

// Examples
// "(){}[]"   =>  True
// "([{}])"   =>  True
// "(}"       =>  False
// "[(])"     =>  False
// "[({})](]" =>  False