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
