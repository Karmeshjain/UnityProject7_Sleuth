using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Objectivescompletion : MonoBehaviour
{

    public Camera cam;
    float Distancefromtarget;
    public GameObject TextDisplay;
    public GameObject obj1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit Shot;
        if(Physics.Raycast(transform.position,cam.transform.forward , out Shot))
        {
            Distancefromtarget = Shot.distance;
        }
        if (Input.GetButtonDown("Action"))
        {
            if (Distancefromtarget <= 2)
            {
                StartCoroutine(TakeNineMil());
            }
        }
    }
    void OnMouseOver()
    {
        if (Distancefromtarget <= 2)
        {
            TextDisplay.GetComponent<Text>().text = "Take the Chip";
        }
    }

    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }

    IEnumerator TakeNineMil()
    {
        obj1.SetActive(true);

        transform.position = new Vector3(0, -1000, 0);
      
        yield return new WaitForSeconds(0.1f);
    }


}
