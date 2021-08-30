using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhealth : MonoBehaviour
{
    public int maxhealth = 100;
    public int currenthealth;
    public int painsound;
    public AudioSource hurt1;
    public AudioSource hurt2;
    public AudioSource hurt3;
    public Healthbarscript barreference;
     void Start()
    {
        currenthealth = maxhealth;
        barreference.MaxHealth(currenthealth);
     
    }

    // Update is called once per frame
    void Update()
    {
        if(currenthealth<=0)
        {
            //GAMEOVERSCENE

        }
        
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        int hurt = Random.Range(0, 2);
        if (hurt == 0)
            hurt1.Play();
            if (hurt == 1)
                hurt2.Play();
        if (hurt == 2)
            hurt3.Play();

        barreference.SetHealth(currenthealth);
    }
}
