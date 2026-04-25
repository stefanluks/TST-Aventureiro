using UnityEngine;
using UnityEngine.UI;

public class InterfaceControll : MonoBehaviour
{
    [SerializeField] private Text titulo;
    private int cont = 0;
    private bool escondido = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        titulo.text = "cliques: "+cont;
    }

    public void Clique()
    {
        cont++;
    }

    public void Esconder()
    {
        titulo.gameObject.SetActive(escondido);
        escondido = !escondido;
    }
}
