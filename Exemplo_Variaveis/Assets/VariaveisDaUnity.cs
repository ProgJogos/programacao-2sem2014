using UnityEngine;
using System.Collections;

public class VariaveisDaUnity : MonoBehaviour {

	public Vector3 deslocamento;
	public Vector3 giro;
	public Color cor1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// transform.position += deslocamento;
		// Vector3 rotacaoAntiga = transform.rotation.eulerAngles;
		// transform.rotation = Quaternion.Euler (giro);
		transform.Translate (deslocamento);
		transform.Rotate (giro);
		// cor1.r += 0.01f;
		// Color corCamera = Camera.main.backgroundColor;
		// Color corTemporaria = Color.Lerp (corCamera, cor1, 0.05f);
		// Camera.main.backgroundColor = corTemporaria;
		cor1.g = Mathf.Sin (Time.time);
		Camera.main.backgroundColor = cor1;
	}
}
