using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;




public class Patrolling : MonoBehaviour
{
    [SerializeField]
    bool patrolwaiting;

    [SerializeField]
    float totalwaittime = 0f;


    [SerializeField]
    float switchprobablity=0.3f;

    [SerializeField]
    List<Waypoint> patrolPoints; 

    NavMeshAgent navmeshagent;
    int currentpatrolindex;
    bool travelling;
    bool waiting;
    bool patrolforward;
    float waittimer;

    public void Start()
    {
        navmeshagent = this.GetComponent<NavMeshAgent>();
        currentpatrolindex = 0;
        SetDestination();
       

    }
    public void Update()
    {

        if(travelling && navmeshagent.remainingDistance<=1f)
        {
            travelling = false;
            if(patrolwaiting)
            {
                waiting = true;
                waittimer = 0f;
            }
            else
            {
                ChangePatrolpoints(); 
                SetDestination();
            }
        }
        if(waiting)
        {
            waittimer += Time.deltaTime;
            if(waittimer>=totalwaittime)
            {
                waiting = false; 
                ChangePatrolpoints();
                SetDestination();
            }
        }
    }
    public void SetDestination()
    {
        if(patrolPoints!=null)
        {
            Vector3 targetvector = patrolPoints[currentpatrolindex].transform.position;
            navmeshagent.SetDestination(targetvector);
            travelling = true;
        }
    }
    public void ChangePatrolpoints()
    {
        if(UnityEngine.Random.Range(0f,1f)<=switchprobablity)
        {
            patrolforward = !patrolforward;
        }
        if(patrolforward)
        {
            currentpatrolindex = (currentpatrolindex + 1) % patrolPoints.Count;

            //here i can use we are doing currentpetrolindex++ 
            //or if(currentpatrolindex>=patrolpoints.count) 
            //then currentpatrolindex=0;
           
        }
        else
        {

            /*here what we are doing currentpatrolindex--;
             * if(curreentpatrolindex<0) then currentpatrolindex=patrolpoints.count-1;
             * 
                     */
            if(--currentpatrolindex<0)
            {
                currentpatrolindex = patrolPoints.Count - 1;
            }
        }
        
    }

}
