using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float velocidadeNave;
    public float velocidadeDireita;
    public float velocidadeEsquerda;
    public Vector3 Direcao;
   

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 1)* Time.deltaTime * velocidadeNave); // subida da nave
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * velocidadeNave); // descida da nave
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * velocidadeNave); // movimenta para a esquerda
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * velocidadeNave); // movimenta para direita
       
        }
        if (Input.GetKey(KeyCode.B))
        {
            transform.Rotate((Direcao * velocidadeDireita) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(new Vector3(0,-15,0) * velocidadeEsquerda* Time.deltaTime);
        }

    }






}
