using UnityEngine;

public enum TipoLog {
	ARTE,
	AI,
	SOM,
	GAMEPLAY
}

public static class Logger 
{
	public static bool mostrarArte;
	public static bool mostrarAI;
	public static bool mostrarSom;
	public static bool mostrarGameplay;

	public static void Log(TipoLog tipo, string msg) {
		switch (tipo) {
		case TipoLog.ARTE : if(!mostrarArte) return; break;
		case TipoLog.AI : if(!mostrarAI) return; break;
		case TipoLog.SOM : if(!mostrarSom) return; break;
		case TipoLog.GAMEPLAY : if(!mostrarGameplay) return; break;
		}
		Debug.Log (tipo.ToString () + ": " + msg);
	}
}
