using UnityEngine;

public class Plataforma : MonoBehaviour
{
	// Configuracao
    private float velocidadeDeMovimento = 15f;	
	private float limiteEmX = 7.5f;

	// Cache
	private SpriteRenderer spriteRenderer;

	//----------------------------------------------------------------------------------//

	private void Awake () 
	{
		spriteRenderer = this.GetComponent<SpriteRenderer>();
	}

	private void Start ()
    {
        DefineLimiteX ();
    }

    private void Update ()
    {
        Movimentar ();
    }

    //----------------------------------------------------------------------------------//

    private void DefineLimiteX ()
    {

        /* Define um novo limite em x caso a tela for redimencionada.
         *  Pega o x do Vector3, menos o x do bounds.extents do SpriteRenderer.
         *  Extents e metade do valor de size */
		Vector3 larguraTela = new Vector3 (Screen.width, 0, 0);
        float larguraEmX = Camera.main.ScreenToWorldPoint(larguraTela).x;
        float larguraSpriteX = spriteRenderer.bounds.extents.x;
        limiteEmX = (larguraEmX - larguraSpriteX);
    }

	private void Movimentar ()
    {
        // -1 esquerda, 0 parado, 1 direita
        float horizontal = Input.GetAxis ("Horizontal");

        // Atualiza posicao
        transform.position += (Vector3.right * horizontal * velocidadeDeMovimento * Time.deltaTime);
        float xAtual = transform.position.x;
        xAtual = Mathf.Clamp (xAtual, - limiteEmX, limiteEmX);
        transform.position = new Vector3 (xAtual, transform.position.y, transform.position.z);
    }
}