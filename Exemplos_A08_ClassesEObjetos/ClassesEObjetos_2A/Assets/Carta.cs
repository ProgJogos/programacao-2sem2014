using UnityEngine;

public enum Naipes
{
	ESPADA,
	OUROS,
	COPAS,
	PAUS
}

public class Carta
{
	// atributos
	public int valor;
	public Color cor;
	public Naipes naipe;
	
	// construtor
	public Carta(int valor, Naipes naipe)
	{
		this.valor = Mathf.Clamp(valor, 1, 13);
		this.naipe = naipe;
		if (naipe == Naipes.ESPADA || naipe == Naipes.PAUS)
		{
			cor = Color.black;
		} else
		{
			cor = Color.red;
		}
	}
	
	// metodos
	public string Descrever()
	{
		if (valor == 1)
		{
			return "as de " + naipe;
		}
		
		if (valor == 11)
		{
			return "valete de " + naipe;
		}
		
		if (valor == 12)
		{
			return "dama de " + naipe;
		}
		
		if (valor == 13)
		{
			return "rei de " + naipe;
		}
		
		return valor + " de " + naipe;
	}
}



