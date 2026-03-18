using UnityEngine;
using UnityEngine.InputSystem;

public class Jogador : MonoBehaviour
{
    [SerializeField] private int velocidade;
    [SerializeField] private Rigidbody2D fisica;
    private Vector2 direcao;
    void Start()
    {
        fisica = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        fisica.linearVelocity = direcao * velocidade;
    }

    public void Movimentar(InputAction.CallbackContext contexto)
    {
        direcao = contexto.ReadValue<Vector2>();
    }

    void OnTriggerEnter2D(Collider2D colisao)
    {
        if(colisao.gameObject.tag == "Finish")
        {
            Debug.Log("Fase concluida!!");
        }
        if(colisao.gameObject.tag == "orbe")
        {
            Destroy(colisao.gameObject);
        }
    }
}
