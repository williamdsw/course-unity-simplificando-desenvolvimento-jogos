using UnityEngine;

public class LoopDoWhile : MonoBehaviour 
{
    //----------------------------------------------------------------------------------------//
	// FIELDS

	[SerializeField] private int inteiro = 0;

	//----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS

	private void Start ()
    {
        ExemploWhile ();
        ExemploDoWhile ();
    }

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

	private void ExemploWhile ()
    {
		inteiro = 0;
        while (inteiro < 100)
        {
            Debug.Log (string.Concat ("O inteiro vale: ", inteiro));
            inteiro++;
        }
    }

    private void ExemploDoWhile ()
    {
        inteiro = 0;
        do
        {
            Debug.Log (string.Concat ("O inteiro vale: ", inteiro));
            inteiro++;

        } while (inteiro < 100);
    }
}