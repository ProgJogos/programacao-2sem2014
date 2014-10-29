using UnityEngine;
using System.Collections;

public class AcharMaiorValor : MonoBehaviour 
{
	public int[] numeros;

	void Start () 
	{
		int maiorValor = 0;
		int indiceMaior = -1;

		for (int ind = 0; ind < numeros.Length; ind++)
		{
			if (numeros[ind] > maiorValor)
			{
				maiorValor = numeros[ind];
				indiceMaior = ind;
			}
		}
		print ("maior valor eh: " + maiorValor + 
			" no indice " + indiceMaior);
	}
}
