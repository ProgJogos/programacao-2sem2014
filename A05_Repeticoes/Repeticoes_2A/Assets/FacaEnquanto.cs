using UnityEngine;
using System.Collections;

public class FacaEnquanto : MonoBehaviour 
{
	void Start () 
	{
		int dado;
		do
		{
			dado = Random.Range(1, 7);
			print(dado);
		}
		while (dado > 1 && dado < 6);
		if (dado == 1)
		{
			print ("ganhou");
		}
		else
		{
			print("perdeu"); 
		}
	}
}
