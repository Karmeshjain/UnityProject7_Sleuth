using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerwalkrunidlecontroller : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator playeranim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playeranim.SetBool("issprint", true);
            playeranim.SetBool("iswalk", false);
            playeranim.SetBool("isidle", false);
        }
        else if(x==0f&&y==0f)
        {
            playeranim.SetBool("isidle", true);
            playeranim.SetBool("issprint", false);
            playeranim.SetBool("iswalk", false);
        }
        else
        {
            playeranim.SetBool("issprint", false);
            playeranim.SetBool("iswalk", true);
            playeranim.SetBool("isidle", false);
        }
    }
}
