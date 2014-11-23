using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExemploLista : MonoBehaviour 
{
	public List<int> numeros;

	void Start () 
	{
		numeros = new List<int>();
		
		numeros.Add (100); 
		numeros.Add (200);
		print(numeros.Count);
		
		numeros.Remove(10);
		print(numeros.Count);
		
		numeros.Add(300);
		numeros.Insert(1, 150);
		
		print(numeros.IndexOf(300));
	}
}
