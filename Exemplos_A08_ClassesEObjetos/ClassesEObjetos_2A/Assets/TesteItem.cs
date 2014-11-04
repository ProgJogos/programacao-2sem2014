using UnityEngine;
using System.Collections;

public class TesteItem : MonoBehaviour 
{
	public Item mesa;

	void Start () {
		mesa = new Item ("mesa simples", 50, 100);
		print (mesa);
		print ( mesa.Descrever() );
	}
}
