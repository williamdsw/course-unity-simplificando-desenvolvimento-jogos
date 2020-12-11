using UnityEngine;

public class Bola : MonoBehaviour
{
	// Configuracao
	[SerializeField] private GameObject particulasBloco;
	[SerializeField] private GameObject particulasFolha;
	[SerializeField] private LineRenderer guia;
	private int PontosGuia = 3;

	// Estado
	private Vector3 direcao = new Vector3 (1, 1, 0);
	private float velocidade = 10f;	

	// Cache

	//----------------------------------------------------------------------------------//

	private void Start () 
	{
		// Parametros iniciais
		direcao.Normalize ();
		guia.positionCount = PontosGuia;
	}

	private void Update ()
    {
        AtualizaPosicaoRotacao ();
        AtualizarLineRenderer ();
    }

    private void OnCollisionEnter2D (Collision2D collider)
	{
		int contadorDeHits = 0;
		bool colisaoInvalida = false;

		// Pontos de contado do colisor e instancias
		Transform colisor = collider.transform;
		Vector2 normal = collider.contacts[0].normal;
		Plataforma plataforma = colisor.GetComponent<Plataforma> ();
		GeradorDeArestas geradorDeArestas = colisor.GetComponent<GeradorDeArestas> ();

		if (plataforma != null) 
		{
			// Se a normal do vetor for diferente de Vector2.up dara game over.. (os pontos invalidos)
			if (normal != Vector2.up) 
			{
				colisaoInvalida = true;
			}
			else 
			{
				// Bordas do colisor
				SpriteRenderer colisorSpriteRenderer = colisor.GetComponent<SpriteRenderer>();
				Bounds bordasColisor = colisorSpriteRenderer.bounds;

				// Particulas e configuracoes
				GameObject particulas = (GameObject) Instantiate (particulasFolha, colisor.position, Quaternion.identity);
				ParticleSystem componenteParticulas = particulas.GetComponent<ParticleSystem> ();
				Destroy (particulas, componenteParticulas.main.duration + componenteParticulas.main.startLifetime.constant);
			}
		} 
		else if (geradorDeArestas != null) 
		{
			// Aresta de baixo
			colisaoInvalida = (normal == Vector2.up);
		} 
		else
		{
			// So vai cair nesse else se colidir com o Bloco (valida)
			colisaoInvalida = false;

			//Pega as bordas do colisor
			Bounds bordasColisor = colisor.GetComponent<SpriteRenderer> ().bounds;

			// Posicao, instancia e sistema das particulas
			Vector3 posicaoDeCriacao = new Vector3 (colisor.position.x + bordasColisor.extents.x, colisor.position.y - bordasColisor.extents.y, -1);
			GameObject particulas = (GameObject) Instantiate (particulasBloco, posicaoDeCriacao, Quaternion.identity);
			ParticleSystem componenteParticulas = particulas.GetComponent<ParticleSystem> ();
			Destroy (particulas, componenteParticulas.main.duration + componenteParticulas.main.startLifetime.constant);
			Destroy (colisor.gameObject);		
			
			GerenciadorDoGame.NumeroBlocosDestruidos++;
		}

		if (!colisaoInvalida)
		{
			if (velocidade < 15)
			{
				contadorDeHits += 1;
				velocidade += 1;
			}

			// Reflete e normaliza a direcao
			direcao = Vector2.Reflect (direcao, normal);
			direcao.Normalize ();
		}
		else
		{
			GerenciadorDoGame.Instancia.FinalizarJogo ();
		}
	}

	//----------------------------------------------------------------------------------//

	private void AtualizaPosicaoRotacao ()
    {
        // Incrementa o valor da posicao do objeto
        transform.position += (direcao * velocidade * Time.deltaTime);

        /* Irei atrualizar a rotacao do objeto. 
		 * E necessario utilizar a classe "Quaternion" com o metodo "Euler()"
		 * "Quarternion" = Utilizado para representar rotacoes */
        Vector3 anguloRotacao = transform.rotation.eulerAngles;
        anguloRotacao.z += 20f;
        transform.rotation = Quaternion.Euler (anguloRotacao);
    }

    private void AtualizarLineRenderer()
	{
		// Configuracao de ponto e posicoes da linha
		int pontoAtual = 1;
		Vector3 direcaoAtual = direcao;
		Vector3 ultimaPosicao = transform.position;
		guia.SetPosition (0, ultimaPosicao);

		while (pontoAtual < PontosGuia) 
		{
			/* Definir qual sera o proximo ponto :
			 * Raycast() = Vai criar um raio que sai da origem que vai a uma direcao
			 * Usamos RaycastHit2D porque estamos lançando raios contra blocos 2d */
			RaycastHit2D hit = Physics2D.Raycast (ultimaPosicao, direcaoAtual);

			// Atualiza posicao
			ultimaPosicao = hit.point;
			guia.SetPosition (pontoAtual, ultimaPosicao);

			// Atualiza direcao
            direcaoAtual = Vector3.Reflect (direcaoAtual, hit.normal);
            ultimaPosicao += direcaoAtual * 0.05f;
			pontoAtual++;
		}
    }
}