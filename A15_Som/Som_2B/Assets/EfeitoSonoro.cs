using UnityEngine;
using System.Collections;

public class EfeitoSonoro : MonoBehaviour {

	public AudioClip somPulo, somQueda;

	AudioSource som;
	Rigidbody rb;

	void Start () {
		som = GetComponent<AudioSource> ();
		rb = GetComponent<Rigidbody> ();
	}

	void OnCollisionEnter () {
		som.PlayOneShot (somQueda);
	}

	public void Pulei() {
		som.PlayOneShot(somPulo);
	}
}
