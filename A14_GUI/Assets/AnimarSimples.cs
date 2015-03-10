using UnityEngine;
using System.Collections;

public class AnimarSimples : MonoBehaviour {

	public AnimationCurve curva;
	public float tempoMax;
	public float timer;

	void Update () {
		timer += Time.deltaTime / tempoMax;
		transform.position = new Vector3(0, curva.Evaluate (timer), 0);
	}
}
