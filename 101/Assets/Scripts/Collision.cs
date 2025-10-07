using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    [SerializeField] private GameObject droppingObject;
    Rigidbody rb;

    private void Start()
    {
        rb = droppingObject.GetComponent<Rigidbody>();
        rb.useGravity = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            rb.useGravity=true;
        }
    }
}
