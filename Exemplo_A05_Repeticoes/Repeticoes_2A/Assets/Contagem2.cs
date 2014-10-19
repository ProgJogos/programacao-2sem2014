using UnityEngine;
using System.Collections;

public class Contagem2 : MonoBehaviour 
{
	void Start () 
	{
		for (int num = 1000; num >= 1; num--)
		{
			if (num % 100 == 0)
			{
				print (num + " centena");
			}
		}
	}
}
