using UnityEngine;
using System.Collections;

public enum Naipes 
{
	ESPADA,
	COPAS,
	OUROS,
	PAUS
}

public class Carta 
{
	// atributos
	public int simbolo;
	public Naipes naipe;
	public Color cor;
	
	// construtor
	public Carta (int valor, Naipes naipe)
	{
		this.simbolo = Mathf.Clamp(valor, 1, 13);
		this.naipe = naipe;
		if(naipe == Naipes.ESPADA || naipe == Naipes.PAUS) 
		{
			this.cor = Color.black;
		}
		else
		{
			this.cor = Color.red;
		}
	}
	
	// metodos
	public string Descrever ()
	{
		string msg;
		
		if(simbolo == 1) 
		{
			msg = "As";
		}
		else if (simbolo == 11)
		{
			msg = "Valete";
		}
		else if (simbolo == 12)
		{
			msg = "Dama";
		}
		else if (simbolo == 13)
		{
			msg = "Rei";
		}
		else 
		{
			msg = simbolo.ToString();
		}
		
		msg += " de " + naipe;
		
		return msg;
	}
}





