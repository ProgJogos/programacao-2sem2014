using UnityEngine;
using System.Collections;

public class TrocarCor : MonoBehaviour {

	public int id;
	
	void Update () {
		switch (id) {
		case 0 :
			renderer.material.color = Color.white;
			break;
		case 1 :
			renderer.material.color = Color.gray;
			break;
		case 2 :
			renderer.material.color = Color.black;
			break;
		default:
			renderer.material.color = Color.yellow;
			break;
		}
		// depois do switch
	}

	void OnMouseUpAsButton () {
		id++;
	}
}







