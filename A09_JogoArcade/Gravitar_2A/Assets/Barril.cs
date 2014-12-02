using UnityEngine;
using System.Collections;

public class Barril : MonoBehaviour {

	public int carga;
	public float tempoColeta;
	private float timer;

	// quando entrar no sensor
	void OnTriggerEnter2D (Collider2D outro) 
	{
		// se for o jogador (tem a layer jogador)
		if(outro.gameObject.layer == LayerMask.NameToLayer("Jogador"))
		{
			// reseta o timer
			timer = 0;
		}
	}

	// enquanto algum objeto estiver dentro do sensor
	void OnTriggerStay2D (Collider2D outro) 
	{
		// se fgor o jogador
		if(outro.gameObject.layer == LayerMask.NameToLayer("Jogador"))
		{
			// incrementa o tempo
			timer += Time.deltaTime;
			// se chegou no momento de coletar
			if(timer >= tempoColeta)
			{
				// aumenta combustivel da nave, destroi o barril
				// e escreve no console
				Nave.combustivel += carga;
				Destroy(this.gameObject);
				print ("combustivel: " + Nave.combustivel);
			}
		}
	}

}
