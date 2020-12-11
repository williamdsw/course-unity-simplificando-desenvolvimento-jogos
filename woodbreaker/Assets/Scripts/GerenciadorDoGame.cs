using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Gerencia todas as coisas basicas do jogo
public class GerenciadorDoGame : MonoBehaviour 
{
	[Header ("Elementos Gráficos do Menu Principal")]
	[SerializeField] private Button botaoJogar;
	[SerializeField] private Button botaoFechar;

	[Header ("Elementos Gráficos da Fase Principal")]
	[SerializeField] private Image imageEstrelas;
	[SerializeField] private GameObject canvasGameOver;
	[SerializeField] private TextMeshProUGUI numeroDePontosText;
	[SerializeField] private Button botaoJogarNovamente;
	[SerializeField] private Button botaoVoltarMenu;

	[Header ("Objetos In-Game")]
	[SerializeField] private Bola bola;
	[SerializeField] private Plataforma plataforma;

	// Variaveis de estado
	private static int numeroTotalBlocos;
	private static int numeroBlocosDestruidos;
	private int numeroDePontos;

	// Variaveis de cache
	private static GerenciadorDoGame instancia;

	//----------------------------------------------------------------------------------//
	// PROPERTIES

	public static int NumeroTotalBlocos { get { return numeroTotalBlocos; } set { numeroTotalBlocos = value; }}
	public static int NumeroBlocosDestruidos { get { return numeroBlocosDestruidos; } set { numeroBlocosDestruidos = value; }}
	public static GerenciadorDoGame Instancia { get { return instancia; } set { instancia = value; }}

	//----------------------------------------------------------------------------------//

	private void Awake ()
	{
		instancia = this;
	}

	private void Start ()
    {
        DefinirEventosClick();
        ResetaJogo ();
    }

    //----------------------------------------------------------------------------------//

    private void DefinirEventosClick ()
	{
		int faseAtualIndex = SceneManager.GetActiveScene ().buildIndex;

		if (faseAtualIndex == 0)
		{
			if (!botaoJogar || !botaoFechar) { return; }
			botaoJogar.onClick.AddListener (() => AlterarCena ("Fase"));
			botaoFechar.onClick.AddListener (() => FecharAplicativo ());
		}
		else if (faseAtualIndex == 1)
		{
			if (!botaoJogarNovamente || !botaoVoltarMenu) { return; }
			botaoJogarNovamente.onClick.AddListener (() => AlterarCena ("Fase"));
			botaoVoltarMenu.onClick.AddListener (() => AlterarCena ("MenuPrincipal"));
		}
	}

	public void AlterarCena (string cena)
	{
		SceneManager.LoadScene (cena);
	}

    public void FecharAplicativo ()
	{
		Application.Quit ();
	}

    public void FinalizarJogo ()
	{
		// Mostra tela e dados
		canvasGameOver.SetActive (true);
		imageEstrelas.fillAmount = (float) numeroBlocosDestruidos /  (float) numeroTotalBlocos;
		numeroDePontos = (numeroBlocosDestruidos * 100);
		numeroDePontosText.text = string.Concat (numeroDePontos, " ", numeroDePontosText.text);

		// Desabilita plataforma, bola e mostra as estrelas
		plataforma.enabled = false;
		Destroy (bola.gameObject);
        StartCoroutine (PiscarEstrelas ());
	}

	private void ResetaJogo ()
    {
        // Se a cena na for a tela principal, ira setar esses campos
        if (SceneManager.GetActiveScene().buildIndex > 0)
        {
            // Reseta parametros
            numeroTotalBlocos = 0;
            numeroDePontos = 0;
            numeroDePontosText.text = "PONTOS";
            canvasGameOver.SetActive (false);
        }
    }

	private IEnumerator PiscarEstrelas ()
	{
		// Enquanto a tela estiver sendo exibida
		while (canvasGameOver.activeSelf)
		{
			imageEstrelas.color = new Color (255, 255, 255, 0);
			yield return new WaitForSeconds (0.1f);
			imageEstrelas.color = new Color (255, 255, 255, 1);
			yield return new WaitForSeconds (0.1f);
		}
    }
}