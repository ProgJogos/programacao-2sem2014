using UnityEngine;
using System.Collections;

public class Torque : MonoBehaviour
{
	public Vector3 forca;
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.T)) {
			rigidbody.AddTorque (forca);
		}
	}
}
