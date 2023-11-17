using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Transform PontoDoLaser;
    public GameObject LaserPrefab;
    public float VelocidadeLaser = 10.0f;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var laser = Instantiate(LaserPrefab, PontoDoLaser.position, PontoDoLaser.rotation);
            laser.GetComponent<Rigidbody2D>().velocity = PontoDoLaser.up * VelocidadeLaser;
        }
        
    }
     



}
