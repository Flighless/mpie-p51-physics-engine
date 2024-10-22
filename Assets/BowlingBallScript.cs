using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class BowlingBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float balls = -20.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space"))
        {
            Rigidbody ball = GetComponent<Rigidbody> (); 
            ball.AddForce(new Vector3(0.0f, 0.0f, balls));
        }
        if(Input.GetKey("a"))
        {
            Transform bowl = gameObject.transform;
            bowl.Translate(new Vector3(0.001f, 0.0f, 0.0f));
        }
        if(Input.GetKey("d"))
        {
            Transform bowl = gameObject.transform;
            bowl.Translate(new Vector3(-0.001f, 0.0f, 0.0f));
        }
        if(Input.GetKey("w"))
        {
            if (balls >-60) 
            {
                balls--;
            }
        }
        if(Input.GetKey("s"))
        {
            if (balls <0) 
            {
                balls++;
            }
        }
        if(Input.GetKey("q"))
        {
            
        }
        if(Input.GetKey("e"))
        {
            
        }

    }
}
