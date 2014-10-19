using UnityEngine;
using System.Collections;

public class EnquantoFaca : MonoBehaviour 
{
	void Start () 
	{
		int hora = 0;
		while (hora < 24)
		{
			print ("hora: " + hora);
			hora++;
		}
			
		int contador = 0;
		while (contador < 2)
		{
			// dado de seis faces
			int dado = Random.Range(1, 7);
			if (dado > 3)
			{
				contador++;
			}
			else
			{
				contador--;
			}
			print(contador);
		}
	} // fim:Start
} // fim:classe





