using UnityEngine;
using System.Collections;

public class Acelerador : MonoBehaviour
{

	public GameObject corpo1;
	public GameObject corpo2;
	public float forca;

	// Use this for initialization
	void Start ()
	{
		corpo1.transform.right = Vector3.right;
		corpo2.transform.right = -Vector3.right;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.A)) {
			corpo1.rigidbody2D.AddForce (corpo1.transform.right * forca);
			corpo2.rigidbody2D.AddForce (corpo2.transform.right * forca);
		}
	}
}
