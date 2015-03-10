using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarraDeVida : MonoBehaviour {

	public Gradient gradiente;
	Image imgBarra;
	public float vidaAtual;
	public float vidaMaxima;

	void Start () {
		imgBarra = GetComponent<Image> ();
		imgBarra.type = Image.Type.Filled;
		imgBarra.fillMethod = Image.FillMethod.Horizontal;
	}
	
	void Update () {
		imgBarra.fillAmount = vidaAtual / vidaMaxima;
		imgBarra.color = gradiente.Evaluate (vidaAtual/vidaMaxima);
	}
}
