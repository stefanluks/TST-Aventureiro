using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceControll : MonoBehaviour
{
    public static InterfaceControll instancia {get; private set; }
    [Header("MENU DA INTERFACE")]
    [SerializeField] private GameObject menuPrincipal;
    [SerializeField] private GameObject menuOpcoes;
    [SerializeField] private GameObject hud;
    [SerializeField] private GameObject transicao;

    void Awake()
    {
        if(instancia != null && instancia != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private int id_tela_atual = 0;

    public void Jogar()
    {
        SceneManager.LoadScene("Principal");
        TrocarTela(2);
    }

    public void Opcoes()
    {
        TrocarTela(1);
    }

    void TrocarTela(int id_tela)
    {
        transicao.SetActive(true);
        id_tela_atual = id_tela;
    }

    public void MudarTela()
    {
        if(id_tela_atual == 1)
        {
            menuOpcoes.SetActive(!menuOpcoes.activeSelf);
        }
        else
        {
            menuPrincipal.SetActive(false);
            hud.SetActive(true);
        }
    }


    public void Sair()
    {
        Debug.Log("Jogo Encerrado!");
    }

}
