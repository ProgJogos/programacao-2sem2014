using UnityEngine;
using System.Collections;

public class GeradorBloco : MonoBehaviour 
{
	public int nroBlocos;
	public GameObject prefabBloco;
	
	void Start () 
	{
		Vector3 posicao = Vector3.zero;

		for (int camadas = 0; camadas < nroBlocos; camadas++)
		{
			for (int linhas = 0; linhas < nroBlocos; linhas++)
			{
				for (int coluna = 0; coluna < nroBlocos; coluna++)
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
			posicao.y = 0;
			posicao.z += 2f;
		}
	}
}
