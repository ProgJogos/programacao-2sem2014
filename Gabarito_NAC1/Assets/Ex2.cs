using UnityEngine;
using System.Collections;

public class Ex2 : MonoBehaviour 
{
	public int faces;

	void Start () 
	{
		int rolagem = Random.Range (1, faces + 1);
		print (rolagem);
	}
}
