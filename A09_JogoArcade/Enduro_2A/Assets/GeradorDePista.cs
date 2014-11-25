using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GeradorDePista : MonoBehaviour {

	public Trecho[] prefabsTrechos;
	public int nroTrechos;
	public List<Trecho> pista;

	void Start () {

		pista = new List<Trecho> ();

		// criar 1o trecho
		GameObject novoTrecho = Instantiate (
			prefabsTrechos [1].gameObject,
			Vector3.zero,
			Quaternion.identity) as GameObject;

		pista.Add( novoTrecho.GetComponent<Trecho>() );

		while (pista.Count < nroTrechos) 
		{
			GameObject segmento = Instantiate (
				prefabsTrechos [Random.Range(0, 2)].gameObject,
				pista[pista.Count - 1].encaixe.position,
				pista[pista.Count - 1].encaixe.rotation) 
				as GameObject;
			pista.Add( segmento.GetComponent<Trecho>() );
		}
	}
}
