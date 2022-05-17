using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovment : MonoBehaviour
{
    public Vector3 cubeMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += cubeMovement;
    }
}
