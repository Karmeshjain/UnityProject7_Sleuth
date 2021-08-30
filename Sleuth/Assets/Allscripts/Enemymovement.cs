using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemymovement : MonoBehaviour
{
    public float fov = 120f;

    public Transform Target;

    public bool inSight;

    public float awakedistance=80f;
    // Update is called once per frame
    public bool AwareofPlayer = false;
    public bool playerinvision = false;
    public NavMeshAgent enemyagent;
   
    public float shootdistance;
    public Patrolling patrolofsc;
    Animator enemyanimator;

    public GameObject forshoot;
    public bool itisshooting=false;
    private void Start()
    {
        enemyanimator = GetComponent<Animator>();
      
    }
    void Update()
    {
        drawray();
        float PlayerDistance = Vector3.Distance(Target.position, transform.position);
        Vector3 playerdirection = Target.position - transform.position ;
        float playerAngle = Vector3.Angle(transform.position, playerdirection);
        if(playerAngle<=fov/2)
        {
            inSight = true;
        //    Debug.Log("Playerinsight");
        }
        else
        {
            inSight = false;
        }
        if (inSight == true && PlayerDistance <= awakedistance&&playerinvision==true)
            AwareofPlayer = true;

        if(PlayerDistance<=shootdistance)
        {
           
            forshoot.GetComponent<Enemyshooting>().Shoot();
          
        }
        if (AwareofPlayer == true&&itisshooting==false)
        {
            enemyagent.SetDestination(Target.position);
            enemyanimator.SetBool("isrunning", true);
            enemyagent.speed = 6f;
            patrolofsc.enabled = false;
        }

        
            
    }
    void drawray()
    {
        Vector3 playerdirection = Target.position - transform.position;
        RaycastHit hit;
        if(Physics.Raycast(transform.position,playerdirection,out hit))
        {
            if(hit.transform.tag=="Player")
            {
                playerinvision = true;
                            
            }
            else
            {
                playerinvision = false;
            }
        }
    }
    
}
