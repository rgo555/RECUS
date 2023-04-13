using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
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
