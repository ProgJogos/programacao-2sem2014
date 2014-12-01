using UnityEngine;
using System.Collections;

public class Torre : MonoBehaviour
{

	public GameObject alvo;
	public int pontos;
	public GameObject prefabBala;
	public float velTiro;
	public float freqTiro;
	
	private bool destruir;
	private float timerTiro;
	
	void Update()
	{
	
		if (alvo == null)
		{
			return;
		}
	
		Vector2 mira = alvo.transform.position - transform.position;
		transform.right = mira;
	
		timerTiro += Time.deltaTime;
		if (timerTiro >= freqTiro)
		{
			timerTiro = 0;
			GameObject bala = Instantiate(
				prefabBala,
				transform.position,
				transform.rotation) as GameObject;
			bala.rigidbody2D.AddForce(bala.transform.right * velTiro);
			bala.layer = LayerMask.NameToLayer("BalaInimigo");
		}	
	}
	
	void LateUpdate()
	{
		if (destruir)
		{
			Destroy(this.gameObject);
		}
	}
	
	void OnCollisionEnter2D(Collision2D colisao)
	{
		destruir = true;
		Nave.pontos += pontos;
	}
}
