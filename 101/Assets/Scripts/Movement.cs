using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveForce = 10f;
    float maxSpeed;
    float jumpForce;

    Rigidbody rb;

    private void Awake()
    {
        
    }

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void Update()
    {
        transform.Translate(1f * Time.deltaTime, 0f, 0f);
    }

    private void LateUpdate()
    {
        
    }
}
