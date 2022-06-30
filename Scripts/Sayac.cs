using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sayac : MonoBehaviour
{
    public GameObject sayac;
    public AudioSource ggo;
    public AudioSource rready;
    public GameObject carControl;
    void Start()
    {
        StartCoroutine(SayacStart());
    }
    IEnumerator SayacStart()
    {
        yield return new WaitForSeconds(0.5f);
        sayac.GetComponent<Text>().text = "3";
        rready.Play();
        sayac.SetActive(true);
        yield return new WaitForSeconds(1);
        sayac.SetActive(false);
        sayac.GetComponent<Text>().text = "2";
        rready.Play();
        sayac.SetActive(true);
        yield return new WaitForSeconds(1);
        sayac.SetActive(false);
        sayac.GetComponent<Text>().text = "1";
        rready.Play();
        sayac.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        sayac.SetActive(false);
        ggo.Play();
        carControl.SetActive(true);
    }
}
