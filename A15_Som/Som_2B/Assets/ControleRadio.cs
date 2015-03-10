using UnityEngine;
using System.Collections;

public class ControleRadio : MonoBehaviour {

	AudioSource som;

	void Start () {
		som = GetComponent<AudioSource> ();
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			som.Play();
		}

		if(Input.GetKeyUp(KeyCode.Space)) {
			som.Stop();
		}
	}
}
