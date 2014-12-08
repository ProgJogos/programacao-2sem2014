using UnityEngine;
using System.Collections;

public class Torque2D : MonoBehaviour
{
	public float forca;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.T)) {
			rigidbody2D.AddTorque (forca);
		}
	}
}
