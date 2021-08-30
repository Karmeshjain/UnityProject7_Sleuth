using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Subvoice : MonoBehaviour
{
    public GameObject thesub;
    public AudioSource audiosub;
    IEnumerator Subtivoice()
    {
        yield return new WaitForSeconds(2f);
        audiosub.Play();
        thesub.GetComponent<Text>().text = "Listen john,Your task is to collect very rare artifacts and a chip, then extract through the helipad";
        yield return new WaitForSeconds(5f);
        thesub.GetComponent<Text>().text = "";
    }
    private void Start()
    {
        StartCoroutine(Subtivoice());
    }
}
