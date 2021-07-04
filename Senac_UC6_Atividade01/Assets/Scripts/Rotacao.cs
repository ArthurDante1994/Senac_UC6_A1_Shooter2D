using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public bool escolha = false;
    
    // Update is called once per frame
    void Update()
    {
        if (escolha)
        {
            transform.Rotate(new Vector3(0, 0, bulletSpeed * Time.deltaTime));
        }
        else
        {
            transform.Rotate(new Vector3(0, -bulletSpeed * Time.deltaTime, 0));
        }
    }
}
