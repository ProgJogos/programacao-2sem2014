using UnityEngine;
using System.Collections;

public class MenuInGame : MonoBehaviour {

	void Update () 
	{
		if (Nave.vidas == 0 && Input.GetKeyDown(KeyCode.R))
		{
			Arbitro.ResetarJogo();
		}
	}
}
