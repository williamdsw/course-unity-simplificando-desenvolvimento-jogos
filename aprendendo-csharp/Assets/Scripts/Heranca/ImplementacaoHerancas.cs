using UnityEngine;

public class ImplementacaoHerancas : MonoBehaviour
{
	//----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS

	private void Start () 
	{
		InformacoesCachorro ();
		InformacoesHumano ();
	}

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

	private void InformacoesCachorro ()
	{
		Mamifero cachorro = new Cachorro ("Nina", Color.black, 8);
		cachorro.Locomover ();

		// Info
		Debug.Log (string.Concat ("Cor do pelo", cachorro.CorDoPelo));
	}

	private void InformacoesHumano ()
	{
		Mamifero homem = new Homem ("Fidelio", "Masculino", "Musico", Color.blue, 22);
		homem.Locomover ();
	}
}