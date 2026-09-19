
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

//https://www.codewars.com/kata/54da539698b8a2ad76000228/train/csharp
// You live in the city of Cartesia where all roads are laid out in a perfect grid. You arrived ten minutes too early to an appointment, 
// so you decided to take the opportunity to go for a short walk. The city provides its citizens with a Walk Generating App on their phones -- 
// everytime you press the button it sends you an array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']). 
// You always walk only a single block for each letter (direction) and you know it takes you one minute to traverse one city block, so create a 
// function that will return true if the walk the app gives you will take you exactly ten minutes (you don't want to be early or late!) and will, 
// of course, return you to your starting point. Return false otherwise.
// Note: you will always receive a valid array containing a random assortment of direction letters ('n', 's', 'e', or 'w' only). 
// It will never give you an empty array (that's not a walk, that's standing still!).
  public bool IsValidWalk(string[] walk)
  {    
    int n = 0;
    int s = 0;
    int e = 0;
    int w = 0;
    if(walk.Length != 10)
      return false;
    for(var i = 0; i < walk.Length; i++)
    {
      if(walk[i] == "n")
        n++;      
      if(walk[i] == "s")
        s++;      
      if(walk[i] == "w")
        w++;      
      if(walk[i] == "e")
        e++;
    }
    int restNS = n - s;
    int restWE = w - e;
    if(restNS == 0 && restWE == 0)
      return true;
    return false;
  }
}


