using UnityEngine;
using System.Collections;

public class Fronteira : MonoBehaviour
{
	public string fase;
	
	void OnTriggerEnter2D(Collider2D outro)
	{
		if (outro.gameObject.layer == LayerMask.NameToLayer("Jogador"))
		{
			// mudar de fase quando estah no mapa de fases
			if(Arbitro.faseAtual == null) {
				Arbitro.CarregarFase(fase);	
			}
			// sair da fase dentro de uma fase normal
			else {
				GameObject[] inimigos = 
					GameObject.FindGameObjectsWithTag("Inimigo");
				if(inimigos.Length == 0) {
					Arbitro.PassarDeFase();
				}
				Arbitro.CarregarFase("MapaFases");
			}
		}
	}
}
