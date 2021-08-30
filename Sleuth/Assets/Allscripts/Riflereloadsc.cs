using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riflereloadsc : MonoBehaviour
{
    public AudioSource ReloadSound;
   // public GameObject CrossObject;
    public GameObject MechanicsObject;
    public int ClipCount;
    public int ReserveCount;
    public int ReloadAvailable;
    public Gunfire GunComponent;

    void Start()
    {
        GunComponent = GetComponent<Gunfire>();
    }

    void Update()
    {
        ClipCount = Globalammo.LoadedAmmo;
        ReserveCount = Globalammo.CurrentAmmo;

        if (ReserveCount == 0)
        {
            ReloadAvailable = 0;
        }
        else
        {
            ReloadAvailable = 30 - ClipCount;
        }

        if (Input.GetButtonDown("Reload"))
        {
            if (ReloadAvailable >= 1)
            {
                if (ReserveCount <= ReloadAvailable)
                {
                    Globalammo.LoadedAmmo += ReserveCount;
                    Globalammo.CurrentAmmo -= ReserveCount;
                    ActionReload();
                }
                else
                {
                    Globalammo.LoadedAmmo += ReloadAvailable;
                    Globalammo.CurrentAmmo -= ReloadAvailable;
                    ActionReload();
                }
            }
            StartCoroutine(EnableScripts());

        }
    }

    public IEnumerator EnableScripts()
    {
       yield return new WaitForSeconds(1.1f);
        GetComponent<Gunfire>().enabled = true;
     //   CrossObject.SetActive(true);
        MechanicsObject.SetActive(true);
    } 

    void ActionReload()
    {
        GetComponent<Gunfire>().enabled = false;
      //  CrossObject.SetActive(false);
        MechanicsObject.SetActive(false);
        ReloadSound.Play();
        GetComponent<Animation>().Play("Riflereload");
    }
}
