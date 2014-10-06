using UnityEngine;
using System.Collections;

public class Combate : MonoBehaviour {

	public int dano;
	public int saude;
	
	void Update () {
		// exercicio de estrutura de decisao
		if (dano > saude) {
			print ("morto");
		}
		else {
			print ("vivo");
		}
	}
}
