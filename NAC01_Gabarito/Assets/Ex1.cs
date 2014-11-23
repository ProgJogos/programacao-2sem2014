using UnityEngine;
using System.Collections;

public class Ex1 : MonoBehaviour 
{
	public float a;
	public float b;

	void Start () 
	{
		float res = a + b;
		if (res >= 200)
		{
			print(res);
		}
	}
}
