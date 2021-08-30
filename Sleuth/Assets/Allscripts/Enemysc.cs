using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemysc : MonoBehaviour
{
    // Start is called before the first frame update
    public int EnemyHealth = 10;
    Animator enemyanimator;
    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }
    private void Start()
    {
        enemyanimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (EnemyHealth <= 0)
        {
            enemyanimator.SetBool("isdied", true);
        }
    }
}
