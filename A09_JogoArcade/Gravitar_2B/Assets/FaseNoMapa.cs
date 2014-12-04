using UnityEngine;
using System.Collections;

public class FaseNoMapa : Fronteira 
{
	void Start () {
		if(Arbitro.primeiroCarregamento){
			Arbitro.ResetarJogo();
			Arbitro.primeiroCarregamento = false;
		}
	
		if(Arbitro.BuscarFase(fase).travada){
			Destroy(this.gameObject);
		}	
	}
}
