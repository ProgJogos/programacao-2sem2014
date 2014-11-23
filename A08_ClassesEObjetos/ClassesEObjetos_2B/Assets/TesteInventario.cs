using UnityEngine;
using System.Collections;

public class TesteInventario : MonoBehaviour 
{
	public Inventario mochila;
	
	void Start () 
	{
		mochila = new Inventario(30);
		Item banana = new Item("cacho de bananas", 5, 5);
		// print ( mochila.Guardar(banana) );
		mochila.Guardar(banana);
		mochila.Guardar(banana);
		mochila.Guardar(banana);
		print (mochila.itens.Count);
		print (mochila.PesoAtual);
		// mochila.PesoAtual = 0;
	}
}
