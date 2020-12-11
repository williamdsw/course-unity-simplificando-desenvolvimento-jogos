using UnityEngine;

public class OutrasFuncoes : MonoBehaviour 
{
	//----------------------------------------------------------------------------------------//
	// FIELDS

	[SerializeField] private int[] valores = new int[5];
	[SerializeField] private float valorQ1 = 0;
	[SerializeField] private float valorQ2 = 0;
	[SerializeField] private float valorQ3 = 0;
	[SerializeField] private float dividendo = 0;
	[SerializeField] private float divisor = 0;
	[SerializeField] private float resto = 0;
	[SerializeField] private float quociente = 0;

	//----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS

	private void Start ()
	{
		TrocarValorDeIndice (valores, 0, 5); 					// Por referencia
		SomarComTres (valorQ1); 								// Por valor
		SomarComDois (ref valorQ2); 							// Por ref com valor
		SomarComQuatro (out valorQ3);							// Por out com valor
		quociente = Dividir (dividendo, divisor, ref resto);
	}

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

	// Passa por referencia (vetor)
	private void TrocarValorDeIndice (int[] vetor, int indice, int valor)
	{
		vetor[indice] = valor;
	}

	// Passa por valor
	private void SomarComTres (float valor)
	{
		valor += 3;
		Debug.Log (string.Concat ("Resultado = ", valor));
	}

	// Passando valor mas por referencia (ref)
	private void SomarComDois (ref float valor)
	{
		valor += 2;
		Debug.Log (string.Concat ("Resultado = ", valor));
	}

	// Inicializando a variavel (out)
	private void SomarComQuatro (out float valor)
	{
		valor = 0;
		valor += 4;
		Debug.Log (string.Concat ("Resultado = ", valor));
	}

	private int Dividir (float valor, float divisor, ref float resto)
	{
		resto = 0;
		int quociente = 0;

		while (valor > 0) 
		{
			if ((valor - divisor) >= 0)
			{
				quociente++;
				valor -= divisor;
			}
			else
			{
				resto = valor;
				break;
			}
		}

		return quociente;
	}
}