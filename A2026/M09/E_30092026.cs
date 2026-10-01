public partial class Ejercicios
{
	//Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
	//https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp
	public int[] MoveZeroes(int[] arr)
	{
		int[] resultado = new int[arr.Length];
		for(int i = 0, j = 0; i < arr.Length; i++)
		{
			if (arr[i] != 0)
			{
				resultado[j] = arr[i];
				j++;
			}
		}
		return resultado;
		// TODO: Program me
	}
}