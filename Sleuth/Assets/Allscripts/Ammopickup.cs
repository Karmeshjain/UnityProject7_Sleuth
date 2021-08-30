using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammopickup : MonoBehaviour
{
    public AudioSource AmmoPickupSound;
    void OnTriggerEnter(Collider other)
    {
        AmmoPickupSound.Play();
        if (Globalammo.LoadedAmmo == 0)
            Globalammo.LoadedAmmo += 30;
        else
        Globalammo.CurrentAmmo += 30;
        this.gameObject.SetActive(false);
    }
}
