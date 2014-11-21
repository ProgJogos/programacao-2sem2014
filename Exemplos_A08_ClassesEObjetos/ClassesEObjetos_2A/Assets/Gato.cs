using UnityEngine;

public class Gato : Animal
{
    public Color corPelo;

    public Gato(string nome, int peso, Color cor) : 
        base (nome, peso)
    {
        this.corPelo = cor;
    }

    public void Miar()
    {
        Debug.Log(nome + ": miau!");
    }
}
