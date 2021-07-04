using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuVitoria : MonoBehaviour
{
    public void startgame()
    {
        SceneManager.LoadScene(1);
    }
    public void Menugame()
    {
        SceneManager.LoadScene(0);
    }
}
