using UnityEngine;
using System.Collections;

public class MatrizXadrez : MonoBehaviour 
{
	public GameObject prefabCubo;
	public GameObject prefabBola;
	
	void Start () 
	{
		//Instantiate (prefabCubo, posicao, Quaternion.identity);
		Vector3 posicao = Vector3.zero;
		
		for (int linhas = 0; linhas < 5; linhas++)
		{
			for (int colunas = 0; colunas < 5; colunas++)
			{
				if (colunas % 2 == 0 && linhas % 2 == 0) 
				{
					Instantiate (prefabCubo, posicao, Quaternion.identity);
				}
				else if (colunas % 2 != 0 && linhas % 2 == 0)
				{
					Instantiate (prefabBola, posicao, Quaternion.identity);
				}
				else if (colunas % 2 == 0 && linhas % 2 != 0)
				{
					Instantiate (prefabBola, posicao, Quaternion.identity);
				}
				else
				{
					Instantiate (prefabCubo, posicao, Quaternion.identity);
				}
				posicao.x += 2;
			}
			posicao.x = 0;
			posicao.y += 2;
		}
	}
}
