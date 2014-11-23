using UnityEngine;

public class Item
{
	// atributos / variaveis
	public string nome;
	public int peso;
	public float preco;
	
	// funcao construtora / construtor
	public Item (string nome, int peso, float preco)
	{
		this.nome = nome;
		this.peso = peso;
		this.preco = preco;
	}
	
	// metodo / funcao
	public void Descrever ()
	{
		Debug.Log (nome + " pesa " + peso + " e custa " + preco);
	}
}
