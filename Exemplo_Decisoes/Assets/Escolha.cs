using UnityEngine;
using System.Collections;

public class Escolha : MonoBehaviour {

	public int opcao;
	
	void Update () {
		// exemplo de ESCOLHA-CASO
		switch (opcao) {
		case 1 : 
			print ("opcao 1");
			break;
		case 2 :
			print ("opcao 2");
			break;
		case 3 : 
			print ("opcao 3");
			break;
		default :
			print ("opcao invalida");
			break;
		}
	}
}
