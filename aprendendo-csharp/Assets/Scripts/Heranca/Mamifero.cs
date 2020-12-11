using UnityEngine;

// Classe derivada
[System.Serializable]
public class Mamifero : Animal
{
	//----------------------------------------------------------------------------------------//
	// FIELDS

	protected Color corDoPelo;

	//----------------------------------------------------------------------------------------//
	// PROPERTIES
	
	public Color CorDoPelo { get { return this.corDoPelo; } set { this.corDoPelo = value; }}

	//----------------------------------------------------------------------------------------//
	// CONSTRUCTORS

	public Mamifero (Color pCorDoPelo, string pEspecie, int pIdade) : base (pEspecie, pIdade)
	{
		this.corDoPelo = pCorDoPelo;
	}

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

	public void Mamar ()
	{
		MonoBehaviour.print ("O mamifero esta mamando");
	}

	public override void Locomover ()
	{
		MonoBehaviour.print ("Movendo-se como mamifero");
		base.Locomover ();
	}
}