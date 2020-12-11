using UnityEngine;

public class Arrays : MonoBehaviour 
{
    //----------------------------------------------------------------------------------------//
	// FIELDS

	[SerializeField] private int[] arrayInteiros = new int[3];

	//----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS

	private void Start ()
    {
        PreencheIteraArray ();
    }

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

    private void PreencheIteraArray ()
    {
        arrayInteiros[0] = -3;
        arrayInteiros[1] = 7;
        arrayInteiros[2] = 10;

        for (int i = 0; i < arrayInteiros.Length; i++)
        {
            Debug.Log (string.Concat ("Inteiro: ", arrayInteiros[i]));
        }
    }
}