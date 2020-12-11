using UnityEngine;

// Classe base
public class Animal
{
	//----------------------------------------------------------------------------------------//
	// FIELDS

	protected string especie;
	protected int idade;

	//----------------------------------------------------------------------------------------//
	// CONSTRUCTORS

	public Animal (string pEspecie, int pIdade)
	{
		this.especie = pEspecie;
		this.idade = pIdade;
	}

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

	public virtual void Locomover ()
	{
		MonoBehaviour.print ("Movendo-se como Animal");
	}

	public void Comer ()
	{
		MonoBehaviour.print ("O animal esta comendo");
	}
}