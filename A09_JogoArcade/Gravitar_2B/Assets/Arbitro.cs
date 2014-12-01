using UnityEngine;
using System.Collections;

public static class Arbitro
{
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
		Application.LoadLevel("Fase01");
	}
}
