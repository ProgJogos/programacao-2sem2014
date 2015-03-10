using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Contador : MonoBehaviour {

	int contador;
	Text txtContador;

	void Start () {
		txtContador = GetComponent<Text> ();
		contador = 0;
	}
	
	void Update () {
		contador++;
		txtContador.text = contador.ToString ();
		Logger.Log(TipoLog.GAMEPLAY, "teste");
		Logger.mostrarGameplay = true;
	}
}
