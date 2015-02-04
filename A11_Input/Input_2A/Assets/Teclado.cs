using UnityEngine;
using System.Collections;

public class Teclado : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log("Apertou espaço");
		}

		if (Input.GetKeyUp(KeyCode.Space))
		{
			Debug.Log("Soltou espaço");
		}

		if (Input.GetKey(KeyCode.Space))
		{
			Debug.Log("Apertado");
		} else
		{
			Debug.Log("Solto");
		}
	}
}
