using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riflefire : MonoBehaviour
{
    public int DamageAmount = 5;
    public float TargetDistance;
    public float AllowedRange = 15.0f;
    public bool firedone = false;
   
    public IEnumerator MuzzleOff()
    {

        yield return new WaitForSeconds(2f);
        firedone = false;
       
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")&&firedone==false&&Globalammo.LoadedAmmosni>0)
        {
            firedone = true;
            AudioSource gunsound = GetComponent<AudioSource>();
            gunsound.Play();
           GetComponent<Animation>().Play("Snipershot");
           /* RaycastHit Shot;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
            {
                TargetDistance = Shot.distance;
                if (TargetDistance < AllowedRange)
                {
                    Shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
                }
            }*/
            StartCoroutine(MuzzleOff());
            
             Globalammo.LoadedAmmosni -= 1;
        }
    }
  
}
