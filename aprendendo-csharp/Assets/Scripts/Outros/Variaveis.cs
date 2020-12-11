using UnityEngine;

public class Variaveis : MonoBehaviour 
{
    //----------------------------------------------------------------------------------------//
	// FIELDS

    [SerializeField] private int meuInteiro = 1;
    [SerializeField] private float meuFlutuante = 1.45f;
    [SerializeField] private string meuTexto = "Texto de Exemplo";
    [SerializeField] private bool meuBooleano = false;

	//----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS
	
	private void Start ()
    {
        ExibeValores ();
    }

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

    private void ExibeValores()
    {
        Debug.Log (string.Concat ("Inteiro: ", meuInteiro));
        Debug.Log (string.Concat ("Flutuante: ", meuFlutuante));
        Debug.Log (string.Concat ("Texto: ", meuTexto));
        Debug.Log (string.Concat ("Booleano: ", meuBooleano));
    }
}