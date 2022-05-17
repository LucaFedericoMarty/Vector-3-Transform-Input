using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public Vector3 movement;
    public Vector3 rotationAmount;
    public Vector3 scaleAmount;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        cube.transform.position = movement;
        cube.transform.eulerAngles = rotationAmount;
        cube.transform.localScale = scaleAmount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
