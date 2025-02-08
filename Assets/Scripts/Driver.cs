using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    private void Start()
    {

    }

    private void Update()
    {
        transform.Rotate(0, 0, 0.1f);
    }
}