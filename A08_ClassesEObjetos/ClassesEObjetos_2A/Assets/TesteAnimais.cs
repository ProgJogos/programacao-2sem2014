using UnityEngine;
using System.Collections;

public class TesteAnimais : MonoBehaviour
{
    void Start()
    {
        Animal baleia = new Animal("moby", 50000);
        baleia.Respirar();

        Gato felix = new Gato("felix o gato", 3, Color.black);
        felix.Respirar();
        felix.Miar();

        Pardal pardalzim = new Pardal("bob", "listradas");
        pardalzim.Saltitar();
    }
}
