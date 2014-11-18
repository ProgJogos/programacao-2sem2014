[System.Serializable]
public class Veiculo
{
	// atributos
	public int velocMax;
	public int capacidade;
	public int rodas;
	
	// construtor
	public Veiculo (int velocidade, int maxPassageiros, int nroRodas)
	{
		this.velocMax = velocidade;
		this.capacidade = maxPassageiros;
		this.rodas = nroRodas;
	}
	
	// metodo
	public virtual string Descrever ()
	{
		return "Este veiculo alcanca " + velocMax + 
			" km/h, carrega " + capacidade + " pessoas e tem " +
			rodas + " rodas.";
	}
}
