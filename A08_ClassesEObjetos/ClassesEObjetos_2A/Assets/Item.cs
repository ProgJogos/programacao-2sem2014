[System.Serializable]
public class Item
{
	// atributos / variaveis
	public string nome;
	public int peso;
	public int preco;

	// funcao construtora / construtor
	public Item(string nome, int peso, int preco)
	{
		this.nome = nome;
		this.peso = peso;
		this.preco = preco;
	}

	// metodo / funcao
	public string Descrever()
	{
		return nome + " pesa " + peso + " e custa " + preco;
	}
}
