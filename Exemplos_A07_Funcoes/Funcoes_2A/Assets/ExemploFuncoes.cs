using UnityEngine;
using System.Collections;

public class ExemploFuncoes : MonoBehaviour 
{
	int contador = 0;

	void Start () 
	{
		//OlaMundo();
		//print( SomarUm() );
		//print( SomarUm() );
		//Escrever("oi bob e margarida");
		//print (Fatorial (4));
		//Escrever2("ola");
		//Escrever2();
	}

	void OlaMundo ()
	{
		Escrever("ola mundo");
	}
	
	int SomarUm ()
	{
		contador++;
		return contador;
	}
	
	void Escrever (string msg)
	{
		print ("escrever: " + msg);
	}
	
	int Fatorial (int n)
	{
		int res = 0;
		if (n > 1)
		{
			res = n + Fatorial(n-1);
		}
		else
		{
			res = 1;
		}
		return res;
	}
	
	void Escrever2 (string msg = "msg vazia")
	{
		print ("escrever: " + msg);
	}
}
