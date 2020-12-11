using UnityEngine;

// Classe derivada
public class Cachorro : Mamifero
{
	//----------------------------------------------------------------------------------------//
	// FIELDS

	private string nome;

	//----------------------------------------------------------------------------------------//
	// PROPERTIES

	public string Nome { get { return this.nome; } set { this.nome = value; } }

	//----------------------------------------------------------------------------------------//
	// CONSTRUCTORS

	// Construtor com variaveis proprias e da classe base
	public Cachorro (string pNome, Color pCorDoPelo, int pIdade) : base (pCorDoPelo, "Canis lopus familiaris", pIdade)
	{
		this.nome = pNome;
	}

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

	// Funcao propria
	public void Latir ()
	{
		MonoBehaviour.print ("auf!");
	}

	// Funcao herdada */
	public override void Locomover ()
	{
		MonoBehaviour.print ("Andando como cachorro");
		base.Locomover ();
	}
}