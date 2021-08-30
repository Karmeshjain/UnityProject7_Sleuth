using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float RotationSpeed = 10000f;
    void Update()
    {
        transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
    }
}
