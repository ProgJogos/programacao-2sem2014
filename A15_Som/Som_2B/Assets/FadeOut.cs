using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour {

	public float duracao;
	float timer = -1;
	AudioSource som;
	float volumeInicial;
	
	void Start () {
		som = GetComponent<AudioSource> ();
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			// comecar fade out
			print ("comecou");
			timer = duracao;
			volumeInicial = som.volume;
		}

		if (timer >= 0) {
			// fade estah acontecendo
			print ("acontecendo");
			timer -= Time.deltaTime;
			som.volume = (timer / duracao) * volumeInicial;
		}
	}
}
