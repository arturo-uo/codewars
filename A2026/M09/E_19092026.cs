
public partial class Ejercicios
{
  ///// Given a list of integers, determine whether the sum of its elements is odd or even.

  // Give your answer as a string matching "odd" or "even".

  // If the input array is empty consider it as: [0] (array with a zero).

  // Examples:
  // Input: [0]
  // Output: "even"

  // Input: [0, 1, 4]
  // Output: "odd"

  // Input: [0, -1, -5]
  // Output: "even" 
  public string OddOrEven(int[] array)
  {
    int sum = 0;
    if (array.Length <= 0)
      return "even";
    for (var i = 0; i < array.Length; i++)
    {
      sum += array[i];
    }
    if (sum % 2 == 0)
      return "even";
    else
      return "odd";
  }

  //Sin resolver
  // Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced. The input will be a non-negative integer.

  // Examples
  //     16  -->  1 + 6 = 7
  //    942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
  // 132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
  // 493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2
  //https://www.codewars.com/kata/541c8630095125aba6000c00/train/csharp
  public int DigitalRoot(long n)
  {
    int suma = 0;
    if (n < 10)
      return (int)n;
    if (n > 9)
    {
      char[] numeros = n.ToString().ToCharArray();
      while (numeros.Length > 1)
      {
        suma = numeros.Sum(nu => int.Parse(nu.ToString()));
        numeros = suma.ToString().ToCharArray();
      }
    }
    return suma;
  }
}


