using UnityEngine;
using System.Collections;

public class Condicoes : MonoBehaviour {

	public bool dia;
	public bool nublado;

	public int varA;
	public int varB;
	
	void Update () {
		// exemplo de negacao (!)
		// print (dia); // escreve o valor de dia
		// print (!dia); // escreve o oposto de dia

		// exemplo de operador E (&&)
		// soh eh verdadeiro 
		// se os dois sao verdadeiros
		// print (dia && nublado);

		// exemplo de operador OU (||)
		// eh verdadeiro quando dia ou
		// nublado sao verdadeiros
		// print (dia || nublado);
		
		// exemplos de operadores relacionais
		// print (dia == nublado); // igualdade
		// print (dia != nublado); // desigualdade
		// print (varA > varB);
		print (varA >= varB);
	}
}
