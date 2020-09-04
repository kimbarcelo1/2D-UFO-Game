using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //public Vector3 rotation;
    public float zAxis;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f, zAxis) * Time.deltaTime); //multiplied by time deltatime to be smooth and frame rate independent
    }
}
