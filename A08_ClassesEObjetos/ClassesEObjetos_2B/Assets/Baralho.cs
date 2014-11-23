using UnityEngine;
using System.Collections.Generic;

public class Baralho
{
	// atributos
	public Color corFundo;
	public List<Carta> cartas;
	
	// construtor
	public Baralho (Color fundo)
	{
		this.corFundo = fundo;
		cartas = new List<Carta> ();
		for(int i = 1; i <= 13; i++)
		{
			Carta nova = new Carta (i, Naipes.ESPADA);
			cartas.Add(nova);
		}
		for(int i = 1; i <= 13; i++)
		{
			Carta nova = new Carta (i, Naipes.OUROS);
			cartas.Add(nova);
		}
		for(int i = 1; i <= 13; i++)
		{
			Carta nova = new Carta (i, Naipes.PAUS);
			cartas.Add(nova);
		}
		for(int i = 1; i <= 13; i++)
		{
			Carta nova = new Carta (i, Naipes.COPAS);
			cartas.Add(nova);
		}
		
		foreach(Carta atual in cartas)
		{
			Debug.Log(atual.Descrever());
		}
	}
}
