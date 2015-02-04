using UnityEngine;
using System.Collections;

public class BotoesMouse : MonoBehaviour
{
	void Update()
	{
		Debug.Log("esquerda " + Input.GetMouseButton(0));
		Debug.Log("direita " + Input.GetMouseButton(1));
		Debug.Log("meio " + Input.GetMouseButton(2));
		Debug.Log("rodinha " + Input.mouseScrollDelta);
	}
}
