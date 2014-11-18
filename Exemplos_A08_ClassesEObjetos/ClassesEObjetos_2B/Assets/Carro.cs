[System.Serializable]
public class Carro : Veiculo
{
	// atributos
	public string placa;
	
	// construtor
	public Carro (string registro, int velocidade) 
		: base (velocidade, 5, 4)
	{
		this.placa = registro;
	}
	
	public override string Descrever ()
	{
		string msgPai = base.Descrever ();
		return "A placa do carro eh " + placa + ". " + msgPai;
	}
}
