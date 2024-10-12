using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform start; //temporarily between 2 points
    public Transform end;
    public bool Castel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CubicBezier() //basic poly version
    {
        bzero = start.position;
        bthree = end.position;
        for (float timer = 0; timer < duration; timer += Time.deltaTime)
        {

        }
        
    }
}
