using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {

	public float velocidadeX;

	void FixedUpdate () {
		rigidbody2D.velocity = new Vector2 (
			Input.GetAxis("Horizontal") * velocidadeX,
			rigidbody2D.velocity.y);
		var animator = GetComponent<Animator> ();
		animator.SetFloat ("VelocidadeX", Mathf.Abs(rigidbody2D.velocity.x));
		if (Mathf.Abs (rigidbody2D.velocity.x) > 0) {
			transform.localScale = new Vector3 (
				Mathf.Sign (rigidbody2D.velocity.x), 1, 1);
		}
	}
}
