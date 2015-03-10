using UnityEngine;
using System.Collections;

public class ControlePersonagem : MonoBehaviour {

	Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			rb.AddForce(0, 7, 0, ForceMode.VelocityChange);
			SendMessage("Pulei", SendMessageOptions.DontRequireReceiver);
		}
	}
}
