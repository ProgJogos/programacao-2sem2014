using UnityEngine;
using System.Collections;

public class MediaArray : MonoBehaviour 
{
	public float[] notas;
	
	void Start () 
	{
		float soma = 0;
		foreach (float valor in notas)
		{
			soma += valor;
		}
		float media = soma / notas.Length;
		print(media);
	}
}



