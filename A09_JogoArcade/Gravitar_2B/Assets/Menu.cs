using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{

	void Update()
	{
		if (Nave.vidas == 0)
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				Arbitro.ResetarJogo();
			}		
		}
	
	}
}
