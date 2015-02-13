using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {

	public float velocidadeX;
	public bool atirando = false;

	void Update() {
		if (Input.GetKeyDown (KeyCode.Space) &&
		    rigidbody2D.velocity.magnitude == 0) {
			atirando = true;
			GetComponent<Animator> ().SetTrigger("Atirou");
		}
	}

	void FixedUpdate () {
		// calcula velocidade baseado no input
		float vel = velocidadeX * Input.GetAxis ("Horizontal");
		// aplica velocidade no rigidbody2D
		rigidbody2D.velocity = new Vector2 (
			vel, rigidbody2D.velocity.y);
		// muda o parametro do animator para o 
		// modulo da velocidade
		GetComponent<Animator> ().SetFloat ("VelocidadeX", 
        	Mathf.Abs(vel)); 
		// soh muda de direcao se estiver se movendo
		if (Mathf.Abs (vel) > 0) {
			transform.localScale = new Vector3 (
				Mathf.Sign (vel), 1, 1);
		}
		
	}
}
