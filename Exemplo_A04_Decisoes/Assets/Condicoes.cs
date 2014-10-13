using UnityEngine;
using System.Collections;

public class Condicoes : MonoBehaviour {

	public bool dia;
	public bool nublado;
	// Range limita a interface do editor, criando um slider
	[Range (0, 23)] public int hora;

	public bool 
		madrugada, 
		manha,
		tarde,
		noite;
	
	void Update () {
		// print (dia)
		// print (!dia);
		// print (dia && nublado);
		// print (dia || nublado);
		// print (hora == 12);
		// print (hora != 12);
		// print (hora == 12 && nublado);
		// print (hora >= 0 && hora < 6);
		madrugada = (hora >= 0 && hora < 6);
		manha = (hora >= 6 && hora < 12);
		tarde = (hora >= 12 && hora < 18);
		noite = (hora >= 18 && hora <= 23);
		
		// estrutura de decisao: se/if
		if (tarde) {
			print ("Boa tarde");
		}
	}
}






