using UnityEngine;
using System.Collections.Generic;

public class Baralho
{
	// atributos
	public List<Carta> cartas;
	public string marca;
	public Color corFundo;
	
	// construtor
	public Baralho(string marca, Color fundo)
	{
		this.marca = marca;
		this.corFundo = fundo;
		
		// preencher a lista de cartas
		this.cartas = new List<Carta>();
		// criando todas as cartas de copas
		for (int cont = 1; cont <= 13; cont++)
		{
			Carta nova = new Carta(cont, Naipes.COPAS);
			cartas.Add(nova);
		}
		for (int cont = 1; cont <= 13; cont++)
		{
			Carta nova = new Carta(cont, Naipes.ESPADA);
			cartas.Add(nova);
		}
		for (int cont = 1; cont <= 13; cont++)
		{
			Carta nova = new Carta(cont, Naipes.PAUS);
			cartas.Add(nova);
		}
		for (int cont = 1; cont <= 13; cont++)
		{
			Carta nova = new Carta(cont, Naipes.OUROS);
			cartas.Add(nova);
		}
	}
	
	// metodos
	public void Embaralhar()
	{
		for (int i = 0; i < 1000; i++)
		{
			int posCarta1 = Random.Range(0, cartas.Count);
			int posCarta2 = Random.Range(0, cartas.Count);
			
			Carta temp = cartas [posCarta1];
			cartas [posCarta1] = cartas [posCarta2];
			cartas [posCarta2] = temp;
		}
	}
}