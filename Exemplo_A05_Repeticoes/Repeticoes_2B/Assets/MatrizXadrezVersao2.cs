using UnityEngine;
using System.Collections;

public class MatrizXadrezVersao2 : MonoBehaviour 
{

	public GameObject prefabCubo;
	public GameObject prefabBola;
	
	void Start () 
	{
		Vector3 posicao = Vector3.zero;
		
		for (int linhas = 0; linhas < 5; linhas++)
		{
			for (int colunas = 0; colunas < 5; colunas++)
			{
				if ((linhas + colunas) % 2 == 0 )
				{
					Instantiate (prefabCubo, posicao, Quaternion.identity);
				}
				else 
				{
					Instantiate (prefabBola, posicao, Quaternion.identity);
				}
				posicao.x += 2;
			}
			posicao.x = 0;
			posicao.y += 2;
		}
	}
}
