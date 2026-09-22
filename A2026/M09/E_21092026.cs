using System;
public partial class Ejercicios
{
	// You will be given an array of numbers. You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.

	// Examples
	// [7, 1]  =>  [1, 7]
	// [5, 8, 6, 3, 4]  =>  [3, 8, 6, 5, 4]
	// [9, 8, 7, 6, 5, 4, 3, 2, 1, 0]  =>  [1, 8, 3, 6, 5, 4, 7, 2, 9, 0]
	//https://www.codewars.com/kata/578aa45ee9fd15ff4600090d/train/csharp
	public int[] SortArray(int[] array)
	{
		int[] original = new int[array.Length];
		int[] result = new int[array.Length];
		array.CopyTo(original, 0);
		Array.Sort(array);
		for (var i = 0; i < original.Length; i++)
		{
			int esPar = original[i] % 2;
			if(esPar == 0)
			{
				result[i] = original[i];
			}
			else
			{
				result[i] = -1;
			}
		}
		for (var i = 0; i < result.Length; i++)
		{
			if(result[i] == -1)
			{
				result[i] = array[i];
			}
		}
		return result;
	}
}