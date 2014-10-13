using UnityEngine;
using System.Collections;

public class Decisoes : MonoBehaviour {

	public bool dia;
	public int pontosA;
	public int pontosB;
	
	void Update () {
				/*
		if (dia) {
			print ("bom dia");
		}
		*/
		
		if (pontosA > pontosB) 
		{
			print ("time A ganhou");
		}
		else if (pontosB > pontosA) 
		{
			print ("time B ganhou");
		}
		else 
		{
			print ("empate");
		}
	}
}




