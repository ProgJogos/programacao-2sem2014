using UnityEngine;

public class Animal
{
	// atributos
	public int peso;
	public int idade;
	public string nome;

	// construtor
	public Animal (string nome, int peso)
	{
		this.nome = nome;
		this.peso = peso;
		this.idade = 0;
	}

	// metodo
	public void Respirar ()
	{
		Debug.Log (nome + " esta respirando.");
	}
}
