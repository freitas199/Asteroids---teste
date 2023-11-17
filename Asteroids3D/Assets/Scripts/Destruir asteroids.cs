using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruirasteroids : MonoBehaviour
{
    public Transform pos;
    public GameObject[] GerarObjetos;

    void Start()
    {
        int n = Random.Range(0, GerarObjetos.Length);
        Instantiate(GerarObjetos[n], pos.position, GerarObjetos[n].transform.rotation);
    }

}
