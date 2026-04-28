using UnityEngine;
using UnityEngine.UI;

public class InterfaceControl : MonoBehaviour
{
    [SerializeField] private Text titulo;
    private int contador = 0;
    private bool ativo = true;
    void Update()
    {
        titulo.text = "Cliques: "+contador;
    }
    public void Clique()
    {
        contador++;
    }
    public void Esconder()
    {
        ativo = !ativo;
        titulo.gameObject.SetActive(ativo);
    }
}
