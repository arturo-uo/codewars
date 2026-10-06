public partial class Ejercicios
{
	// 	In this kata we want to convert a string into an integer. The strings simply represent the numbers in words.

	// Examples:

	// "one" => 1
	// "twenty" => 20
	// "two hundred forty-six" => 246
	// "seven hundred eighty-three thousand nine hundred and nineteen" => 783919
	// Additional Notes:

	// The minimum number is "zero" (inclusively)
	// The maximum number, which must be supported is 1 million (inclusively)
	// The "and" in e.g. "one hundred and twenty-four" is optional, in some cases it's present and in others it's not
	// All tested numbers are valid, you don't need to validate them
	public int ParseInt(string s)
	{
		int n = 0;
		Dictionary<string, int> numbers = new Dictionary<string, int>();
		numbers.Add("zero", 0);
		numbers.Add("one", 1);
		numbers.Add("two", 2);
		numbers.Add("three", 3);
		numbers.Add("four", 4);
		numbers.Add("five", 5);
		numbers.Add("six", 6);
		numbers.Add("seven", 7);
		numbers.Add("eight", 8);
		numbers.Add("nine", 9);
		numbers.Add("ten", 10);
		numbers.Add("eleven", 11);
		numbers.Add("twelve", 12);
		numbers.Add("thirteen", 13);
		numbers.Add("fourteen", 14);
		numbers.Add("fifteen", 15);
		numbers.Add("sixteen", 16);
		numbers.Add("seventeen", 17);
		numbers.Add("eighteen", 18);
		numbers.Add("nineteen", 19);
		numbers.Add("twenty", 20);
		numbers.Add("thrity", 30);
		numbers.Add("forty", 40);
		numbers.Add("fifty", 50);
		numbers.Add("sixty", 60);
		numbers.Add("seventy", 70);
		numbers.Add("eighty", 80);
		numbers.Add("ninety", 90);

		string[] parts = s.Split(" ");
		string num = string.Empty;
		int temp = 0;
		for (var i = 0; i < parts.Length; i++)
		{
			if (parts[i] == "thousand")
			{
				int v = 0;
				if (int.TryParse(num, out v))
				{
					temp = v * 1000;
					num = temp.ToString();
				}
			}
			else if (parts[i] == "hundred")
			{
				int v = 0;
				if (int.TryParse(num, out v))
				{
					temp = v * 100;
					num = temp.ToString();
				}
			}
			else
			{
				int v = 0;
				if (numbers.TryGetValue(s, out v))
				{
					num = v.ToString();
				}
			}
		}
		return 0;
	}
}