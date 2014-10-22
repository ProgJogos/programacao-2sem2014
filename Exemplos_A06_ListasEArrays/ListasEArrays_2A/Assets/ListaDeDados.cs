using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListaDeDados : MonoBehaviour 
{
	public List<int> dados;
	
	void Start () 
	{
		dados = new List<int>();
		/*
		for (int cont = 0; cont < 10; cont++)
		{
			int resultado = Random.Range(1, 7);
			dados.Add(resultado);
		}
		*/
		while (dados.Count < 10)
		{
			int resultado = Random.Range(1, 7);
			dados.Add(resultado*10);
		}
		
		
	}
}
