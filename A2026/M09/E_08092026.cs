// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

public partial class Ejercicios
{
	public string ToCamelCase(string str)
	{
		string resultado = string.Empty;

		bool replazarSiguiente = false;
		if (str.Contains('-'))
		{
			for (var i = 0; i < str.ToArray().Length; i++)
			{
				if (str[i] == '-')
				{
					replazarSiguiente = true;
				}
				else
				{
					if (replazarSiguiente)
					{
						resultado += str[i].ToString().ToUpper();
						replazarSiguiente = false;
					}
					else
					{
						resultado += str[i];
					}
				}
			}
		}
		if (str.Contains('_'))
		{
			for (var i = 0; i < str.ToArray().Length; i++)
			{
				if (str[i] == '_')
				{
					replazarSiguiente = true;
				}
				else
				{
					if (replazarSiguiente)
					{
						resultado += str[i].ToString().ToUpper();
						replazarSiguiente = false;
					}
					else
					{
						resultado += str[i];
					}
				}
			}
		}
		str = resultado.Replace("-", "").Replace("_", "");
		return str;
	}
}