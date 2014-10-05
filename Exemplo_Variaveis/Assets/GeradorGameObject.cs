using UnityEngine;
using System.Collections;

public class GeradorGameObject : MonoBehaviour {

	// variaveis public sao visiveis no inspector
	public GameObject novoGO;
	public Sprite imagem;
	// esta variavel nao aparece no inspector e por isso
	// comecamos seu nome com _
	private SpriteRenderer _spriteRenderer;
	
	void Start () {
		novoGO = new GameObject ("novoGO");
		// adiciona um componente SpriteRenderer
		_spriteRenderer = novoGO.AddComponent<SpriteRenderer> ();
		// altera sua propriedade sprite para o valor da variavel
		// imagem
		_spriteRenderer.sprite = imagem;
		// adiciona um componente Rigidbody2D, que ativa a fisica
		// no objeto novoGO
		novoGO.AddComponent<Rigidbody2D> ();
	}
}
