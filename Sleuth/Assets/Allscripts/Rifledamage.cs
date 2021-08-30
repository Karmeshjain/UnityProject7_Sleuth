using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifledamage : MonoBehaviour
{
    // Start is called before the first frame update
    public int DamageAmount = 5;
    public float TargetDistance;
    public float AllowedRange = 15.0f;
    private float nextfire = 0.0f;
    public float firerate = 1f;
    public Riflefire checkfirerifle;
    void Update()
    {
        icall();
    }
    void icall()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextfire)
        {
            nextfire = Time.time + firerate;
            raycast();
        }
    }
    void raycast()
    {
        if (Input.GetButtonDown("Fire1") && Globalammo.LoadedAmmo > 0 )
        {
            RaycastHit Shot;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
            {
                TargetDistance = Shot.distance;
                if (TargetDistance < AllowedRange)
                {
                    
                    Shot.transform.SendMessage("TakeDamage", DamageAmount, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
