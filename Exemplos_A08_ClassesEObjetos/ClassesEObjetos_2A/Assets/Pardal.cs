using UnityEngine;
using System.Collections;

public class Pardal : Animal
{
    // atributo
    public string penas;

    // construtor
    public Pardal(string nome, string penas) : base (nome, 1)
    {
        this.penas = penas;
    }

    // metodos
    public void Saltitar()
    {
        Debug.Log(nome + " saltitando.");
    }

    public void Voar()
    {
        Debug.Log(nome + " voando.");
    }
}
