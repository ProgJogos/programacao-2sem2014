using UnityEngine;
using System.Collections;

public class Horas : MonoBehaviour {

	public int hora;
	
	void Update () {
		/* exemplo de SE
		if (hora > 6 && hora <= 18) {
			print ("ehd e dia");
		}
		*/

		/* exemplo de SE-SENAO
		if (hora > 6 && hora <= 18) {
			print ("eh de dia");
		}
		else {
			print ("de noite");
		}*/

		// exemplo de SE-SENAO SE-SENAO
		if (hora > 6 && hora <= 18) {
			print ("eh de dia");
		}
		else if (hora <= 6) {
			print ("de madrugada");
		}
		else {
			print ("de noite");
		}
	}
}
