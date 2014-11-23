using UnityEngine;
using System.Collections;

public class Producao : MonoBehaviour 
{
	void Start () 
	{
		print ( CalcularProducao(-50, 1000, "ocupado") );
	}
	
	float CalcularProducao (int populacao, int tecnologia, string status)
	{
		// limitar entre valores maximos e minimos
		tecnologia = Mathf.Clamp(tecnologia, 1, 10);
		populacao = Mathf.Clamp(populacao, 0, 100);

		// float producao;
		if (status == "ocupado")
		{
			// producao = 0;
			return 0;
		}
		else
		{
			// producao = populacao * tecnologia;
			return populacao * tecnologia;
		}
		//return producao;
	}
	
	
}
