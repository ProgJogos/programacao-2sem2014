using UnityEngine;
using System.Collections;

public class Fase 
{
	public string nome;
	public int inimigosIniciais;
	public int inimigosAtuais;
	public bool travada;
	public bool passou;
	public string proxima;
	
	public Fase (string nome, int iniIniciais, string proxima)
	{
		this.nome = nome;
		this.inimigosIniciais = iniIniciais;
		this.inimigosAtuais = inimigosIniciais;
		this.travada = true;
		this.passou = false;
		this.proxima = proxima;
	}
}
