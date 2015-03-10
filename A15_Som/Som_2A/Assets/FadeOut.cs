using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour {

	public float tempo;
	AudioSource som;
	float timer = -1;
	float volumeOriginal;

	void Start () {
		som = GetComponent<AudioSource> ();
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) 
		{
			// comecar fade out
			timer = tempo;
			volumeOriginal = som.volume;
		}

		if (timer >= 0) {
			som.volume = volumeOriginal*(timer/tempo);
			timer -= Time.deltaTime;
		}

	}
}
