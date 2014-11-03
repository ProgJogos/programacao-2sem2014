using UnityEngine;
using System.Collections;

public class Producao : MonoBehaviour 
{
	void Start () 
	{
		print( CalcularProducao (10, 5, "ocuPado") );
	}
	
	int CalcularProducao (int populacao, int tecnologia, 
		string status)
	{
		int producao = 0;
		if (status.ToLower() == "ocupado")
		{
			producao = 0;
		}
		else
		{
			producao = populacao * tecnologia;
		}
		return producao;
	}
	
	int CalcularConsumoTotal (int populacao, int consumoPorPessoa)
	{
		return populacao * consumoPorPessoa;
	}
	
	int CalcularVariacaoEstoque (int populacao, int tecnologia,
		int consumoPorPessoa, string status)
	{
		int producao = CalcularProducao(populacao, tecnologia,
			status);
		int consumo = CalcularConsumoTotal(populacao, 
			consumoPorPessoa);
		return producao - consumo;
	}
}




