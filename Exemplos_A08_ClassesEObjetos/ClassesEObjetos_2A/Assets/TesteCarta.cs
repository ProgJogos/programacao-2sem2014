using UnityEngine;
using System.Collections;

public class TesteCarta : MonoBehaviour
{
	void Start()
	{
		Carta novaCarta = new Carta(99, Naipes.COPAS);
		print(novaCarta.Descrever());
		
		Baralho novoBaralho = new Baralho("Copag", Color.blue);
		print(novoBaralho.cartas.Count);
		novoBaralho.Embaralhar();
		foreach (Carta carta in novoBaralho.cartas)
		{
			print(carta.Descrever());
		}
	}
}
