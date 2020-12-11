using UnityEngine;

public class CondicionalElse : MonoBehaviour 
{
    [SerializeField] private int idade = 18;
    [SerializeField] private bool podeBeber; 
    [SerializeField] private bool idadeInvalida;

    //----------------------------------------------------------------------------------------//

	private void Start ()
    {
        VerificaIdadeParaBeber ();
    }

    //----------------------------------------------------------------------------------------//

    private void VerificaIdadeParaBeber()
    {
        if (idade >= 18)
        {
            podeBeber = true;
            idadeInvalida = false;
        }
        else if (idade < 0)
        {
            podeBeber = false;
            idadeInvalida = true;
        }
        else
        {
            podeBeber = false;
            idadeInvalida = false;
        }
    }
}