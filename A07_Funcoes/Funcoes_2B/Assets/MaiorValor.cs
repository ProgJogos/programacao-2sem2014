using UnityEngine;
using System.Collections;

public class MaiorValor : MonoBehaviour 
{
	void Start () 
	{
		AcharMaiorValor(1, 10.3f, 2.7f);	
	}
	
	float AcharMaiorValor (params float[] numeros)
	{
		float maior = 0;
		foreach (float atual in numeros)
		{
			if (atual > maior)
			{
				maior = atual;
			}
		}
		print (maior);
		return maior;
	}
}
