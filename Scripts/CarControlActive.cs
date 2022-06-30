using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{

    public GameObject CarControl;
    public GameObject comcar01;

    void Start()
    {
        CarControl.GetComponent<CarController>().enabled = true;
        comcar01.GetComponent<CarAIControl>().enabled = true;
    }

}
