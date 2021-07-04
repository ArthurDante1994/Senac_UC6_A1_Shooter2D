using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedras : MonoBehaviour
{
    public HealthBar healthbar;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            healthbar.setpontos(100);
            Debug.Log("Foi acrecentado 100 pontos");
            Destroy(gameObject);
        }
    }
}
