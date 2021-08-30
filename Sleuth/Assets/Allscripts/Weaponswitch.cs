using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Weaponswitch : MonoBehaviour
{
    // Start is called before the first frame update
    public int selectedweapon = 0;
    public GameObject obj2;
    void Start()
    {
        Selectweapon();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        int previousweaponslect = selectedweapon;
        if(Input.GetKeyDown(KeyCode.X))  //we scroll up >0;
        {
            if (selectedweapon >= transform.childCount - 1)
                selectedweapon = 0;
            else
            selectedweapon++;
        }
        if ( Input.GetKeyDown(KeyCode.Z))  //we scroll up >0;
        {
            if (selectedweapon <= transform.childCount - 1)
                selectedweapon = transform.childCount - 1;
            else
                selectedweapon-- ;
        }
        if (previousweaponslect != selectedweapon)
            Selectweapon();
    }
    void Selectweapon()
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if (i == selectedweapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
       if(selectedweapon==0)
            obj2.GetComponent<Text>().text = "" + 5.56f+"mm";
       else if(selectedweapon==1)
            obj2.GetComponent<Text>().text = "" + 7.62f + "mm";

    }
}
