using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riflezoom : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Playercam;
    public SimpleCrosshair Obj;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Playercam.GetComponent<Camera>().fieldOfView = 45;
            Obj.SetSize(20, true);
            Obj.SetGap(5, true);
            Obj.SetThickness(1, true);
        }
        if (Input.GetMouseButtonUp(1))
        {
            Playercam.GetComponent<Camera>().fieldOfView = 60;
            Obj.SetSize(14, true);
            Obj.SetGap(27, true);
            Obj.SetThickness(3, true);
        }
    }
}
