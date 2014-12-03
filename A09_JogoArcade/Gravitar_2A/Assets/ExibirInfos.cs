using UnityEngine;
using System.Collections;

public class ExibirInfos : MonoBehaviour {

	void Update () {
		guiText.text = 
			"Vidas: " + Nave.vidas +
			"\nPontos: " + Nave.pontos +
			"\nCombustivel: " + Nave.combustivel;
	}
}
