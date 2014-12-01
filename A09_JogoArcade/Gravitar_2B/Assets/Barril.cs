using UnityEngine;
using System.Collections;

public class Barril : MonoBehaviour
{
	public int carga;
	public float tempoColeta;
	private float timer;

	void OnTriggerEnter2D(Collider2D outro)
	{
		if (outro.gameObject.layer == LayerMask.NameToLayer("Jogador"))
		{
			timer = 0;
		}
	}
	
	void OnTriggerStay2D(Collider2D outro)
	{
		if (outro.gameObject.layer == LayerMask.NameToLayer("Jogador"))
		{
			timer += Time.deltaTime;
			if (timer >= tempoColeta)
			{
				Nave.combustivel += carga;
				Destroy(this.gameObject);
			}
		}
	}
}
