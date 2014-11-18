using UnityEngine;
using System.Collections;

public class TesteVeiculo : MonoBehaviour
{
	public Veiculo aviao;
	public Bicicleta bike;
	public Carro meuCarro;
	
	void Start ()
	{
		// inicializacao (chamada de constrtores)
		aviao = new Veiculo (900, 200, 8);
		bike = new Bicicleta ("pedallegal");
		meuCarro = new Carro ("CEY-9976", 250);
		
		print (aviao.Descrever ());
		print (bike.Descrever ());
		print (meuCarro.Descrever ());
	}
}
