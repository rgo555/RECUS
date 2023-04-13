using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;

    void Update()
    {
        //transform.position += transform.forward * 1 * Time.deltaTime;

        Vector3 velocity = GetComponent<Rigidbody>().velocity;
            velocity.z = speed;
            GetComponent<Rigidbody>().velocity = velocity;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;
    }

    void OnCollisionEnter(Collision other) 
    {
        this.gameObject.SetActive(false);    
    }

    /*void OnBecameInvisible()
    {
        enabled = false;
    }*/
}
