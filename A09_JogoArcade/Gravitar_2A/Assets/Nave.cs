using UnityEngine;
using System.Collections;

public class Nave : MonoBehaviour
{
	public static int vidas = 3;
	public static int pontos = 0;

	public float velocidadeRotacao;
	public float forcaFoguete;
	public int combustivel;
	public int taxaConsumo;

	public GameObject prefabBala;
	public float velTiro;

	private float giro;
	private bool fogueteLigado;

	void Update()
	{
		// girar conforme esq-dir for apertado
		giro = -1 * Input.GetAxis("Horizontal");
		// quando apertar X, ligar foguete
		if (Input.GetKey(KeyCode.X) && combustivel > 0)
		{
			fogueteLigado = true;
		} else
		{
			fogueteLigado = false;
		}
		// quando acabou de apertar Z, atirar
		if (Input.GetKeyDown(KeyCode.Z))
		{
			GameObject bala = Instantiate(
				prefabBala,
				transform.position,
				transform.rotation) as GameObject;
			bala.rigidbody2D.AddForce(transform.right * velTiro);
		}
	}

	void FixedUpdate()
	{
		// aplicando o giro como velocidade angular
		rigidbody2D.angularVelocity = giro * velocidadeRotacao;
		// quando foguete estiver ligado, aplicar forca
		if (fogueteLigado)
		{
			combustivel -= taxaConsumo;
			rigidbody2D.AddForce(transform.right * forcaFoguete);
		}
	}

	void OnCollisionEnter2D()
	{
		vidas--;
		print("vidas: " + vidas);
		Destroy(this.gameObject);
	}
}
