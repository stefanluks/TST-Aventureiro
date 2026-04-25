using UnityEngine;
using UnityEngine.UI;

public class InterfaceControll : MonoBehaviour
{
    [SerializeField] private Text titulo;
    private int cont = 0;
    private bool escondido = false;

    void Update(){
        titulo.text = "Cliques: "+cont;
    }

    public void Clicando(){
        cont++;
    }

    public void Escondendo(){
        titulo.gameObject.SetActive(escondido);
        escondido = !escondido;
    }
}
