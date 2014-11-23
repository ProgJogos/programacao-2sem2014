using UnityEngine;
using System.Collections;

public class Tabuleiro : MonoBehaviour 
{
	// declaracao do array
	public int[] casas;
	
	void Start () 
	{
		// inicializei o array
		casas = new int[10];
		
		int pontos = 10;
		
		for (int indice = 0; indice < 10; indice++)
		{
			if (indice % 2 == 0)
			{
				casas[indice] = pontos;
				pontos += 10;
			}
		}
	}
}
