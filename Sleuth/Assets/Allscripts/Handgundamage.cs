using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handgundamage : MonoBehaviour
{
    // Start is called before the first frame update
    public int DamageAmount = 5;
    public float TargetDistance;
    public float AllowedRange = 15.0f;
    private float nextfire = 0.0f;
    public float firerate = 0.2f;
    public Camera playercamera;
    public GameObject blood;
   // public GameObject impact;
    void Update()
    {
        icall();   
    }
    void icall()
    {
        if (Input.GetButton("Fire1") && Time.time > nextfire)
        {
            nextfire = Time.time + firerate;
            raycast();
        }
    }
    void raycast()
    {
        if (Input.GetButton("Fire1") && Globalammo.LoadedAmmo > 0)
        {
            RaycastHit Shot;
            if (Physics.Raycast(playercamera.transform.position, playercamera.transform.forward, out Shot))
            {
                TargetDistance = Shot.distance;
               
                if (TargetDistance < AllowedRange)
                {
                    Shot.transform.SendMessage("TakeDamage", DamageAmount, SendMessageOptions.DontRequireReceiver);  
                    if(Shot.transform.tag=="Enemy")
                    {
                        Instantiate(blood, Shot.point, Quaternion.LookRotation(Shot.normal));
                    }
                }
               // Instantiate(impact, Shot.point, Quaternion.LookRotation(Shot.normal));//enemy damage;
            }
        }
    }
}
