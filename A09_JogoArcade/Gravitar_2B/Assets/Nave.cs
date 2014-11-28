using UnityEngine;
using System.Collections;

public class Nave : MonoBehaviour 
{

	// atributos
	public int vidas;
	public float forcaFoguete;
	public static int pontos = 0;
	public float velTiro;
	public int combustivel;
	public float velGiro;
	public int taxaConsumo;
	public GameObject prefabBala;
	private bool destruir;
	
	private float giro;
	private bool fogueteLigado;
	
	void Update () 
	{
		// PEGANDO ENTRADA DO JOGADOR
		giro = -1 * Input.GetAxis("Horizontal");
		fogueteLigado = Input.GetKey(KeyCode.Z);
		
		if(Input.GetKeyDown(KeyCode.X))
		{
			GameObject bala = Instantiate(
				prefabBala,
				transform.position,
				transform.rotation) as GameObject;
			bala.rigidbody2D.AddForce(bala.transform.right * velTiro);
		}
	}
	
	void FixedUpdate () 
	{
		rigidbody2D.angularVelocity = giro * velGiro;
		if(fogueteLigado && combustivel > 0) 
		{
			rigidbody2D.AddForce(transform.right * forcaFoguete);
			combustivel -= taxaConsumo;
		}
	}
	
	void LateUpdate () 
	{
		if(destruir) 
		{
			Destroy(this.gameObject);
		}
	}
	
	void OnCollisionEnter2D (Collision2D colisao)
	{
		destruir = true;
	}
}
