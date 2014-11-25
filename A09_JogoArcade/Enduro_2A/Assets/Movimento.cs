using UnityEngine;
using System.Collections;

public class Movimento : MonoBehaviour {

	public float velocidade;
	public LayerMask mascara;

	void Update () {

		RaycastHit hit;

		if (Physics.Raycast (
				transform.position, 
				-Vector3.up, 
				out hit, 
				3f, 
				mascara)) 
		{
			//transform.rotation = hit.transform.rotation;
			transform.rotation = Quaternion.Slerp (
					transform.rotation, hit.transform.rotation, 
					Time.deltaTime * 10);
		}

		//

		transform.Translate (
			Input.GetAxis ("Horizontal"), 
			0, 
			velocidade, 
			Space.Self);
	}
}
