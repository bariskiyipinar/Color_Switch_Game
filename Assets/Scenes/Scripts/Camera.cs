using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Ball;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Ball.position.y > transform.position.y)
        {
            transform.position=new Vector3(transform.position.x,Ball.position.y,transform.position.z);
        }
       
    }

}
