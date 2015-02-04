using UnityEngine;
using System.Collections;

public class MoverAnalogico : MonoBehaviour
{

	public float velocidadeMaxima;

	void FixedUpdate()
	{
		rigidbody.velocity = new Vector3(
			velocidadeMaxima * Input.GetAxis("EsqDir"),
			0,
			0);
	}
}
