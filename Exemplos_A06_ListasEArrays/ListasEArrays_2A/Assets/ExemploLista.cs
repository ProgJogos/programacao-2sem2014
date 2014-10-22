using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExemploLista : MonoBehaviour 
{
	public List<string> chamada;
	
	void Start () 
	{
		chamada = new List<string>();
		chamada.Add("bob");
		chamada.Add("jao");
		chamada.Add("isa");
		chamada.Add("sebastiao");
		print("pos jao: " + chamada.IndexOf("jao"));
		print("pos zeh: " + chamada.IndexOf("zeh"));
		// print(chamada.Remove("bob"));
		// print(chamada.Remove("bob"));
		// chamada.RemoveAt(0);
		foreach (string nome in chamada)
		{
			print (nome);
			if (nome.Length > 8)
			{
				print ("nome comprido");
			}
		}
		// chamada.Clear();
	}
}
