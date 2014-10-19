using UnityEngine;
using System.Collections;

public class Multiplos23 : MonoBehaviour {
	
	void Start () {
		int num = 0;
		int contador = 0;
		while (contador < 10)
		{
			if (num % 23 == 0 && num % 69 == 0)
			{
				print(num);
				contador++;
			}
			num++;
		}
	}
}
