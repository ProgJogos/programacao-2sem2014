using UnityEngine;
using System.Collections;

public class ExemploArray : MonoBehaviour 
{
	public int[] numeros;

	void Start () 
	{
		numeros = new int[10];
		
		numeros[0] = 0;
		numeros[5] = 500;
		numeros[8] = 800;
		// numeros[10] = 10;	
		
		print(numeros.Length);
		
		print (System.Array.IndexOf(numeros, 800));
		
	}
}
