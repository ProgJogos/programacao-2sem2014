using UnityEngine;
using System.Collections;

public class CliquePorRaio : MonoBehaviour
{

	void OnMouseOver()
	{
		// quando eu clicar com botao esquerdo
		if (Input.GetMouseButtonDown(0))
		{
			// cria um raio a partir da camera passando pelo mouse
			Ray raio = Camera.main.ScreenPointToRay(
			Input.mousePosition);
			// variavel para guardar o resultado do lancamento
			RaycastHit colisao;
			// lancamento do raio no mundo fisico
			Physics.Raycast(raio, out colisao);
			Debug.DrawLine(transform.position, colisao.point, 
		               Color.yellow);
			Debug.Log(colisao.point);
			GameObject cubo = GameObject.CreatePrimitive(
				PrimitiveType.Cube);
			cubo.transform.position = colisao.point;
		}

		// quando eu clicar com botao direito
		if (Input.GetMouseButtonDown(1))
		{
			// cria um raio a partir da camera passando pelo mouse
			Ray raio = Camera.main.ScreenPointToRay(
				Input.mousePosition);
			// variavel para guardar o resultado do lancamento
			RaycastHit colisao;
			// lancamento do raio no mundo fisico
			Physics.Raycast(raio, out colisao);
			Debug.DrawLine(transform.position, colisao.point, 
			               Color.yellow);
			Debug.Log(colisao.point);
			GameObject bola = GameObject.CreatePrimitive(
				PrimitiveType.Sphere);
			bola.transform.position = colisao.point;
		}
	}
}
