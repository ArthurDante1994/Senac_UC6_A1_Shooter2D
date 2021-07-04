using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativa : MonoBehaviour
{
    public GameObject armadilha;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            armadilha.GetComponent<Esmaga>().danoplayer = true;
            Debug.Log("Esta funcionando!!!");
        }
    }
}
