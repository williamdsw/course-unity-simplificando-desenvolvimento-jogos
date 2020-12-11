using UnityEngine;
using System.Collections;

public class ExemploGetComponent : MonoBehaviour 
{
	//----------------------------------------------------------------------------------------//
	// FIELDS

	private Light luz;

	//----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS

	private void Awake () 
	{
		luz = this.GetComponent<Light>();
	}

	private void Start () 
	{
		StartCoroutine (Colorindo ());
	}

	//----------------------------------------------------------------------------------------//
	// HELPER FUNCTIONS
	
	// Corrotina
	private IEnumerator Colorindo ()
	{
		if (!luz) { yield return null; }

		// Vermelho
		Debug.Log ("Luz Vermelha");
		luz.intensity = 3f;
		luz.color = Color.red;
		yield return new WaitForSeconds (2f);

		// Verde
		luz.color = Color.green;
		Debug.Log ("Luz Verde");
		yield return new WaitForSeconds (3f);

		// Azul
		Debug.Log ("Luz Azul");
		luz.intensity = 10f;
		luz.color = Color.blue;
		luz.range = 5f;
		yield return new WaitForSeconds (5f);

		// Amarelo
		Debug.Log ("Luz Amarela");
		luz.intensity = 1f;
		luz.color = Color.yellow;
		luz.range = 30f;
	}
}