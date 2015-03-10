using UnityEngine;
using System.Collections;

public class AcaoBotao : MonoBehaviour {

	public void Agir() {
		print ("açao!!!!");
	}

	public void AgirComParametros(string msg) {
		print ("msg: " + msg);
	}
}
