using UnityEngine;
using System.Collections;

public class Crossfade : MonoBehaviour {

	public AudioSource som1, som2;
	public float duracao;
	float timer = -1;

	void Start () {
	
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			// comecar crossfade
			som2.Play();
			som2.volume = 0;
			som1.volume = 1;
			timer = duracao;
		}
		if (timer >= 0) {
			som1.volume = (timer / duracao);
			som2.volume = (duracao - timer)/duracao;
			timer -= Time.deltaTime;
		}
	}
}
