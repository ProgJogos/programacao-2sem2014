using UnityEngine;
using System.Collections;

public class Clicavel : MonoBehaviour
{

	void OnMouseEnter()
	{
		Debug.Log("Entrou");
	}

	void OnMouseOver()
	{
		Debug.Log("Em cima");
		if (Input.GetMouseButtonDown(1))
		{
			Debug.Log("Clique botao direito");
		}
	}

	void OnMouseExit()
	{
		Debug.Log("Saiu");
	}

	void OnMouseDown()
	{
		Debug.Log("Comecou Clique");
	}

	void OnMouseDrag()
	{
		Debug.Log("Continuou Clique");
	}

	void OnMouseUp()
	{
		Debug.Log("Terminou Clique");
	}

	void OnMouseUpAsButton()
	{
		Debug.Log("Terminou BOTAO");
	}
}
