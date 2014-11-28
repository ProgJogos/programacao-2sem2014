using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {

	public float tempoDeVida;
	private bool destruir;

	void Update () {
		tempoDeVida -= Time.deltaTime;
		if(tempoDeVida <= 0)
		{
			Destroy(this.gameObject);
		}
	}
	
	void LateUpdate () 
	{
		if(destruir) 
		{
			Destroy(this.gameObject);
		}
	}
	
	void OnCollisionEnter2D (Collision2D colisao)
	{
		destruir = true;
	}
}
