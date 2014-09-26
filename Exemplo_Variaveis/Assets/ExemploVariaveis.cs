using UnityEngine;
using System.Collections;

// este eh o endereco do repositorio:
// https://github.com/progjogos/programacao-2sem2014

public class ExemploVariaveis : MonoBehaviour {

	public bool escreveMsg;
	public int total;
	public float segundos;
	public char tecla;
	public string nome;

	// aqui eh declarada a funcao Start, que eh 
	// executada quando este objeto surge na cena
	void Start () {
		escreveMsg = true; // variavel bool
		total = 0; // variavel int
		segundos = 0; // variavel float
		tecla = 'T'; // variavel char
	}

	// aqui esta a declaracao da funcao Update,
	// executada uma vez a cada frame
	void Update () {
		// na linha abaixo, aumentamos o valor 
		// da variavel total em 1 unidade
		total++; 
		segundos += Time.deltaTime;
		print ("A pessoa " + nome + " sobreviveu " + 
			segundos + " segundos.");
	}
}





