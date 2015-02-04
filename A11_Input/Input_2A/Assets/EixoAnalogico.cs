using UnityEngine;
using System.Collections;

public class EixoAnalogico : MonoBehaviour
{
	void Update()
	{
		Debug.Log(Input.GetAxis("EsqDir"));
	}
}
