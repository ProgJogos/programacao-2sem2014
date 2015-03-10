using UnityEngine;
using System.Collections;

public class ControlarAudio : MonoBehaviour {
	AudioSource som;

	void Start () {
		som = GetComponent<AudioSource> ();
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			som.Play();
		}
	}
}
