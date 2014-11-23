using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListaGO : MonoBehaviour 
{
	// molde de GO
	public GameObject bloco; 
	public List<GameObject> fileira;
	
	void Start () 
	{
		Vector3 pos = Vector3.zero;
		fileira = new List<GameObject>();
		while (fileira.Count < 10)
		{
			GameObject novo = Instantiate (
				bloco, 
				pos, 
				Quaternion.identity) as GameObject;
			fileira.Add(novo);
			pos.x += 2f;
		}
	}
	
	void Update () 
	{
		foreach (GameObject elemento in fileira)
		{
			Vector3 novaPos = elemento.transform.position;
			novaPos.y = Mathf.Sin(Time.time + novaPos.x*0.3f) * 4f;
			elemento.transform.position = novaPos;
		}
	}
}




