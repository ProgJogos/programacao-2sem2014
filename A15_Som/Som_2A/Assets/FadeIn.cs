using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour {

	public float tempo;
	AudioSource som;
	float timer = -1;
	public float volumeFinal;
	
	void Start () {
		som = GetComponent<AudioSource> ();
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.O)) 
		{
			// comecar fade out
			som.volume = 0;
			timer = tempo;
		}
		
		if (timer >= 0) {
			som.volume = ((tempo-timer)/tempo) * volumeFinal;
			timer -= Time.deltaTime;
		}
		
	}
}
