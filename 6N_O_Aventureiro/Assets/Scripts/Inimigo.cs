using UnityEngine;

public class Inimigo : MonoBehaviour
{
    [SerializeField] private int velocidade;
    private GameObject jogador;
    private int modos = 0; //0 -> patrulha | 1 -> Perseguição
    void Start()
    {
        jogador = GameObject.Find("Jogador");
    }

    void Update()
    {
        if(modos == 0) Patrulha();
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

    void OnTriggerEnter2D(Collider2D objeto)
    {
        if(objeto.gameObject.tag == "Player")
        {
            modos = 1;
        }
    }

    void OnTriggerExit2D(Collider2D objeto)
    {
        if(objeto.gameObject.tag == "Player")
        {
            modos = 0;
        }
    }
}
