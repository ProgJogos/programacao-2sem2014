using UnityEngine;
using System.Collections;

public class Divisao : MonoBehaviour 
{
	void Start () 
	{
		print( Dividir (10, 0) );
	}
	
	int Dividir (int a, int b)
	{
		if (b == 0)
		{
			print ("divisao por zero");
			return 0;
		}
		else
		{
			return a / b;
		}
		
	}	
}
