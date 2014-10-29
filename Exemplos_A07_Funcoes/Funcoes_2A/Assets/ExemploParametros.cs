using UnityEngine;
using System.Collections;

public class ExemploParametros : MonoBehaviour 
{

	void Start () 
	{
		//print(Somar(1, 2)); // 3
		//print(Somar(1, 2, 9, 7, 100)); // 119
		print( Dividir(10, 3) );
		print( Dividir(10f, 3f) );
		
	}
	
	int Somar (params int[] numeros)
	{
		int soma = 0;
		foreach (int fator in numeros)
		{
			soma += fator;
		}
		return soma;
	}
	
	int Dividir (int a, int b)
	{
		return a / b;
	}	
	
	float Dividir (float a, float b)
	{
		return a / b;
	}
	
	int Subtrair (int a, int b)
	{
		return a - b;
	} 
}
