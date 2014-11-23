using UnityEngine;
using System.Collections;

public class Ex5 : MonoBehaviour 
{
	public int pontosA;
	public int pontosB;
	
	void Start () 
	{
		if (pontosA > pontosB)
		{
			print ("vitoria A");
		}
		else if (pontosA < pontosB)
		{
			print ("vitoria B");
		}
		else if (pontosA > 3)
		{
			print ("empate emocionante");
		}
		else
		{
			print ("empate");
		}
	}
}
