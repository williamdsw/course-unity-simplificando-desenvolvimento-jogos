using UnityEngine;

public class VariasCondicoes : MonoBehaviour 
{
    //----------------------------------------------------------------------------------------//
	// FIELDS

    [SerializeField] private int idade = 18;
    [SerializeField] private bool idadeValida = true;
    [SerializeField] private bool compraAutorizada = false;

    //----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS

	private void Start ()
    {
        VerificaCondicoes ();
    }

    //----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

    private void VerificaCondicoes ()
    {
        // Varias condicoes dentro de um if
        if ((idade >= 18 && idadeValida) || idade >= 40)
        {
            compraAutorizada = true;
        }
    }
}