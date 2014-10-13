using UnityEngine;
using System.Collections;

/// <summary>
/// Escreve uma letra da palavra em cada linha do console usando a estrutura foreach.
/// </summary>

public class ParaCada : MonoBehaviour 
{
	public string nome;
	
	void Start () 
	{
		foreach (char letra in nome)
		{
			print(letra);
		}
	}
}
