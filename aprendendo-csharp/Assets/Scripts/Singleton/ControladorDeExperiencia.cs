using UnityEngine;

public class ControladorDeExperiencia : MonoBehaviour 
{
	//----------------------------------------------------------------------------------------//
	// FIELDS

	[SerializeField] private int maximoDeExperiencia;

	//----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS

	private void Start () 
	{
		GetMaximoExperiencia ();
	}

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

	private void GetMaximoExperiencia ()
	{
		maximoDeExperiencia += GerenciadorJogo.Instancia.MaximoEXP;
	}
}