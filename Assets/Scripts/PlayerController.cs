using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int velocidad = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        { 
           transform.position += transform.up * velocidad * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.RightArrow))
        { 
           transform.position += transform.right * velocidad * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.DownArrow))
        { 
           transform.position -= transform.up * velocidad * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        { 
           transform.position -= transform.right * velocidad * Time.deltaTime;
        }
    }
}
