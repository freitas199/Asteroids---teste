using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroids : MonoBehaviour
{
    public Rigidbody2D rb;

    public float velocidadeMovimento = 50.0f;

    public float velocidaderotacao = 200.0f;

    public float direcaorotation;
    float rotation;
    Vector2 direcao;


    void Start()
    {
        direcaorotation = Random.value > 1f ? 0f : 0f;
        direcao = (Vector3.zero - transform.position).normalized;
    }
   
    
    void Update()
    {
         rotation += direcaorotation * Time.smoothDeltaTime * velocidaderotacao;
    }
}
