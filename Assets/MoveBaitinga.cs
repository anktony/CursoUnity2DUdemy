using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBaitinga : MonoBehaviour
{
   
       void Start()
    {
       
        
    }

   
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(H * Time.deltaTime, V * Time.deltaTime, 0)*20);


    }
}
