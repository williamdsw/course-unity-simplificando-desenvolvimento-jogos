using UnityEngine;

public class GeradorDeArestas : MonoBehaviour
{
	private EdgeCollider2D edgeCollider2D;

	//----------------------------------------------------------------------------------//

	private void Awake () 
	{
		edgeCollider2D = this.GetComponent<EdgeCollider2D>();
	}

	private void Start ()
    {
        DefineBordas ();
    }

	//----------------------------------------------------------------------------------//

    private void DefineBordas()
    {
        Camera mainCamera = Camera.main;

        // Colisor e pontos
        Vector2 cantoInferiorEsquerdo = mainCamera.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector2 cantoSuperiorEsquerdo = mainCamera.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));
        Vector2 cantoSuperiorDireito = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        Vector2 cantoInferiorDireito = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));

        /* Atualizando pontos */
        edgeCollider2D.points = new Vector2[]
        {
            cantoInferiorEsquerdo,
            cantoSuperiorEsquerdo,
            cantoSuperiorDireito,
            cantoInferiorDireito,
            cantoInferiorEsquerdo
        };
    }
}