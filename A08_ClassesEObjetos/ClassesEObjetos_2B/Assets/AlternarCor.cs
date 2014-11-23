using UnityEngine;
using System.Collections;

public class AlternarCor : TrocarCor
{
	public float intervalo;
	private float _tempo;
	private Color _corInicial;
	
	void Start ()
	{
		_corInicial = renderer.material.color;
		_tempo = 0;
	}
	
	void Update ()
	{
		_tempo += Time.deltaTime;
		if (_tempo >= intervalo) {
			_tempo = 0;
			if (renderer.material.color == _corInicial) {
				renderer.material.color = cor;
			} else {
				renderer.material.color = _corInicial;
			}
		}
	}
}
