using UnityEngine;
using System.Collections;

public class PuloVariavel : MonoBehaviour
{

	public float velocidade;
	float timer;
	public float tempoPulo;

	void Update()
	{
		// se comecou a apertar o pulo
		if (Input.GetButtonDown("Ativar"))
		{
			timer = 0;
		}
		// se esta apertado
		if (Input.GetButton("Ativar") && timer < tempoPulo)
		{
			rigidbody.velocity += new Vector3(
				0, velocidade * Time.deltaTime, 0);
			timer += Time.deltaTime;
		}
	}
}
