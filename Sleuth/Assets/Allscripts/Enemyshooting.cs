using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemyshooting : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator enemyanimator;
    public Enemymovement checkforshooting;
  public  void Shoot()
    {

             RaycastHit Shot;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            if (Shot.transform.tag == "Player")
            {
                enemyanimator.SetBool("isshooting", true);
                
                checkforshooting.itisshooting = true;
                //enemydamage
            }
            else
            {
                checkforshooting.itisshooting = false;
               enemyanimator.SetBool("isrunning", true);
            }

        }

        
    }
}
