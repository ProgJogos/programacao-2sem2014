using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour {

	AudioSource som;
	public float duracao;
	float timer = -1;
	public float volumeFinal;

	void Start () {
		som = GetComponent<AudioSource> ();
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.D)) {
			// comecar o fadein
			timer = duracao;
			som.volume = 0;
		}

		if (timer >= 0) {
			// fadein rolando
			timer -= Time.deltaTime;
			som.volume = (duracao - timer)/duracao * volumeFinal;
		}
	}
}
