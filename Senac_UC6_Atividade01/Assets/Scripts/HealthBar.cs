using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Text pontuacao;
    public Gradient gradient;
    public Image fill;
    public float vida;
    private int pontos = 0;
    private int chaves = 0;
    public GameObject primeirachave;
    public GameObject segundachave;

    void Start()
    {
        pontuacao.text = pontos.ToString();
        primeirachave.SetActive(false);
        segundachave.SetActive(false);
    }

    public void setmaxhealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);
        vida = health;
    }
    public void sethealth(int health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        vida = health;
    }
    public void setpontos(int pont)
    {
        pontos += pont;
        pontuacao.text = pontos.ToString();
    }
    public void setchaves(int chav)
    {
        chaves += chav;
        switch(chaves)
      {
          case 1:
                primeirachave.SetActive(true);
            break;
          case 2:
                segundachave.SetActive(true);
            break;
            default:
                Debug.Log("Não tem chaves o jogador");
            break;
        }
    }
    void Update()
    {
        //pontuacao.text = pontos.ToString();
        if(vida <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
