using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class co2 : MonoBehaviour
{
    int maxValue = 100;
    int currentValue;

    public co2bar co2Value;



    private void Start()
    {
        currentValue = maxValue;
        co2Value.SetMaxValue(maxValue);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {

            TakeDamage(20);

        }
    }

    void TakeDamage(int damage)
    {
        currentValue -= damage;
        co2Value.SetValue(currentValue);
    }
}
