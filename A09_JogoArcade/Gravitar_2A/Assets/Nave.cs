using UnityEngine;
using System.Collections;

public class Nave : MonoBehaviour {

	public int vidas;
	public int pontos;

	public float velocidadeRotacao;

	void Start () {
	
	}
	
	void Update () {
		// girar conforme esq-dir for apertado
		float giro = -1 * Input.GetAxis("Horizontal");
		rigidbody2D.angularVelocity = giro * velocidadeRotacao;
	}
}
