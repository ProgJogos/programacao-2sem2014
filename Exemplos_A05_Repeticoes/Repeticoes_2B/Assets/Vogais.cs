using UnityEngine;
using System.Collections;

public class Vogais : MonoBehaviour 
{
	public string palavra;
	public int vogais;

	void Start () 
	{
		vogais = 0;
		string minuscula = palavra.ToLower();
		foreach (char letra in minuscula) 
		{
			/*
			if (letra == 'a' ||
				letra == 'e' ||
			    letra == 'i' ||
			    letra == 'o' ||
			    letra == 'u')
			*/
			if ("aeiouáàéíóúãõâêô".IndexOf(letra) >= 0)
			{
				vogais++;
			}	
		}
		print(vogais);
	}
}
