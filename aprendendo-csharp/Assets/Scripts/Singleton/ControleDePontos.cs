using UnityEngine;

public class ControleDePontos : MonoBehaviour 
{
	//----------------------------------------------------------------------------------------//
	// FIELDS

	[SerializeField] private int numeroDePontos;

	//----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS

	private void Start () 
	{
		NovaOnda ();
	}

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS
	
	private void NovaOnda()
	{
		numeroDePontos += GerenciadorDoGame.Instancia.PontosPorOnda;
	}
}