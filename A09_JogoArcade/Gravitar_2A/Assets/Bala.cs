using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour
{
	public float tempoDeVida;

	void Update()
	{
		tempoDeVida -= Time.deltaTime;
		if (tempoDeVida <= 0)
		{
			Destroy(this.gameObject);
		}
	}

	void OnCollisionEnter2D()
	{
		Destroy(this.gameObject);
	}
}
