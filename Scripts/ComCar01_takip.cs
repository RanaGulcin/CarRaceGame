using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComCar01_takip : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject mark01;
    public GameObject mark02;
    public GameObject mark03;
    public GameObject mark04;
    public GameObject mark05;
    public GameObject mark06;
    public GameObject mark07;
    public GameObject mark08;
    public GameObject mark09;
    public GameObject mark10;
    public GameObject mark11;
    public GameObject mark12;
    public GameObject mark13;
    public GameObject mark14;
    public GameObject mark15;
    public GameObject mark16;
    public GameObject mark17;
    public int markTracker;
    void Update()
    {
        if (markTracker == 0)
        {
            TheMarker.transform.position = mark01.transform.position;
        }
        if (markTracker == 1)
        {
            TheMarker.transform.position = mark02.transform.position;
        }
        if (markTracker == 2)
        {
            TheMarker.transform.position = mark03.transform.position;
        }
        if (markTracker == 3)
        {
            TheMarker.transform.position = mark04.transform.position;
        }
        if (markTracker == 4)
        {
            TheMarker.transform.position = mark05.transform.position;
        }
        if (markTracker == 5)
        {
            TheMarker.transform.position = mark06.transform.position;
        }
        if (markTracker == 6)
        {
            TheMarker.transform.position = mark07.transform.position;
        }
        if (markTracker == 7)
        {
            TheMarker.transform.position = mark08.transform.position;
        }
        if (markTracker == 8)
        {
            TheMarker.transform.position = mark09.transform.position;
        }
        if (markTracker == 9)
        {
            TheMarker.transform.position = mark10.transform.position;
        }
        if (markTracker == 10)
        {
            TheMarker.transform.position = mark11.transform.position;
        }
        if (markTracker == 11)
        {
            TheMarker.transform.position = mark12.transform.position;
        }
        if (markTracker == 12)
        {
            TheMarker.transform.position = mark13.transform.position;
        }
        if (markTracker == 13)
        {
            TheMarker.transform.position = mark14.transform.position;
        }
        if (markTracker == 14)
        {
            TheMarker.transform.position = mark15.transform.position;
        }
        if (markTracker == 15)
        {
            TheMarker.transform.position = mark16.transform.position;
        }
        if (markTracker == 16)
        {
            TheMarker.transform.position = mark17.transform.position;
        }
    }
    IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "comcar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            markTracker += 1;
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
    

}
