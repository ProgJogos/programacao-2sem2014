using UnityEngine;
using System.Collections;

public class ControlaLogger : MonoBehaviour {

	public bool Arte;
	public bool AI;
	public bool Gameplay;
	public bool Som;

	void Update() {
		Logger.mostrarArte = Arte;
		Logger.mostrarAI = AI;
		Logger.mostrarSom = Som;
		Logger.mostrarGameplay = Gameplay;
	}
}
