using UnityEngine;
using System.Collections;

public class GeradorAlternado : MonoBehaviour 
{
	public GameObject prefabCubo;
	public GameObject prefabBola;
	
	void Start () 
	{
		Vector3 posicao = Vector3.zero;
		
		for (int linhas = 0; linhas < 5; linhas++)
		{
			for (int coluna = 0; coluna < 5; coluna++)
			{
				if (coluna % 2 == 0) 
				{
					Instantiate (prefabCubo, posicao, Quaternion.identity);
				}
				else
				{
					Instantiate (prefabBola, posicao, Quaternion.identity);
				}
				posicao.x += 2f;
			}
			posicao.x = 0;
			posicao.y += 2f;
		}
		
		
	}
}
