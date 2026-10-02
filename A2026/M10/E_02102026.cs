public partial class Ejercicios
{
	// 	Create a function that takes a positive integer and returns the next bigger number that can be formed by rearranging its digits. For example:

	//   12 ==> 21
	//  513 ==> 531
	// 2017 ==> 2071
	// If the digits can't be rearranged to form a bigger number, return -1 (or nil in Swift, None in Rust):

	//   9 ==> -1
	// 111 ==> -1
	// 531 ==> -1
	public long NextBiggerNumber(long n)
    {
      char[] numeros = n.ToString().ToCharArray();
      var numerosOrdenados = numeros.OrderByDescending(n => n).ToArray();
      long numero = int.Parse(new string(numerosOrdenados));
      if(numero < n)
        return -1;
      return numero;
    }
}