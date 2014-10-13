using UnityEngine;
using System.Collections;

public class Repeticoes : MonoBehaviour {

	public int hora;
	public bool repetir;
	
	void Start () {

		// exemplo de while
		hora = 0;
		while (hora < 24) {
			print ("while: " + hora);
			hora++;
		}
		
		// exemplo de do-while
		repetir = true;
		do {
			print ("do-while: repetiu");
			repetir = (Random.Range(0, 100) > 2);
		} while (repetir);

		// exemplo de for incrementando um numero
		for (int numero = 0; numero <= 10; numero += 5) {
			print ("for++: " + numero);
		}

		// exemplo de for decrementando contador
		for (int contador = 10; contador >= 0; contador--) {
			print ("for--:" + contador);
		}
	}
}



