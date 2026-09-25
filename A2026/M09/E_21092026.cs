using System;
using System.Linq;
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
		var impares = array.Where(n => n % 2 != 0).OrderBy(n => n).ToArray();
		var pares = array.Where(n => n % 2 == 0).ToArray();
		int[] resultado = new int[array.Length];
		int contadorPar = 0;
		int contadoImpar = 0;
		for(var i = 0; i < array.Length; i++)
		{
			if(array[i] % 2 == 0)
			{
				resultado[i] = pares[contadorPar];
				contadorPar++;	
			}
			else
			{
				resultado[i] = impares[contadoImpar];
				contadoImpar++;	
			}
		}
		return resultado;
	}
}