using UnityEngine;
using System.Collections;

public class GeradorFileira : MonoBehaviour 
{
	public GameObject prefabBloco;
	
	void Start () 
	{
		Vector3 posicao = Vector3.zero;
		for (int blocos = 0; blocos < 5; blocos++)
		{
			Instantiate(
				prefabBloco, 
				posicao, 
				Quaternion.identity);
			posicao.x += 2f;
		}
	}
}
