using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float yValue = 1f;

    private void Update()
    {
        transform.Rotate(0, yValue * Time.deltaTime, 0);
    }
}
