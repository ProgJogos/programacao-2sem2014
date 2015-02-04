using UnityEngine;
using System.Collections;

public class EixosMouse : MonoBehaviour
{

	void Update()
	{
		Vector2 direcao = new Vector2(
			Input.GetAxis("Mouse X"),
			Input.GetAxis("Mouse Y"));
		Debug.Log(direcao);
		Vector3 rotacao = new Vector3(
			direcao.y * -1,
			direcao.x,
			0);
		transform.Rotate(rotacao);

	}
}
