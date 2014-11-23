[System.Serializable]
public class Bicicleta : Veiculo
{
	// atributo
	public string pedal;
	
	// construtor
	public Bicicleta (string marcaPedal) : base (50, 1, 2)
	{
		this.pedal = marcaPedal;
	}
	
	public override string Descrever ()
	{
		string msgVeiculo = base.Descrever ();
		return "Esta bicicleta tem pedais " + pedal + 
			". " + msgVeiculo; 
	}
}
