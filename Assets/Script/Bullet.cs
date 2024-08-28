using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private float moveSpeed;

    void Start()
    {
        moveSpeed = 10f;
        rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = Vector3.forward * moveSpeed;
    }    
}
