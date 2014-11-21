using UnityEngine;
using System.Collections;

public class TesteItem : MonoBehaviour
{
	//public Item mesa;
	//public Item[] inventario;
	public Inventario mochila;

	void Start()
	{
		//mesa = new Item ("mesa simples", 50, 100);
		//print (mesa);
		//print ( mesa.Descrever() );
		mochila = new Inventario(20);
		print(mochila.PesoAtual);
		mochila.Guardar(new Item("maca", 1, 5));
		print(mochila.PesoAtual);
		mochila.Guardar(new Item("colecao de pedras", 80, 1000));
		print(mochila.PesoAtual);
	}
}
