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

    void Start()
    {
        pontuacao.text = pontos.ToString();
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
    void Update()
    {
        //pontuacao.text = pontos.ToString();
        if(vida <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
