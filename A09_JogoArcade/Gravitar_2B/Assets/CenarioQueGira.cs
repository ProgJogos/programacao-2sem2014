using UnityEngine;
using System.Collections;

public class CenarioQueGira : MonoBehaviour
{
	public float velocidade;
	
	void Update()
	{
		transform.Rotate(0, 0, velocidade);	
	}
}
