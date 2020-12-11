using UnityEngine;

public class Funcoes : MonoBehaviour 
{
	//----------------------------------------------------------------------------------------//
	// FIELDS

	[SerializeField] private int latidos = 0;
	[SerializeField] private float resultado = 0;

	//----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS

	private void Start () 
	{
		SomarImprimir (9, 10);
		resultado = Multiplicar (10, 3);
		Debug.Log (resultado);
	}
	
	private void Update () 
	{
		Latir ();
	}

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

	private void Latir ()
	{
		Debug.Log ("Whoooff!");
		latidos++;
	}

	private void SomarImprimir (float a, float b)
	{
		float soma = a + b;
		Debug.Log (string.Concat (a, " + ", b, " = ", soma));
	}

	private float Multiplicar (float a, float b)
	{
		return (a * b);
	}
}