using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int Velocidad = 0;
    public float Tiempo = 0;
    public float TimeToDestroy = 3;

    
    void Start()
    {
        
    }



    void Update()
    {
        transform.position += transform.up * Velocidad * Time.deltaTime;

        Tiempo += Time.deltaTime;
        if(Tiempo >= TimeToDestroy)
        { 
          Destroy(gameObject);
        }
    }
}
