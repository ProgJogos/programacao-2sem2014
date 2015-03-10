using UnityEngine;
using System.Collections;

public class SonsPlataforma : MonoBehaviour {
	AudioSource som;

	void Start () {
		som = GetComponent<AudioSource> ();
	}
	
	public void TocarSom() {
		som.Play ();
	}

	public void Tocar (AudioClip clip) {
		som.PlayOneShot(clip);
	}
}
