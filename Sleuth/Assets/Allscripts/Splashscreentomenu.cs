using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Splashscreentomenu : MonoBehaviour
{

     void Start()
    {
        StartCoroutine(Splashfinish());    
    }
    IEnumerator Splashfinish()
    {
        yield return new WaitForSeconds(12f);
        SceneManager.LoadScene("Mainmenu");
    }
}
