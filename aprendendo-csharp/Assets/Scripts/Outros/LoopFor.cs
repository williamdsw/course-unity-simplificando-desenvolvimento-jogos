using UnityEngine;

public class LoopFor : MonoBehaviour 
{
    //----------------------------------------------------------------------------------------//
	// FIELDS

	[SerializeField] private string[] textos = new string[3];

	//----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS

	private void Start ()
    {
        ExemploFor ();
    }

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS

    private void ExemploFor ()
    {
		// Preenche
        textos[0] = "It's a wonderful world.";
        textos[1] = "No, it's not.";
        textos[2] = "Dot dot dot.";

        for (int i = 1; i <= 10; i++)
        {
            int multiploDeTres = i * 3;
            Debug.Log (multiploDeTres);
        }

        for (int i = 0; i < textos.Length; i++)
        {
            Debug.Log (textos[i]);
        }

        foreach (string texto in textos)
        {
            Debug.Log (texto);
        }
    }
}