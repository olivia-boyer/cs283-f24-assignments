using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour { 
    public float moveSpeed;
    public float rotationSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, moveSpeed/10);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -moveSpeed/10);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed/10,0 );
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed/10, 0);
        }
    }
}
