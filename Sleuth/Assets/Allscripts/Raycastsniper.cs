using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycastsniper : MonoBehaviour
{
    public int DamageAmount = 30;
    public float TargetDistance;
    public float AllowedRange = 15.0f;
    public bool firedone = false;
    public Camera playercamera;
    public GameObject blood;
    public IEnumerator MuzzleOff()
    {

        yield return new WaitForSeconds(2f);
        firedone = false;

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && firedone == false && Globalammo.LoadedAmmosni > 0)
        {
            firedone = true;
           // AudioSource gunsound = GetComponent<AudioSource>();
           // gunsound.Play();
           // GetComponent<Animation>().Play("Snipershot");
            RaycastHit Shot;
            if (Physics.Raycast(playercamera.transform.position, playercamera.transform.forward, out Shot))
            {
                TargetDistance = Shot.distance;
                if (TargetDistance < AllowedRange)
                {
                    Shot.transform.SendMessage("TakeDamage", DamageAmount, SendMessageOptions.DontRequireReceiver);
                    if(Shot.transform.tag=="Enemy")
                    Instantiate(blood, Shot.point, Quaternion.LookRotation(Shot.normal));
                    //  Shot.transform.SendMessage("TakeDamage", DamageAmount, SendMessageOptions.DontRequireReceiver);
                }
            }
            StartCoroutine(MuzzleOff());

            //Globalammo.LoadedAmmosni -= 1;
        }
    }

}
