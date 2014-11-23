using UnityEngine;
using System.Collections;

public class TrocarCor : MonoBehaviour
{
	// atributo
	public Color cor;
	
	void Update ()
	{
		Trocar ();
	}
	
	public void Trocar ()
	{
		renderer.material.color = cor;
	}
}
