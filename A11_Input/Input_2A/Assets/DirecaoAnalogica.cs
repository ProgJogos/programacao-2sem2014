using UnityEngine;
using System.Collections;

public class DirecaoAnalogica : MonoBehaviour
{

	void Update()
	{
		Vector2 direcao = new Vector2(
			Input.GetAxis("Horizontal"),
			Input.GetAxis("Vertical"));
		Debug.Log(direcao);
		Debug.DrawRay(Vector3.zero, direcao, Color.red);
		transform.up = new Vector3(direcao.x, 0, direcao.y);
	}
}
