using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{

    public float floorSpeed = -0.01f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + new Vector3(floorSpeed, 0, 0);
    }
}
