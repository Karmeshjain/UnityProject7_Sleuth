
using UnityEngine;
using UnityEngine.AI;

public class EnemyAiTutorial : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    public float health;

    public Animator enemyanimator;

    public AudioSource audio;
    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;
  
    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;
    public bool playerinvision=false;

    //PATROLLSTATE 
    public Patrolling patrolling;

    //attacking
    public Playerhealth playerhealth;
    public int damageamount;
    private void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        enemyanimator = GetComponent<Animator>();
    }

    private void Update()
    {
        //Check for sight and attack range
        if (health > 0)
        {
            playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
            playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
            RaycastHit hit;
            Vector3 playerdirection = player.position - transform.position;
            if (Physics.Raycast(transform.position, playerdirection, out hit))
            {
                if (hit.transform.tag == "Player")
                {
                    playerinvision = true;

                }
                else
                {
                    playerinvision = false;
                }
            }
            if (!playerInSightRange && !playerInAttackRange)
                Patroling();
            if (playerInSightRange && !playerInAttackRange)
            {

                enemyanimator.SetBool("isshooting", false);

                enemyanimator.SetBool("isrunning", true);
                ChasePlayer();
                patrolling.enabled = false;

            }
            if (playerInAttackRange && playerInSightRange && playerinvision == true)
            {

                enemyanimator.SetBool("isrunning", false);
                enemyanimator.SetBool("isshooting", true);
                AttackPlayer();
                patrolling.enabled = false;
            }
        }
    }

    private void Patroling()
    {
        //patrolling;
        patrolling.enabled = true;
    }
   

    private void ChasePlayer()
    {
       
        agent.SetDestination(player.position);
        agent.speed = 6;
    }

    private void AttackPlayer()
    {
        //Make sure enemy doesn't move
        agent.SetDestination(transform.position);
        
        transform.LookAt(player);
        Vector3 playerdirection = player.position - transform.position;
        if (!alreadyAttacked)
        {
            ///Attack code here
            RaycastHit Shot;
            if (Physics.Raycast(transform.position, playerdirection, out Shot))
            {
                if (Shot.transform.tag == "Player")
                {
                    alreadyAttacked = true;
                    
                    Invoke(nameof(ResetAttack), timeBetweenAttacks);
                    //enemydamage
                    int prob = Random.Range(1, 10);
                   // if(prob==Random.Range(1,8))
                    playerhealth.TakeDamage(damageamount);
                    if(health>0)
                    audio.Play();
                }
                
            }
            ///End of attack code         
        }
    }
    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        playerInSightRange = true;
        playerInAttackRange = true;

        if (health <= 0)
        {
            patrolling.enabled = false;
            
            enemyanimator.SetBool("isshooting", false);
            enemyanimator.SetBool("isrunning", false);
            enemyanimator.SetBool("isdied", true);
            
            Invoke(nameof(DestroyEnemy), 4f);

        }
    }
    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
}
