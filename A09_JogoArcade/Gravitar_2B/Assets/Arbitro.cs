using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class Arbitro
{
	public static bool primeiroCarregamento = true;
	public static Fase faseAtual;
	public static List<Fase> fases;

	public static void RenascerNave()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
	
	public static void TerminarJogo()
	{
		Debug.Log("GAME OVER");
	}
	
	public static void ResetarJogo()
	{
		Debug.Log("RESET");
		Nave.vidas = 3;
		Nave.pontos = 0;
		Nave.combustivel = 1000;
		Application.LoadLevel("MapaFases");
		fases = new List<Fase>();
		fases.Add(new Fase("Fase01", 2, "Fase02"));
		fases.Add(new Fase("Fase02", 2, "Fase01"));
		fases[0].travada = false;
		faseAtual = null;
	}
	
	public static Fase BuscarFase(string nome)
	{
		foreach (Fase fase in fases) {
			if(fase.nome == nome) {
				return fase;
			}
		}
		return null;
	}
	
	public static void PassarDeFase () 
	{
		string nomeProxima = faseAtual.proxima;
		BuscarFase(nomeProxima).travada = false;
		faseAtual.passou = true;
	}
	
	public static void CarregarFase(string nome) 
	{
		Application.LoadLevel(nome);
		if(nome == "MapaFases") {
			faseAtual = null;
		}
		else {
			faseAtual = Arbitro.BuscarFase(nome);
		}
	}
}
