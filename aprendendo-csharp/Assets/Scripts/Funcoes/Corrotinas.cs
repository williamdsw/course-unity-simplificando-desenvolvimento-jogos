using UnityEngine;
using System.Collections;

public class Corrotinas : MonoBehaviour 
{
	//----------------------------------------------------------------------------------------//
	// FIELDS

	[SerializeField] private float segundosDeEspera = 5;
	
	//----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS

	private void Start ()
	{
		// Inicia as corrotinas
		StartCoroutine (PrimeiraCorrotina ());
		StartCoroutine (SegundaCorrotina (segundosDeEspera));
		StartCoroutine (TerceiraCorrotina (segundosDeEspera));
		StartCoroutine (CorrotinaBase ());
	}

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

	// Sintaxe: Tipo de acesso + tipo de retorno + nome + argumentos
	private IEnumerator PrimeiraCorrotina ()
	{
		Debug.Log ("Iniciei a primeira Corrotina");
		yield return new WaitForSeconds (segundosDeEspera * 2f);
		Debug.Log ("Depois de 10 segundos, voltam as funçoes normalmente");
	}

	private IEnumerator SegundaCorrotina (float segundos)
	{
		Debug.Log ("Iniciei a segunda Corrotina");
		yield return new WaitForSeconds (segundos);
		Debug.Log (string.Concat ("Depois de ", segundos, " segundos, voltam as funçoes normalmente"));
	}

	private IEnumerator TerceiraCorrotina (float segundos)
	{
		Debug.Log ("Iniciei a terceira Corrotina");

		float tempoAtual = 0f;
		while (tempoAtual < segundos) 
		{
			tempoAtual += Time.deltaTime;

			Debug.Log ("Esperando...");

			// Pausa ate o fim do frame
			yield return new WaitForEndOfFrame ();
		}

		Debug.Log (string.Concat ("Depois de ", segundos, " segundos, voltam as funçoes normalmente"));
	}

	private IEnumerator CorrotinaBase ()
	{
		Debug.Log ("Vou contar ate 10...");
		yield return StartCoroutine (ContarAte10 ());
		int soma = 5 + 5;
		Debug.Log (soma);
	}

	private IEnumerator ContarAte10 ()
	{
		for (int i = 1; i <= 10; i++) 
		{
			Debug.Log (i);
			yield return new WaitForSeconds (1);
		}
	}

	private IEnumerator SimulandoRPG ()
	{
		Debug.Log ("Turno do Inimigo");
		yield return StartCoroutine (EsperarPensar ());
		Debug.Log ("Inimigo ativou a magia de fogo");
		yield return StartCoroutine (EscolherAlvo ());
		Debug.Log ("O Inimigo escolheu o arqueiro!");
		yield return new WaitForSeconds (2);
		Debug.Log ("Atirou bola de fogo!");
		yield return new WaitForSeconds (3);
		Debug.Log ("15 HP de dano!");
	}

	private IEnumerator EsperarPensar ()
	{
		Debug.Log ("Pensando...");

		for (int i = 1; i <= 10; i++)
		{
			Debug.Log ("...");
			yield return new WaitForSeconds (1);
		}
	}

	private IEnumerator EscolherAlvo ()
	{
		Debug.Log ("Escolhendo o alvo...");

		for (int i = 1; i < 3; i++) 
		{
			Debug.Log ("...");
			yield return new WaitForSeconds (1);
		}
	}
}