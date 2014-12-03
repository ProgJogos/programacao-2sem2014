 using UnityEngine;
using System.Collections;

public class FaseNoMapa : MonoBehaviour {

	public string cena;

	void OnTriggerEnter2D (Collider2D outro) {
		// se for o jogador (tem a layer jogador)
		if (outro.gameObject.layer == LayerMask.NameToLayer("Jogador"))
		{
			Application.LoadLevel(cena);
		}
	}
}
