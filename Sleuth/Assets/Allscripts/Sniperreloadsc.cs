using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniperreloadsc : MonoBehaviour
{
    public AudioSource ReloadSound;
    // public GameObject CrossObject;
    public GameObject MechanicsObject;
    public int ClipCount;
    public int ReserveCount;
    public int ReloadAvailable;
    public Riflefire GunComponent;
    // Update is called once per frame
    void Update()
    {
        ClipCount = Globalammo.LoadedAmmosni;
        ReserveCount = Globalammo.CurrentAmmosni;

        if (ReserveCount == 0)
        {
            ReloadAvailable = 0;
        }
        else
        {
            ReloadAvailable = 5 - ClipCount;
        }
        if (Input.GetButtonDown("Reload"))
        {
            if (ReloadAvailable >= 1)
            {
                if (ReserveCount <= ReloadAvailable)
                {
                    Globalammo.LoadedAmmosni += ReserveCount;
                    Globalammo.CurrentAmmosni -= ReserveCount;
                   ActionReload();
                }
                else
                {
                    Globalammo.LoadedAmmosni += ReloadAvailable;
                    Globalammo.CurrentAmmosni -= ReloadAvailable;
                    ActionReload();
                }
            }
           

        }
        void ActionReload()
        {
            ReloadSound.Play();
            GetComponent<Animation>().Play("Sniperreload");
        }
    }
}
