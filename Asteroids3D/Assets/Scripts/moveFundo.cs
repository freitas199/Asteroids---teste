using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFundo : MonoBehaviour
{
    public MeshRenderer mr;
    public float velocidade;
    public float velocidadeY;
    public float stars;
    public MeshRenderer rm;
   

    void Start()
    {
        
    }

    
    void Update()
    {
        mr.material.mainTextureOffset += new Vector2(0, velocidadeY * Time.deltaTime);
        rm.material.mainTextureOffset += new Vector2(stars * Time.deltaTime, 0);
         
    }
}


 