using UnityEngine;
using System.Collections;

public class Botao : MonoBehaviour
{
	void Update()
	{
		if (Input.GetButtonDown("Ativar"))
		{
			Debug.Log("Apertou botao");
		}
		
		if (Input.GetButtonUp("Ativar"))
		{
			Debug.Log("Soltou botao");
		}
		
		if (Input.GetButton("Ativar"))
		{
			Debug.Log("Apertado");
		} else
		{
			Debug.Log("Solto");
		}
	}
}

