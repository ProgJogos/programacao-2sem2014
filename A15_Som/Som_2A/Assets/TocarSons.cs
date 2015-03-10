using UnityEngine;
using System.Collections;

public class TocarSons : MonoBehaviour {

	public AudioClip som1, som2;
	public float pitchMinimo, pitchMaximo;

	public void TocarSom1() {
		audio.PlayOneShot (som1);
	}

	public void TocarSom2() {
		audio.PlayOneShot (som2);
	}

	public void TocarSomAlterado(){
		audio.pitch = Random.Range (pitchMinimo, 
		                            pitchMaximo);
		audio.PlayOneShot (som1);
	}
}
