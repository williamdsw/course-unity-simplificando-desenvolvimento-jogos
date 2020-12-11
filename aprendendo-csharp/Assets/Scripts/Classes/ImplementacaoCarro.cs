using UnityEngine;

public class ImplementacaoCarro : MonoBehaviour 
{
	//----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS

	private void Start () 
	{
		InformacoesCamaro ();
		InformacoesFiesta ();
	}

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

	private void InformacoesCamaro ()
	{
		Carro camaro = new Carro ("Chevrolet", "Camaro", 2015, 300, 300, TipoDeCombustivel.Alcool);
		camaro.SetarNumeroDeSerie ();

		// Info
		Debug.Log ("--------- CARRO ---------");
		Debug.Log (string.Concat ("Fabricante: ", camaro.Fabricante));
		Debug.Log (string.Concat ("Modelo: ", camaro.Modelo));
		Debug.Log (string.Concat ("Ano de Fabricação: ", camaro.AnoFabricacao));
		Debug.Log (string.Concat ("Potência: ", camaro.Potencia));
		Debug.Log (string.Concat ("Velocidade Maxima: ", camaro.VelocidadeMaxima));
		Debug.Log (string.Concat ("Tipo de Combustível: ", camaro.TipoDeCombustivel));
		Debug.Log (string.Concat ("Numero de Série: ", camaro.NumeroDeSerie));
	}

	private void InformacoesFiesta ()
	{
		Carro fiesta = new Carro ("Ford", "Fiesta", 2005, 110, 180, true, TipoDeCombustivel.Gasolina);
		fiesta.SetarNumeroDeSerie ();

		// Info
		Debug.Log ("--------- CARRO ---------");
		Debug.Log (string.Concat ("Fabricante: ", fiesta.Fabricante));
		Debug.Log (string.Concat ("Modelo: ", fiesta.Modelo));
		Debug.Log (string.Concat ("Ano de Fabricação: ", fiesta.AnoFabricacao));
		Debug.Log (string.Concat ("Potência: ", fiesta.Potencia));
		Debug.Log (string.Concat ("Velocidade Maxima: ", fiesta.VelocidadeMaxima));
		Debug.Log (string.Concat ("Tipo de Combustível: ", fiesta.TipoDeCombustivel));
		Debug.Log (string.Concat ("Numero de Série: ", fiesta.NumeroDeSerie));
	}
}