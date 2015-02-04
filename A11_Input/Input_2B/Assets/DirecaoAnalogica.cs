using UnityEngine;
using System.Collections;

public class DirecaoAnalogica : MonoBehaviour
{

	void Update()
	{
		Vector2 direcao = new Vector2(
			Input.GetAxis("Horizontal"),
			Input.GetAxis("Vertical"));
		transform.up = direcao;
	}
}
