using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TransformMovement : MonoBehaviour
{
    public float speed = -5;


    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward*speed;
    }
}
