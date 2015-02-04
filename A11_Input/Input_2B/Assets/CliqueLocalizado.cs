using UnityEngine;
using System.Collections;

public class CliqueLocalizado : MonoBehaviour
{
	
	void OnMouseDown()
	{
		Ray raio = Camera.main.ScreenPointToRay(
			Input.mousePosition);
		RaycastHit res;
		Physics.Raycast(raio, out res);
		GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
		Debug.Log(res.collider.name);
		cubo.transform.position = res.point;
	}
}
