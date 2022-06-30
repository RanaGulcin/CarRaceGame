using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_Car : MonoBehaviour
{
    
    public GameObject car_blue;
    public GameObject car_red;
    public GameObject car_yellow;
    public GameObject buton;
    public GameObject map_obj;
    public GameObject comcar01;
    void Start()
    {
        Baslangic();
    }


    private void Baslangic()
    {
        car_blue.SetActive(false);
        car_red.SetActive(false);
        car_yellow.SetActive(false);
        comcar01.SetActive(false);
        map_obj.SetActive(false);
        buton.SetActive(true);
    }
    
    public void Blue()
    {
        car_blue.SetActive(true);
        car_red.SetActive(false);
        car_yellow.SetActive(false);
        buton.SetActive(false);
        map_obj.SetActive(true);
        comcar01.SetActive(true);
    }
    public void Red()
    {
        car_blue.SetActive(false);
        car_red.SetActive(true);
        car_yellow.SetActive(false);
        buton.SetActive(false);
        map_obj.SetActive(true);
        comcar01.SetActive(true);
    }

    public void Yellow()
    {
        car_blue.SetActive(false);
        car_red.SetActive(false);
        car_yellow.SetActive(true);
        buton.SetActive(false);
        map_obj.SetActive(true);
        comcar01.SetActive(true);
    }
}
