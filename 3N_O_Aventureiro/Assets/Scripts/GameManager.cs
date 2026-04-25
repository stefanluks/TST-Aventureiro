using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia {get; private set;}
    [SerializeField] private List<Fase> fases;
    private int cenaAtual = 0;
    public int orbesColetados = 0;
    void Awake()
    {
        if(instancia != null && instancia != this) //&& -> AND || -> OR
        {
            Destroy(gameObject);
        }
        else
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void TrocarCena()
    {
        if(orbesColetados == fases[cenaAtual].qtdOrbes)
        {
            cenaAtual++;
            if(cenaAtual < fases.Count-1)
            {
                orbesColetados = 0;
                SceneManager.LoadScene(fases[cenaAtual].nome);
            }
        }
    }

    public void ColetarOrbe()
    {
        orbesColetados++;
    }
}
