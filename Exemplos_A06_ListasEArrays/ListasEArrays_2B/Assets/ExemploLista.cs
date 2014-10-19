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
		numeros.Remove(100);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
