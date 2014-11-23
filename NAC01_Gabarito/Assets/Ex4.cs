using UnityEngine;
using System.Collections;

public class Ex4 : MonoBehaviour 
{
	public int hora;
	public int dias;
	public float segundos;
	
	void Update () 
	{
		segundos += Time.deltaTime;
		if (segundos >= 0.2f)
		{
			hora++;
			segundos = 0;
			if (hora == 24)
			{
				hora = 0;
				dias++;
				print(dias);
			}
		}
	}
}
