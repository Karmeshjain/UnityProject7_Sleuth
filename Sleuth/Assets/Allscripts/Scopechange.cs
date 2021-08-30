using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scopechange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject Playercam;
    public GameObject sniperobjecttex;
    //public GameObject orignalcurs;
    private bool zoomingin = false;
    public float fieldofview = 60f;
    public Camera clipping;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if (zoomingin == false)
            {
                clipping.cullingMask= 1 << LayerMask.NameToLayer("Nothing");  //use for clipping purposes
                sniperobjecttex.SetActive(true);
                //   orignalcurs.SetActive(false);
                
                StartCoroutine(Zoomingcam());
                zoomingin = true;
            }
        }
        if(Input.GetMouseButtonUp(1))
        {
            clipping.cullingMask = 1 << LayerMask.NameToLayer("Gun");
            StopAllCoroutines();
            fieldofview = 60;
            Playercam.GetComponent<Camera>().fieldOfView = fieldofview;
            sniperobjecttex.SetActive(false);
       
            //  orignalcurs.SetActive(true);
            zoomingin = false;

        }
    }
    IEnumerator Zoomingcam()
    {
        while(fieldofview>5)
        {
            Playercam.GetComponent<Camera>().fieldOfView = fieldofview;
            fieldofview -= 2f;  //decides speed of zooming that when we press right mouse button higher it is faster it zooms;
            yield return new WaitForSeconds(0.01f);
        }
    }
}
