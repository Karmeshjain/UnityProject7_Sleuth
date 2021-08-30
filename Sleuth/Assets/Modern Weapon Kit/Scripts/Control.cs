using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Control : MonoBehaviour
{
    [System.Serializable]
    public class IntUnityEvent : UnityEvent<CameraMode.Mode> { }
    public IntUnityEvent onModeChangeEvent;

    [SerializeField]
    CameraMode.Mode m_mode;
    CameraMode.Mode m_currentMode;
    public CameraMode.Mode mode
    {
        get { return m_currentMode; }
        set
        {
            if (m_currentMode == value) return;

            m_currentMode = value;
            onModeChangeEvent.Invoke(m_currentMode);
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            mode = CameraMode.Mode.main;
        if (Input.GetKey(KeyCode.Space))
            mode = CameraMode.Mode.orbit;
        if (Input.GetKey(KeyCode.Alpha1))
            mode = CameraMode.Mode.cam1;
        if (Input.GetKey(KeyCode.Alpha2))
            mode = CameraMode.Mode.cam2;
        if (Input.GetKey(KeyCode.Alpha3))
            mode = CameraMode.Mode.cam3;
        if (Input.GetKey(KeyCode.Alpha4))
            mode = CameraMode.Mode.cam4;
        if (Input.GetKey(KeyCode.Alpha5))
            mode = CameraMode.Mode.cam5;
        if (Input.GetKey(KeyCode.Alpha6))
            mode = CameraMode.Mode.cam6;
        if (Input.GetKey(KeyCode.Alpha7))
            mode = CameraMode.Mode.cam7;
        if (Input.GetKey(KeyCode.Alpha8))
            mode = CameraMode.Mode.cam8;
        if (Input.GetKey(KeyCode.Alpha9))
            mode = CameraMode.Mode.cam9;
    }

    void OnValidate()
    {
        mode = m_mode;
    }
}