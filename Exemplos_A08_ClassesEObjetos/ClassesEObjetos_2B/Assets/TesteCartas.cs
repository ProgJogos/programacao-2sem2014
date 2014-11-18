using UnityEngine;
using System.Collections;

public class TesteCartas : MonoBehaviour 
{
	void Start () 
	{
		Carta novaCarta = new Carta(-4589, Naipes.PAUS);
		print( novaCarta.Descrever() );
		
		Baralho novoBaralho = new Baralho(Color.green);
	}
}
