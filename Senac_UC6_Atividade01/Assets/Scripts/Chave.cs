using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chave : MonoBehaviour
{
    public GameObject gate;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gate.GetComponent<Gateway>().NewChaves(1);
            Destroy(gameObject);
        }
    }

}
