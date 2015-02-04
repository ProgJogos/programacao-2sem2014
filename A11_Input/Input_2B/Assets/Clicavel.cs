using UnityEngine;
using System.Collections;

public class Clicavel : MonoBehaviour
{
	void OnMouseDown()
	{
		Debug.Log("Clicou no " + gameObject.name);
	}

	void OnMouseEnter()
	{
		Debug.Log("Entrou em " + gameObject.name);
	}

	void OnMouseOver()
	{
		Debug.Log("Esta em " + gameObject.name);
		if (Input.GetMouseButtonDown(1))
		{
			Debug.Log("Clique direito em " + gameObject.name);
		}
	}

	void OnMouseExit()
	{
		Debug.Log("Saiu de " + gameObject.name);
	}
}
