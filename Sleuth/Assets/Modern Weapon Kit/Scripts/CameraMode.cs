using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMode : MonoBehaviour
{
    public enum Mode
    {
        orbit = -1,
        main,
        cam1,
        cam2,
        cam3,
        cam4,
        cam5,
        cam6,
        cam7,
        cam8,
        cam9,
    }

    public Mode mode = Mode.main;

    public void ChangeMode(Mode mode)
    {
        gameObject.SetActive(this.mode == mode);
    }
}