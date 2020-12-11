using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    public GameObject bullet;
    public GameObject speedbullet;
    public GameObject superBullet;
    [SerializeField]Transform bulletPos;
    void Start()
    {
        
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           Instantiate(bullet, bulletPos.transform);
        }

        if(Input.GetKey(KeyCode.Z))
        { 
           Instantiate(speedbullet, bulletPos.transform);
        }

        if(Input.GetKeyUp(KeyCode.X))
        { 
           Instantiate(superBullet, bulletPos.transform);
        }
    }
}
