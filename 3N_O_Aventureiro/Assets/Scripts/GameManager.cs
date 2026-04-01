using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia {get; private set;}
    [SerializeField] private List<string> fases;
    private int cenaAtual = 0;
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
        cenaAtual++;
        if(cenaAtual < fases.Count)
        {
            SceneManager.LoadScene(fases[cenaAtual]);
        }
    }
}
