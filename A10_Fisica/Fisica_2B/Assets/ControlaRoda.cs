using UnityEngine;
using System.Collections;

public class ControlaRoda : MonoBehaviour
{

	public float velocidade = 100;
	private JointMotor2D motor;
	private WheelJoint2D junta;
	
	void Start ()
	{
		junta = GetComponent<WheelJoint2D> ();
		junta.useMotor = true;
		motor.maxMotorTorque = 10000;
	}

	void Update ()
	{
		float dir = Input.GetAxis ("Horizontal");
		motor.motorSpeed = dir * velocidade;
		junta.motor = motor;
	}
}
