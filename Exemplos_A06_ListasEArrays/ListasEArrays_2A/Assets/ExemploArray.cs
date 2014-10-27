using UnityEngine;
using System.Collections;

public class ExemploArray : MonoBehaviour 
{
	// declarou o array
	public float[] notas;

	void Start () 
	{
		// inicializar o array
		//notas = new float[3];

		// mudando valores
		//notas[0] = 7.5f;
		//notas[1] = 1.2f;
		//notas[2] = 5.4f;
		
		print(notas[0]); // valor na posicao 0
		print(notas.Length); // quantas posicoes
		
		// procurando qual eh o indice de 1.2f no
		// array notas
		print(System.Array.IndexOf(notas, 1.2f));
		print(System.Array.IndexOf(notas, 1.3f));
		
		foreach (float nota in notas)
		{
			print("foreach: " + nota);
		}
		
		for (int ind = 0; ind < notas.Length; ind++)
		{
			print ("for: " + notas[ind] + " na posicao " + ind);
		}	
	}
}
