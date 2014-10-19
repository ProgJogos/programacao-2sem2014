using UnityEngine;
using System.Collections;

public class Contagem : MonoBehaviour 
{
	void Start () 
	{
		int num, multiplos;
		multiplos = 0;
		for (num = 1; num < 1000; num++)
		{
			if (num % 7 == 0)
			{
				print (num);
				multiplos++;
			}
		}
		print (multiplos);
	}	
}
