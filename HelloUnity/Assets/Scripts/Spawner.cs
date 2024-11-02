using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject template; //the object to be spawned
    public float range; //radius of the spawn sphere
    public int max; //maximum numer of objects
    private float yValue;
    private Vector3 center;

    // Start is called before the first frame update
    void Start()
    {
        yValue = 12f; //couldn't figure out what I was supposed to do with Collider.Bounds 
        center = transform.position;
        spawnObjects(max);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnObjects(int num)
    {
        
        for (int i = 0; i < num; i++)
        {
            
            Vector3 objectPos = new Vector3(UnityEngine.Random.Range
                (-range + center.x,range + center.x), yValue, 
                UnityEngine.Random.Range(-range + center.z, range + center.z));

            UnityEngine.Object.Instantiate(template, objectPos, 
                Quaternion.identity, gameObject.transform);
        }
    }

    public void respawn(GameObject collected, Vector3 scale) //I had the coin script call this
    {
        collected.transform.position = new Vector3(UnityEngine.Random.Range
                    (-range + center.x, range + center.x), yValue,
                    UnityEngine.Random.Range(-range + center.z,
                    range + center.z));
        collected.transform.localScale = scale;
        collected.GetComponent<BoxCollider>().enabled = true;
        collected.SetActive(true);
        //UnityEngine.Debug.Log(collected.transform.position);

    }
}
