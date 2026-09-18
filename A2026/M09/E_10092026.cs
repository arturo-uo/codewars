public partial class Ejercicios
{
	//10/09/2026
	//Count the number of Duplicates
	//Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.

	//Example
	//"abcde" -> 0 # no characters repeats more than once
	//"aabbcde" -> 2 # 'a' and 'b'
	//"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
	//"indivisibility" -> 1 # 'i' occurs six times
	//"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
	//"aA11" -> 2 # 'a' and '1'
	//"ABBA" -> 2 # 'A' and 'B' each occur twice

	//Mi solución
	public int DuplicateCount(string str)
	{
		char[] caracteres = str.ToLower().ToCharArray();
		List<string> repetidos = new List<string>();
		for (var i = 0; i < caracteres.Length; i++)
		{
			var r = caracteres.ToList().Where(a => a == caracteres[i]).Count();
			if (r >= 2)
			{
				if (!repetidos.Contains(caracteres[i].ToString()))
					repetidos.Add(caracteres[i].ToString());
			}
		}
		return repetidos.Count;
	}

	//Console.WriteLine(DuplicateCount("indivisibility").ToString());

	//La mejor solución
	public int DuplicateCount_Copilot(string str)
	{
		return str.ToLower().GroupBy(c => c).Count(g => g.Count() > 1);
	}
}