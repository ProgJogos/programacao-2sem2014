// importacao de bibliotecas
using UnityEngine;
using System.Collections;

// cabecalho de declaracao de classe
public class ExemploClasse : MonoBehaviour
{
	// declaracao de atributos / variaveis
	public string nome;
	int peso;
	public float preco;
	
	// declaracao de metodos / funçoes
	public void Descrever ()
	{
		print (nome + " pesa " + peso + " e custa " + preco);
	}
	
	// funcao-evento START
	void Start ()
	{
		Descrever ();
	}
}
