using UnityEngine;

public class CondicionalIF : MonoBehaviour 
{
    //----------------------------------------------------------------------------------------//
	// FIELDS

    [SerializeField] private bool condicao = true;
    [SerializeField] private int idade = 18;

    //----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS

	private void Start () 
    {
        VerificaCondicao ();
	}

    //----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

    private void VerificaCondicao ()
    {
        if (condicao)
        {
            idade = 0;
			Debug.Log (string.Concat ("Idade: ", idade));
        }
    }
}