using System.Text;

public partial class Ejercicios
{
	//15/06/2026
	//Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct. However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.

	//Your task is to write a function maskify, which changes all but the last four characters into '#'.

	//Examples (input --> output):
	//"4556364607935616"-- > "############5616"
	//     "64607935616"-- > "#######5616"
	//               "1"-- > "1"
	//                ""-- > ""

	//// "What was the name of your first pet?"
	//"Skippy"-- > "##ippy"
	//"Nananananananananananananananana Batman!"-- > "####################################man!"


	public string Maskify(string cc)
	{
		if (string.IsNullOrEmpty(cc))
			return string.Empty;
		if (cc.Length < 4)
			return cc;
		string result = string.Empty;
		int limit = cc.Length - 4;
		char[] chars = cc.ToCharArray();
		for (var i = 0; i < chars.Length; i++)
		{
			if (i < limit)
				result += "#";
			else
				result += chars[i].ToString();
		}
		return result;
	}


	//Versión mejorada(manteniendo tu enfoque)

	public string Maskify_v2(string cc)
	{
		if (string.IsNullOrEmpty(cc) || cc.Length <= 4)
			return cc;

		StringBuilder result = new StringBuilder();

		for (int i = 0; i < cc.Length; i++)
		{
			result.Append(i < cc.Length - 4 ? '#' : cc[i]);
		}

		return result.ToString();
	}

	//Solución más elegante usando new string
	//En entrevistas o en CodeWars suele gustar más esta solución:


	public string Maskify_v1(string cc)
	{
		if (string.IsNullOrEmpty(cc) || cc.Length <= 4)
			return cc;

		return new string('#', cc.Length - 4) + cc[^4..];
	}
}