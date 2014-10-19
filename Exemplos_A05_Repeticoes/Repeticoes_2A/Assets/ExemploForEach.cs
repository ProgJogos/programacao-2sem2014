using UnityEngine;
using System.Collections;

public class ExemploForEach : MonoBehaviour 
{
	public string nome;

	void Start () 
	{
		foreach (char letra in nome)
		{
			print (letra);
		}
	}
}
