using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerPosition;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - playerPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        transform.position = playerPosition.position + offset;
    }
}
