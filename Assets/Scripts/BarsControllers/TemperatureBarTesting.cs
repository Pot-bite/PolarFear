using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureBarTesting : MonoBehaviour
{
    int maxtemp = 100;
    int currenttemp;

    public TemperatureBar temperature;



    private void Start()
    {
        currenttemp = maxtemp;
        temperature.SetMaxValue(maxtemp);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {

            TakeDamage(20);

        }
    }

    void TakeDamage(int damage)
    {
        currenttemp -= damage;
        temperature.SetValue(currenttemp);
    }
}
