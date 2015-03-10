using UnityEngine;
using System.Collections;

public class Personagem : MonoBehaviour {

	public AudioClip somPulo, somQueda;
	public float pulo;
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			rigidbody.velocity += new Vector3(0, pulo, 0);
			audio.PlayOneShot(somPulo);
		}
	}

	void OnCollisionEnter(){
		audio.PlayOneShot (somQueda);
	}
}
