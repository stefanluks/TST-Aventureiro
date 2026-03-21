using UnityEngine;
using UnityEngine.InputSystem;

public class Jogador : MonoBehaviour
{
    [Header("Variavéis")]
    [SerializeField] private int velocidade;
    
    [Header("Componentes")]
    [SerializeField] private Rigidbody2D fisica;
    [SerializeField] private Animator animador;
    private Vector2 direcao;
    private Vector2 ultimaDirecao;
    
    void Start()
    {
        fisica = GetComponent<Rigidbody2D>();
        animador = GetComponent<Animator>();
    }

    void Update()
    {
        fisica.linearVelocity = direcao * velocidade;
        animador.SetFloat("eixoX", direcao.x);
        animador.SetFloat("eixoY", direcao.y);
        animador.SetFloat("lastX", ultimaDirecao.x);
        animador.SetFloat("lastY", ultimaDirecao.y);
        animador.SetBool("correndo", direcao != Vector2.zero);

        if(direcao != Vector2.zero)
        {
            ultimaDirecao = direcao;
        }
    }

    public void Movimentar(InputAction.CallbackContext contexto)
    {
        direcao = contexto.ReadValue<Vector2>();
    }

    void OnTriggerEnter2D(Collider2D objeto)
    {
        if(objeto.gameObject.tag == "Finish")
        {
            Debug.Log("fase finalizada!");
        }
        if(objeto.gameObject.tag == "orbe")
        {
            Destroy(objeto.gameObject);
        }
    }
}
