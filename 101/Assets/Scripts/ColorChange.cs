using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
  void OnCollisionEnter(UnityEngine.Collision collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      Debug.Log("Color Changed");
      GetComponent<Renderer>().material.color = Color.red;
    }
  }
}
