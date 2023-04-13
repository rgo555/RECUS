using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    [SerializeField] float dirX;

    Rigidbody _rBody;

    public GameObject bulletPrefab;
    public Transform gunPosition;
    public int ammo = 0;

    void Awake()
    {
        _rBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");

        if(Input.GetButtonDown("Jump"))
        {
            GameObject bullet = PoolManager.Instance.GetPooledObjects(ammo, gunPosition.position, gunPosition.rotation);
            bullet.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        _rBody.velocity = new Vector3(dirX * speed, _rBody.velocity.y, _rBody.velocity.z);
    }
}
