using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Globalammo : MonoBehaviour
{
    // Start is called before the first frame update
    public static int CurrentAmmo=180;
    public int InternalAmmo;
    public GameObject AmmoDisplay;

    public static int LoadedAmmo=30;
    public int InternalLoaded;
    public GameObject LoadedDisplay;
    public Weaponswitch objectforws;

    public static int CurrentAmmosni = 10;
    public int InternalAmmosni;


    public static int LoadedAmmosni = 5;
    public int InternalLoadedsni;
  
    void Update()
    {
        if (objectforws.selectedweapon == 0)
        {
            InternalAmmo = CurrentAmmo;
            InternalLoaded = LoadedAmmo;
            AmmoDisplay.GetComponent<Text>().text = "" + InternalAmmo;
            LoadedDisplay.GetComponent<Text>().text = "" + LoadedAmmo;
        }

        if(objectforws.selectedweapon==1)
        {
            InternalAmmosni = CurrentAmmosni;
            InternalLoadedsni = LoadedAmmosni;
            AmmoDisplay.GetComponent<Text>().text = "" + InternalAmmosni;
            LoadedDisplay.GetComponent<Text>().text = "" + LoadedAmmosni;
        }

    }
}
