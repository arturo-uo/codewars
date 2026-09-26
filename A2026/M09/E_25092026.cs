using System;
public partial class Ejercicios
{
	// 	The rgb function is incomplete. Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned. Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.

	// Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.

	// Examples (input --> output):
	// 255, 255, 255 --> "FFFFFF"
	// 255, 255, 300 --> "FFFFFF"
	// 0, 0, 0       --> "000000"
	// 148, 0, 211   --> "9400D3"
	//https://www.codewars.com/kata/513e08acc600c94f01000001/train/csharp
	public string Rgb(int r, int g, int b)
	{
		if (r <= 0)
			r = 0;
		else if (r > 255)
			r = 255;
		if (g <= 0)
			g = 0;
		else if (g > 255)
			g = 255;
		if (b <= 0)
			b = 0;
		else if (b > 255)
			b = 255;
		return $"{String.Format("{0:X2}", r)}{String.Format("{0:X2}", g)}{String.Format("{0:X2}", b)}";
	}

	// Completa la función que

	// acepta dos matrices enteras de igual longitud
	// compara el valor de cada miembro en un array con el correspondiente en el otro
	// cuadra la diferencia absoluta de valores entre esos dos valores
	// y devuelve la media de esos valores absolutos al cuadrado entre cada par de miembros.
	// Ejemplos
	// [1, 2, 3], [4, 5, 6]              -->   9   because (9 + 9 + 9) / 3
	// [10, 20, 10, 2], [10, 25, 5, -2]  -->  16.5 because (0 + 25 + 25 + 16) / 4
	// [-1, 0], [0, -1]                  -->   1   because (1 + 1) / 2
	public double Solution(int[] firstArray, int[] secondArray)
	{
		if(firstArray.Length != secondArray.Length)
			return 0;
		
		double suma = 0;
		for(var i = 0; i < firstArray.Length; i++)
		{
			int res = firstArray[i] - secondArray[i];
			suma += Math.Pow(res, 2);
		}
		return suma / firstArray.Length;
	}
}