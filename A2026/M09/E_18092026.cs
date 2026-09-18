// Your task is to construct a building which will be a pile of n cubes. The cube at the bottom will have a 
// volume of n3n 3 , the cube above will have volume of (n−1)3(n−1) 3  and so on until the top which will have a volume of 
// 131 3 .

// You are given the total volume m of the building. Being given m can you find the number n of cubes you will have to build?

// The parameter of the function findNb (find_nb, find-nb, findNb, ...) will be an integer m and you have to return the integer n such as 
// n3+(n−1)3+(n−2)3+...+13=mn 3 +(n−1) 3 +(n−2) 3 +...+1 3
//  =m if such a n exists or -1 if there is no such n.

// Examples:
// findNb(1071225) --> 45

// findNb(91716553919377) --> -1
//https://www.codewars.com/kata/5592e3bd57b64d00f3000047/train/csharp
public partial class Ejercicios
{
  public long findNb(long m)
  {
    long[] pows = new long[500000];
	for(var i = 0; i < pows.Length; i++)
    {
      if(i > 1)
        pows[i] = (long)Math.Pow(i, 3);
      else if (i == 1)
        pows[i] = 1;
      else if (i == 0)
        pows[i] = 0;
    }
    long sum = 0;
    int result = 0;
    for(var i = 0; i < pows.Length; i++)
    {
      sum += pows[i];
      if(sum == m)
      {
        result = i;
        break;
      }
      if(sum > m)
      {
        result = -1;
        break;
      }
    }
    return result;
	}
}