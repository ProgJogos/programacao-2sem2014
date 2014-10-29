using UnityEngine;
using System.Collections;

public class ExemploMatriz : MonoBehaviour 
{
	// declaracao
	public char[,] matriz;
	
	void Start () 
	{
		//inicializacao
		matriz = new char[10, 5];
		string visual = "";
		
		for (int linha = 0; linha < matriz.GetLength(1); linha++)
		{
			for (int coluna = 0; coluna < matriz.GetLength(0); 
				coluna++)
			{
				matriz[coluna, linha] = '0';
				visual += matriz[coluna, linha];
			}
			visual += '\n';	
		}
		print (visual);
	}
}
