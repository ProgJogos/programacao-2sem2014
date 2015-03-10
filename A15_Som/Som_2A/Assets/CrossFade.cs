using UnityEngine;
using System.Collections;

public class CrossFade : MonoBehaviour {

	public AudioSource som1, som2;
	public float volumeFinal;
	public float tempo;
	float volumeOriginal;
	float timer = -1;

	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) 
		{
			// comecar crossfade
			som2.volume = 0;
			som2.Play();
			timer = tempo;
			volumeOriginal = som1.volume;
		}
		
		if (timer >= 0) {
			// fade out do som1
			som1.volume = volumeOriginal*(timer/tempo);
			// fade in do som2
			som2.volume = ((tempo-timer)/tempo) * volumeFinal;
			timer -= Time.deltaTime;
		}
		
	}
}
