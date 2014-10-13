using UnityEngine;
using System.Collections;

/// <summary>
/// Conta quantos numeros (a partir de numero maximo) sao multiplos de 3 ou 5.
/// </summary>

public class ContaMultiplos : MonoBehaviour 
{

	public int numeroMaximo;

	void Start () 
	{
		int num;
		for (num = numeroMaximo; num >= 0; num--) 
		{
			if (num % 3 == 0 || num % 5 == 0)
			{
				print (num);
			}
		}
	}
}
