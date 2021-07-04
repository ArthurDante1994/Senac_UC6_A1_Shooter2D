using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esmaga : Armadilha
{
    private Animator anim;
    public GameObject parede;
    public bool danoplayer = false;
    public float newtemp = 1f;
    public float tempdano = 0.15f;
    public bool ativado = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = parede.GetComponent<Animator>();
    }
    // Update is called once per frame
    public IEnumerator animacao(Collider objeto)
    {
        if (!ativado)
        {
            ativado = true;
            anim.SetBool("Ativa", true);
            yield return new WaitForSeconds(tempdano);
            StartCoroutine(Damenge(objeto));
            yield return new WaitForSeconds(newtemp);
            anim.SetBool("Ativa", false);
            yield return new WaitForSeconds(newtemp);
            danoplayer = false;
            ativado = false;
        }
    }
    private void OnTriggerStay(Collider collider)
    {
        if(collider.gameObject.CompareTag("Player") && danoplayer)
        {
            StartCoroutine(animacao(collider));
        }
    }
}
