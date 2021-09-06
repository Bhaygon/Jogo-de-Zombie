using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala_Tiro : MonoBehaviour
{
    public float Velocidade = 20;

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.forward * Velocidade * Time.deltaTime);
    }
}
