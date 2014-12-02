using UnityEngine;
using System.Collections;

public static class Arbitro 
{
	public static void RecarregarFase()
	{
		Application.LoadLevel(Application.loadedLevel);
	}

	public static void TerminarJogo()
	{
		// Application.LoadLevel(Application.loadedLevel);
		Debug.Log("GAME OVER");
	}

	public static void ResetarJogo() 
	{
		Application.LoadLevel("Fase01");
		Nave.vidas = 3;
		Nave.pontos = 0;
		Nave.combustivel = 500;
	}
}
