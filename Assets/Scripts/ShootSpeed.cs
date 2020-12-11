using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSpeed : Bullet
{
   
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
