using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Medias : MonoBehaviour 
{
	public List<float> notas;

	void Start () 
	{
		float soma = 0;
		float media = 0;
		foreach (float numero in notas)
		{
			soma += numero;
		}
		media = soma / notas.Count;
		print(media);
	}
}
