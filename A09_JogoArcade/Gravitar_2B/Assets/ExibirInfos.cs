using UnityEngine;
using System.Collections;

public class ExibirInfos : MonoBehaviour 
{
	void Update () {
		// se for fim do jogo
		if(Nave.vidas == 0) 
		{
			guiText.text = 
				"GAME OVER\nAperte ESC para recomeçar";
		}
		// se for jogo normal
		else {
			guiText.text = 
				"Vidas: " + Nave.vidas +
				"\nCombustivel: " + Nave.combustivel +
				"\nPontos: " + Nave.pontos;
		}
	}
}
