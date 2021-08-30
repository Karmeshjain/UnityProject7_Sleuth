using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skymove : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotatespeed = 0.5f;  // i can change it later if i want to thats why i make it public we can write 0.5 also.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time*rotatespeed);
    }
}
