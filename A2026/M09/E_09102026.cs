public partial class Ejercicios
{
	//09/09/2026
	//Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.

	//Examples:
	//Input: 42145 Output: 54421
	//Input: 145263 Output: 654321
	//Input: 123456789 Output: 987654321

	//Mi solución
	public int DescendingOrder(int num)
	{
		string nums = num.ToString();
		string[] numeros = new string[num.ToString().Length];
		for (var i = 0; i < nums.Length; i++)
		{
			numeros[i] = nums[i].ToString();
		}
		var res = numeros.ToList().OrderBy(r => r).ToArray();
		string resultado = string.Empty;
		for (var i = 0; i < numeros.Length; i++)
		{
			resultado += numeros[i];
		}
		int numeroResultado = int.Parse(resultado);
		// Bust a move right here
		return numeroResultado;
	}

	//Console.WriteLine(DescendingOrder(123456789).ToString());

	//La mejor solución
	public int DescendingOrder_Copilot(int num)

	{
		string resultado = string.Concat(num.ToString().OrderByDescending(c => c));
		return int.Parse(resultado);
	}
}