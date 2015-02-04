using UnityEngine;
using System.Collections;

public class OlharComMouse : MonoBehaviour
{
	void Update()
	{
		Vector2 delta = new Vector2(
			Input.GetAxis("HorMouse"),
			Input.GetAxis("VerMouse"));
		Debug.Log(delta);
		transform.Rotate(
			-delta.y, 
			delta.x, 0, Space.Self);
	}
}
