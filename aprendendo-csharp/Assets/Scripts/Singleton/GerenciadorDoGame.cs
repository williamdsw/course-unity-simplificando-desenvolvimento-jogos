using UnityEngine;

// Classe que gerencia os pontos principais do jogo
public class GerenciadorDoGame : MonoBehaviour 
{
	//----------------------------------------------------------------------------------------//
	// FIELDS

	private int numeroMaximoDeInimigos = 10;
	private float tempoMaximoDaOnda = 20f;
	private int numeroMaximoDeOndas = 3;
	private int pontosPorOnda = 10;

	// Instancia da propria classe (singleton)
	private static GerenciadorDoGame instancia;

	//----------------------------------------------------------------------------------------//
	// PROPERTIES

	public int NumeroMaximoDeInimigos { get { return this.numeroMaximoDeInimigos; } set { this.numeroMaximoDeInimigos = value; }}
	public float TempoMaximoDaOnda { get { return this.tempoMaximoDaOnda; } set { this.tempoMaximoDaOnda = value; }}
	public int NumeroMaximoDeOndas { get { return this.numeroMaximoDeOndas; } set { this.numeroMaximoDeOndas = value; }}
	public int PontosPorOnda { get { return this.pontosPorOnda; } set { this.pontosPorOnda = value; }}
	public static GerenciadorDoGame Instancia { get { return instancia; } set { instancia = value; }}

	//----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS

	private void Awake () 
	{
		instancia = this;
	}
}