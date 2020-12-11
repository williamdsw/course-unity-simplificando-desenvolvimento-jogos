using UnityEngine;

public class GeradorDeBlocos : MonoBehaviour 
{
    // Configuracao
	[SerializeField] private GameObject[] blocos;
	[SerializeField] private int quantidadeDeLinhas;

    // Variaveis de cache
    private SpriteRenderer blocoSpriteRenderer;

    //----------------------------------------------------------------------------------//

    private void Awake () 
    {
        if (blocos.Length == 0) { return; }
        blocoSpriteRenderer = blocos[0].GetComponent<SpriteRenderer>();
    }

	private void Start () 
	{
		CriarGrupoDeBlocos ();
	}

    //----------------------------------------------------------------------------------//

    private void CriarGrupoDeBlocos ()
    {
        // Limites do sprite
        Bounds limitesDoBloco = blocoSpriteRenderer.bounds;
        float larguraDoBloco = limitesDoBloco.size.x;
        float alturaDoBloco = limitesDoBloco.size.y;

        // Variaveis out
        float larguraDaTela = 0f;
        float alturaDaTela = 0f;
        float multiplicadorDaLargura = 0f;
        int quantidadeColunas = 0;

        // Informacoes do bloco (valores para variaveis out)
        ColetarInformacoesDoBloco (larguraDoBloco, out larguraDaTela, out alturaDaTela, out quantidadeColunas, out multiplicadorDaLargura);
        GerenciadorDoGame.NumeroTotalBlocos = (quantidadeDeLinhas * quantidadeColunas);

        for (int linha = 0; linha < quantidadeDeLinhas; linha++)
        {
            for (int coluna = 0; coluna < quantidadeColunas; coluna++)
            {
                // Escolhe um bloco aleatorio
                GameObject blocoAleatorio = blocos[Random.Range (0, blocos.Length)];
                GameObject blocoInstanciado = (GameObject) Instantiate (blocoAleatorio);

                // Posicao do bloco
                float x = - (larguraDaTela * 0.5f) + (coluna * larguraDoBloco * multiplicadorDaLargura);
                float y = (alturaDaTela * 0.5f) - (linha * alturaDoBloco);
                blocoInstanciado.transform.position = new Vector3 (x, y, 0);

                // Nova largura e escala
                float novaLarguraDoBloco = blocoInstanciado.transform.localScale.x * multiplicadorDaLargura;
                blocoInstanciado.transform.localScale = new Vector3 (novaLarguraDoBloco, blocoAleatorio.transform.localScale.y, 1);
            }
        }
    }

    private void ColetarInformacoesDoBloco (float larguraDoBloco, out float larguraDaTela, out float alturaDaTela, out int colunas, out float multiplicadorDaLargura)
    {
        Camera mainCamera = Camera.main;
        larguraDaTela = (mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width, 0, 0)) - mainCamera.ScreenToWorldPoint (new Vector3(0, 0, 0))).x;
        alturaDaTela = (mainCamera.ScreenToWorldPoint (new Vector3 (0, Screen.height, 0)) - mainCamera.ScreenToWorldPoint (new Vector3(0, 0, 0))).y;

        /* Vai retornar o numero de colunas.
         * exemplo 1 - "colunas = Mathf.Floor (larguraDaTela / larguraDoBloco)";
         * exemplo 2 - usar o typeof "cast = (int) (valor)"
         * ambos vao eliminar as casas decimais do float */
        colunas = (int) (larguraDaTela / larguraDoBloco);
        multiplicadorDaLargura = larguraDaTela / (colunas * larguraDoBloco);
    }
}