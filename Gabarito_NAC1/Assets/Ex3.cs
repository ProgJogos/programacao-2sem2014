using UnityEngine;
using System.Collections;

public class Ex3 : MonoBehaviour 
{
	public string nome;
	public string sobrenome;
	public bool mostrarNome;
	
	void Update () 
	{
		if (mostrarNome)
		{
			print (nome + " " + sobrenome);
		}
		else
		{
			print (sobrenome);
		}
	}
}
