
// Enumerador
public enum TipoDeCombustivel { Gasolina, Diesel, Alcool }

// Torna todos os itens publicos na aba. Serializa a classe
[System.Serializable]
public class Carro 
{
	//----------------------------------------------------------------------------------------//
	// FIELDS

	private string fabricante;
	private string modelo;
	private int anoFabricacao;
	private int potencia;
	private int velocidadeMaxima;
	private bool poluente;
	private TipoDeCombustivel tipoDeCombustivel;
	private static int numeroDeRodas = 4;
	private string numeroDeSerie;

	//----------------------------------------------------------------------------------------//
	// PROPERTIES

	public string Fabricante { get { return this.fabricante; } set { this.fabricante = value; }}
	public string Modelo { get { return this.modelo; } set { this.modelo = value; }}
	public int AnoFabricacao { get { return this.anoFabricacao; } set { this.anoFabricacao = value; }}
	public int Potencia { get { return this.potencia; } set { this.potencia = value; }}
	public int VelocidadeMaxima { get { return this.velocidadeMaxima; } set { this.velocidadeMaxima = value; }}
	public bool Poluente { get { return this.poluente; } set { this.poluente = value; }}
	public TipoDeCombustivel TipoDeCombustivel { get { return this.tipoDeCombustivel; } set { this.tipoDeCombustivel = value; }}
	public static int NumeroDeRodas { get { return numeroDeRodas; } set { numeroDeRodas = value; }}
	public string NumeroDeSerie { get { return this.numeroDeSerie; } set { this.numeroDeSerie = value; }}

	//----------------------------------------------------------------------------------------//
	// CONSTRUCTORS

	public Carro (string pFabricante, string pModelo, int pAnoFabricacao, int pPotencia, int pVelocidadeMaxima, TipoDeCombustivel pTipoDeCombustivel)
	{
		this.fabricante = pFabricante;
		this.modelo = pModelo;
		this.anoFabricacao = pAnoFabricacao;
		this.potencia = pPotencia;
		this.velocidadeMaxima = pVelocidadeMaxima;
		this.tipoDeCombustivel = pTipoDeCombustivel;
		DefinirPoluenteSwitch ();
	}

	public Carro (string pFabricante, string pModelo, int pAnoFabricacao, int pPotencia, int pVelocidadeMaxima, bool pSetarNumeroDeSerie, TipoDeCombustivel pTipoDeCombustivel)
	{
		this.fabricante = pFabricante;
		this.modelo = pModelo;
		this.anoFabricacao = pAnoFabricacao;
		this.potencia = pPotencia;
		this.velocidadeMaxima = pVelocidadeMaxima;
		this.tipoDeCombustivel = pTipoDeCombustivel;
		DefinirPoluenteSwitch ();

		if (pSetarNumeroDeSerie)
		{
			SetarNumeroDeSerie ();
		}
	}

	public Carro ()
	{
		this.fabricante = "";
		this.modelo = "";
		this.anoFabricacao = 0;
		this.potencia = 0;
		this.velocidadeMaxima = 0;
		this.tipoDeCombustivel = TipoDeCombustivel.Gasolina;
	}

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

	private void DefinirPoluenteIf ()
	{
		if (tipoDeCombustivel.Equals (TipoDeCombustivel.Alcool))
		{
			poluente = false;
		}
		else if (tipoDeCombustivel.Equals (TipoDeCombustivel.Diesel) || tipoDeCombustivel.Equals (TipoDeCombustivel.Gasolina))
		{
			poluente = true;
		}
	}

	private void DefinirPoluenteSwitch ()
	{
		switch (tipoDeCombustivel)
		{
			case TipoDeCombustivel.Alcool:
			{
				poluente = false;
				break;
			}

			case TipoDeCombustivel.Diesel: case TipoDeCombustivel.Gasolina:
			{
				poluente = false;
				break;
			}

			default: { break; }
		}
	}

	public void SetarNumeroDeSerie ()
	{
		numeroDeSerie = string.Concat (anoFabricacao, potencia, velocidadeMaxima);
	}

	public bool MaisPotenteQue (Carro carro)
	{
		return potencia > carro.potencia;
	}
}