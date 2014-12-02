using UnityEngine;
using System.Collections;

public class Torre : MonoBehaviour
{

	public GameObject prefabBala;
	public GameObject alvo;
	public float velTiro;
	public float freqTiro;
	public int pontos;
	public float raio;

	private float timer;
	private bool morri;

	void Update () 
	{
		if (alvo == null)
		{
			return;
		}

		Vector2 mira = alvo.transform.position - transform.position;
		// Debug.DrawRay(transform.position, mira, Color.red);
		transform.right = mira;

		timer += Time.deltaTime;
		if (timer >= freqTiro && mira.magnitude < raio)
		{
			timer = 0;
			// disparo a bala
			GameObject bala = Instantiate(
				prefabBala,
				transform.position,
				transform.rotation) as GameObject;
			bala.rigidbody2D.AddForce(transform.right * velTiro);
			bala.layer = LayerMask.NameToLayer("BalaInimigo");
		}
	}
	
	void LateUpdate()
	{
		if (morri)
		{
			Destroy(this.gameObject);
		}
	}

	void OnCollisionEnter2D()
	{
		Nave.pontos += pontos;
		morri = true;
	}
}
