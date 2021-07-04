using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject menuprincipal;
    public GameObject menuecredits;
    // Start is called before the first frame update
    void Start()
    {
        menuecredits.SetActive(false);
        menuprincipal.SetActive(true);
    }
    // executando o game nesta função
    public void startgame()
    {
        SceneManager.LoadScene(1);
    }
    public void Menugame()
    {
        SceneManager.LoadScene(0);
    }
    // Mostando o menu de creditos do Game
    public void Credistsgame()
    {
        menuecredits.SetActive(true);
        menuprincipal.SetActive(false);
    }
    public void Retornagame()
    {
        menuecredits.SetActive(false);
        menuprincipal.SetActive(true);
    }
    // Função para sair do Game
    public void exitsgame()
    {
        Application.Quit();
    }
}
