using UnityEngine;
using System.Collections;

public class TesteItem : MonoBehaviour
{
	public Item teste;
	
	void Start ()
	{
		// chamando o construtor de Item
		teste = new Item ("bob", 100, 0);
		
		print (teste.nome);
		print (teste.preco);
		teste.Descrever ();
	}
}
