using UnityEngine;
using System.Collections;

public class Cumprimentos : MonoBehaviour 
{

	public int hora;
	
	void Update () 
	{
		hora = Mathf.Clamp (hora, 0, 23);
	
		if (hora < 6) 
		{
			print ("boa madrugada");
		}
		else if (hora < 12) 
		{
			print ("bom dia");
		}
		else if (hora < 18) 
		{
			print ("boa tarde");
		}
		else
		{
			print ("boa noite");
		}
	}
}
