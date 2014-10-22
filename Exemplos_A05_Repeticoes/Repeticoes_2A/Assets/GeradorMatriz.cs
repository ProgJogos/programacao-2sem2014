using UnityEngine;
using System.Collections;

public class GeradorMatriz : MonoBehaviour 
{
	public GameObject prefabBloco;

	void Start () 
	{
		Vector3 posicao = Vector3.zero;
		for (int linha = 0; linha < 3; linha++)
		{
			for (int coluna = 0; coluna < 3; coluna++)
			{
				Instantiate(
					prefabBloco, 
					posicao, 
					Quaternion.identity);
				posicao.x += 2f;
			}
			posicao.y += 2f;
			posicao.x = 0;
		}
	}
}
