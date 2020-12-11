using UnityEngine;

/* Utilizado para alocar so uma vez a instancia da classe na memoria, 
 * e exibir as variaveis no Inspector */
[System.Serializable]
public class Homem : Mamifero
{
	//----------------------------------------------------------------------------------------//
	// FIELDS

	private string nome;
	private string genero;
	private string cargo;

	//----------------------------------------------------------------------------------------//
	// PROPERTIES
	
	public string Nome { get { return this.nome; } set { this.nome = value; }}
	public string Genero { get { return this.genero; } set { this.genero = value; }}
	public string Cargo { get { return this.cargo; } set { this.cargo = value; }}

	//----------------------------------------------------------------------------------------//
	// CONSTRUCTORS

	public Homem (string pNome, string pGenero, string pCargo, Color pCorDoPelo, int pIdade) : base (pCorDoPelo, "Homo Sapiens Sapiens", pIdade)
	{
		this.nome = pNome;
		this.genero = pGenero;
		this.cargo = pCargo;
	}

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS
	
	public void PodeTrabalhar ()
	{
		if (idade > 18) 
		{
			MonoBehaviour.print (string.Concat (nome, " está trabalhando"));
		} 
		else 
		{
			MonoBehaviour.print (string.Concat (nome, " é menor de idade"));
		}
	}

	public void Estudar ()
	{
		MonoBehaviour.print (string.Concat (nome, " está estudando"));
	}

	public override void Locomover ()
	{
		MonoBehaviour.print ("Andando como homem");
		base.Locomover ();
	}
}