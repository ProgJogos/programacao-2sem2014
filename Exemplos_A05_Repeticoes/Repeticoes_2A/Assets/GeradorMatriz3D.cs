using UnityEngine;
using System.Collections;

public class GeradorMatriz3D : MonoBehaviour 
{
	public GameObject prefabBloco;
	public int tamanho;
	
	void Start () 
	{
		Vector3 posicao = Vector3.zero;
		for (int camada = 0; camada < tamanho; camada++)
		{
			for (int linha = 0; linha < tamanho; linha++)
			{
				for (int coluna = 0; coluna < tamanho; coluna++)
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
