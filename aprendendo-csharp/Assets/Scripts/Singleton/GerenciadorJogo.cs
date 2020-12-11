using UnityEngine;

public class GerenciadorJogo : MonoBehaviour 
{
	//----------------------------------------------------------------------------------------//
	// FIELDS

	private int maximoHP = 100;
	private int maximoMP = 100;
	private int maximoEXP = 100000;
	private float tempoMaximo = 20f;
	private static GerenciadorJogo instancia;

	//----------------------------------------------------------------------------------------//
	// PROPERTIES

	public int MaximoHP { get { return this.maximoHP; } set { this.maximoHP = value; }}
	public int MaximoMP { get { return this.maximoMP; } set { this.maximoMP = value; }}
	public int MaximoEXP { get { return this.maximoEXP; } set { this.maximoEXP = value; }}
	public float TempoMaximo { get { return this.tempoMaximo; } set { this.tempoMaximo = value; }}
	public static GerenciadorJogo Instancia { get { return instancia; } set { instancia = value; }}

	//----------------------------------------------------------------------------------------//
	// MONOBEHAVIOUR FUNCTIONS

	private void Awake ()
	{
		instancia = this;
	}
}