using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfire : MonoBehaviour
{
    public GameObject Flash;
    private float nextfire = 0.0f;
    public float firerate = 0.5f;
    public IEnumerator MuzzleOff()
    {

        yield return new WaitForSeconds(0.15f);
        Flash.SetActive(false);
    }

    void Update()
    {
        fire();
    }
    void fire()
    {
        if(Input.GetButton("Fire1")&&Time.time>nextfire)
        {
            nextfire = Time.time + firerate;
            Forcefire();
        }
    }
    void Forcefire()
    {
        if (Input.GetButton("Fire1") && Globalammo.LoadedAmmo > 0)
        {
            AudioSource gunsound = GetComponent<AudioSource>();
            gunsound.Play();
            Flash.SetActive(true);
            StartCoroutine(MuzzleOff());
            GetComponent<Animation>().Play("Gunshot");
            Globalammo.LoadedAmmo -= 1;
        }

    }
}
