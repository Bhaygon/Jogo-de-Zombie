using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaInimigo : MonoBehaviour
{
    public GameObject Player;
    public float Velocidade = 5;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float distancia = Vector3.Distance(transform.position, Player.transform.position);

        Vector3 direcao = Player.transform.position - transform.position;

        Quaternion novaRotacao = Quaternion.LookRotation(direcao);
        GetComponent<Rigidbody>().MoveRotation(novaRotacao);

        if (distancia > 2.5)
        {
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + direcao.normalized * Velocidade * Time.deltaTime);

            GetComponent<Animator>().SetBool("Atacando", false);

        } else
        {
            GetComponent<Animator>().SetBool("Atacando", true);
        }
    }

    void AtacaJogador()
    {
        Time.timeScale = 0;
    }
}
