using UnityEngine;
using System.Collections;

public class Variaveis : MonoBehaviour {

	public bool escreverMsg;
	public int contador;
	public float tempo;
	public string nome;

	// Use this for initialization
	void Start () {
		escreverMsg = true;
		contador = 0;
		tempo = 0;
		// nome = "bob";
	}
	
	// Update is called once per frame
	void Update () {

		tempo += Time.deltaTime;

		if (escreverMsg) {
			print ("a personagem se chama " + nome);
			contador = contador + 1;
		}
	}
}
