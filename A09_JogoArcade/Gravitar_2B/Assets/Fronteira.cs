using UnityEngine;
using System.Collections;

public class Fronteira : MonoBehaviour
{
	public string fase;
	
	void OnTriggerEnter2D(Collider2D outro)
	{
		if (outro.gameObject.layer == LayerMask.NameToLayer("Jogador"))
		{
			// mudar de fase
			Application.LoadLevel(fase);
		}
	}
}
