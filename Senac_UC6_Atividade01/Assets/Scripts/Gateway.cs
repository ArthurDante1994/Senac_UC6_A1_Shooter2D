using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gateway : MonoBehaviour
{
    public int chavesMax;
    public GameObject portao;
    public int chaves = 0;
    private Animator anim;
    private float tempdano = 0.15f;
    // Start is called before the first frame update
    void Start()
    {
        anim = portao.GetComponent<Animator>();
    }

    public void NewChaves(int ch)
    {
        chaves += ch;
    }
    IEnumerator animacao()
    {
        anim.SetBool("Ative", true);
        yield return new WaitForSeconds(tempdano);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && chavesMax == chaves)
        {
            StartCoroutine(animacao());
            Debug.Log("Esta abrindo a porta!!");
        }   
    }
}
