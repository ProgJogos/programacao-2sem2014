using UnityEngine;
using System.Collections;

public class OffsetAnimado : MonoBehaviour {

	public Vector2 velocidade;
		
	void Update () {
		renderer.material.mainTextureOffset +=
			velocidade * Time.deltaTime;
	}
}
