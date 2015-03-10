using UnityEngine;
using System.Collections;

public class ControlarMusica : MonoBehaviour {

	public AudioClip musica1;
	public AudioClip musica2;
	AudioSource som;

	void Start () {
		som = GetComponent<AudioSource> ();
		som.clip = musica1;
		som.Play ();
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1)){
			som.clip = musica1;
			som.Play();
		}	

		if(Input.GetKeyDown(KeyCode.Alpha2)){
			som.clip = musica2;
			som.Play();
		}
	}
}
