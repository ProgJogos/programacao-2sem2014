using UnityEngine;
using System.Collections;

public class ExemploFuncoes : MonoBehaviour 
{
	public int contador;

	void Start () 
	{
		print("start");
		OlaMundo();
		VaiParaOrigem();
		print(MaisUm());
		contador = MaisUm();
		
		print(Somar(1, 2, 3, 4, 5, 6));
		
		print (Multiplicar(2));
		print (Dividir(10, 2));
		
	}
	
	void OlaMundo ()
	{
		print ("ola mundo");
	}
	
	void VaiParaOrigem ()
	{
		transform.position = new Vector3(0, 0, 0);
	}
	
	int MaisUm ()
	{
		return contador + 1;
		// nunca vai executar
		print ("bola");
	}
	
	int Somar (int a, int b)
	{
		return a + b;
	}
	
	float Somar (float a, float b)
	{
		return a + b;
	}
	
	int Somar (params int[] fatores)
	{
		int soma = 0;
		foreach (int numero in fatores)
		{
			soma += numero;
		}
		return soma;
	}
	
	int Multiplicar (int a, int b = 1)
	{
		return a * b;
	}
	
	float Dividir (float a, float b)
	{
		if(b == 0)
		{
			print ("divisao por zero!");
			return 0;
		}
		return a / b;	
	}
}
