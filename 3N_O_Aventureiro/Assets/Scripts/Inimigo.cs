using UnityEngine;

public class Inimigo : MonoBehaviour
{
    [SerializeField] private int velocidade;
    private GameObject jogador;
    private int modo = 0; // 0 -> Patrulha | 1 -> Perseguição
    void Start()
    {
        jogador = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if(modo == 0) Patrulha();
        else Perseguicao();
    }

    void Patrulha()
    {
        Debug.Log("Modo Patrulha");
    }

    void Perseguicao()
    {
        transform.position = Vector2.MoveTowards(transform.position, jogador.transform.position, velocidade * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "Player")
        {
            modo = 1;
        }
    }

    void OnTriggerExit2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "Player")
        {
            modo = 0;
        }
    }
}
