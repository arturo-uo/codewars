
using System;
using System.Text.RegularExpressions;
public partial class Ejercicios
{
	public bool Alphanumeric(string str)
	{
		Regex regex = new Regex(@"^[a-zA-Z0-9]+$");
		if (!regex.IsMatch(str))
			return false;
		return true;
		// char[] chars = str.Trim().ToCharArray();
		// if(chars.Length == 0)
		// 	return false;
		// for (var i = 0; i < chars.Length; i++)
		// {
		// 	if (!Char.IsLetterOrDigit(chars[i]) || Char.IsWhiteSpace(chars[i]))
		// 		return false;
		// }
		// return true;
	}

	// 	Snail Sort
	// Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.

	// array = [[1,2,3],
	//          [4,5,6],
	//          [7,8,9]]
	// snail(array) #=> [1,2,3,6,9,8,7,4,5]
	// For better understanding, please follow the numbers of the next array consecutively:

	// array = [[1,2,3],
	//          [8,9,4],
	//          [7,6,5]]
	// snail(array) #=> [1,2,3,4,5,6,7,8,9]
	// This image will illustrate things more clearly:
	
	// 1,  2,  3,  4,
	// 5,  6,  7,  8,
	// 9,  10  11, 12,
	// 13, 14, 15, 16



	// NOTE: The idea is not sort the elements from the lowest value to the highest; the idea is to traverse the 2-d array in a clockwise snailshell pattern.

	// NOTE 2: The 0x0 (empty matrix) is represented as en empty array inside an array [[]].
	public int[] Snail(int[][] array)
	{
		int limiteH = array[0].Length;
		int limiteV = array.Length;
		int longitud = array[0].Length * array.Length;
		int[] resultado = new int[longitud];

		int x = 0;
		int y = 0;
		for (var i = 0; i < longitud; i++)
		{
			if (y < limiteH)
			{
				resultado[i] = array[x][y];
				y++;
			}
			else
			{
				if (x < limiteV)
				{
					x++;
					resultado[i] = array[x][limiteH - 1];
				}
				else
				{
					if (y >= 0)
					{
						y--;
						resultado[i] = array[x][y];
					}
				}
			}
		}
		return resultado;
	}
}