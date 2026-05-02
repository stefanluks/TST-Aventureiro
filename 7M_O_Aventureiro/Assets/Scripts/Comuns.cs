using UnityEngine;

public class Comuns : MonoBehaviour
{
    public void MudarTela()
    {
        InterfaceControll.instancia.MudarTela();
    }

    public void DesativarTransicao()
    {
        gameObject.SetActive(false);
    }
}
